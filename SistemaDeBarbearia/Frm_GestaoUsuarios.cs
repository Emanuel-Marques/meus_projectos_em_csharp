using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeBarbearia
{
    public partial class Frm_GestaoUsuarios : Form
    {
        public Frm_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            string vquery = "SELECT N_IDUSUARIO as 'Id', T_NOME as 'Nome', T_USERNAME as 'Nome de Usuário', T_SENHA as 'Senha', N_NIVEL as 'Nível' FROM tb_usuarios";
            dgv_usuarios.DataSource = Banco.dql(vquery);
            dgv_usuarios.Columns[0].Width = 30;
            dgv_usuarios.Columns[1].Width = 60;
            dgv_usuarios.Columns[2].Width = 120;
            dgv_usuarios.Columns[3].Width = 50;
            dgv_usuarios.Columns[4].Width = 50;

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_idUser.Clear();
            txt_nomeUser.Clear();
            txt_usernameUser.Clear();
            txt_senha.Clear();
            txt_senha2.Clear();
            nud_nivel.Value = 0;
            txt_nomeUser.Focus();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender; 
            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string vquery = "SELECT * FROM tb_usuarios WHERE N_IDUSUARIO="+vid;
                dt = Banco.dql(vquery);
                txt_idUser.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                txt_nomeUser.Text = dt.Rows[0].Field<string>("T_NOME").ToString();
                txt_usernameUser.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                txt_senha.Text = dt.Rows[0].Field<string>("T_SENHA").ToString();
                txt_senha2.Text = dt.Rows[0].Field<string>("T_SENHA").ToString();
                nud_nivel.Value = Convert.ToInt32(dt.Rows[0].Field<Int64>("N_NIVEL").ToString());
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string vquery;
            if (txt_senha.Text == txt_senha2.Text)
            {
                if (txt_idUser.Text == "")
                {
                    vquery = "INSERT INTO tb_usuarios (T_NOME,T_USERNAME,T_SENHA,N_NIVEL) VALUES('" + txt_nomeUser.Text + "','" + txt_usernameUser.Text + "','" + txt_senha.Text + "'," + nud_nivel.Value + ")";

                }
                else
                {
                    vquery = "UPDATE tb_usuarios SET T_NOME='" + txt_nomeUser.Text + "',T_USERNAME='" + txt_usernameUser.Text + "',T_SENHA='" + txt_senha.Text + "',N_NIVEL=" + nud_nivel.Value + " WHERE N_IDUSUARIO=" + txt_idUser.Text;
                }
                Banco.dml(vquery);
                vquery = "SELECT N_IDUSUARIO as 'Id', T_NOME as 'Nome', T_USERNAME as 'Nome de Usuário', T_SENHA as 'Senha', N_NIVEL as 'Nível' FROM tb_usuarios";
                dgv_usuarios.DataSource = Banco.dql(vquery);
            }
            else
            {
                MessageBox.Show("As senhas devem ser iguais!");
            }
            
           
        }
    }
}
