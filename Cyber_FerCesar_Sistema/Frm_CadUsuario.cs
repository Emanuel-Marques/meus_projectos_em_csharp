using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyber_FerCesar_Sistema
{
    public partial class Frm_CadUsuario : Form
    {
        public Frm_CadUsuario()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Cb_nome.Enabled = true;
            Nud_nivel.Enabled = true;
            Cb_status.Enabled = true;
            Txt_senha.Enabled = true;
            Txt_senha2.Enabled = true;
            Txt_username.Enabled = true;
            Btn_novo.Enabled = false;
            Btn_salvar.Enabled = true;

            Txt_username.Focus();

        }

        private void Frm_CadUsuario_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                            SELECT 
                                  N_IDFUNCIONARIO,
                                  T_NOMEFUNCIONARIO
                            FROM
                                  tb_funcionario
            ");

            Cb_nome.Items.Clear();
            Cb_nome.DataSource = Banco.dql(query);
            Cb_nome.DisplayMember = "T_NOMEFUNCIONARIO";
            Cb_nome.ValueMember = "N_IDFUNCIONARIO";

            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A","Activo");
            st.Add("B","Bloqueado");
            st.Add("I","Inativo");
            

            Cb_status.Items.Clear();
            Cb_status.DataSource = new BindingSource(st,null);
            Cb_status.DisplayMember = "Value";
            Cb_status.ValueMember = "Key";

        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                            SELECT 
                                    *
                            FROM
                                    tb_usuarios
                            WHERE
                                    N_IDFUNCIONARIO = {0}
            ", Cb_nome.SelectedValue);
            DataTable VerificaFuncionario = new DataTable();
            VerificaFuncionario = Banco.dql(query);
            if (VerificaFuncionario.Rows.Count > 0)
            {
                MessageBox.Show("Este funcionário já possuí conta associada!");
                return;
            }
            if (Txt_senha.Text != Txt_senha2.Text)
            {
                MessageBox.Show("As senhas não são iguais!");
                return;
            }
            if (Txt_username.Text == "" || Txt_senha.Text == "" || Txt_senha2.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            string sql = String.Format(@"INSERT 
                                            INTO 
                                                tb_usuarios(T_USERNAME,T_SENHA,N_NIVEL,T_STATUS,N_IDFUNCIONARIO)
                                        VALUES(
                                                '{0}','{1}',{2},'{3}',{4}
                                               )
            ",Txt_username.Text,Txt_senha.Text,Nud_nivel.Value,Cb_status.SelectedValue,Cb_nome.SelectedValue);
            Banco.dml(sql);
            MessageBox.Show("Usuário cadastrado!");
            Cb_nome.Enabled = false;
            Nud_nivel.Enabled = false;
            Cb_status.Enabled = false;
            Txt_senha.Enabled = false;
            Txt_senha2.Enabled = false;
            Txt_username.Enabled = false;
            Btn_novo.Enabled = true;
            Btn_salvar.Enabled = false;



            
        }

        private void Btn_GerirUsuarios_Click(object sender, EventArgs e)
        {
            Frm_GestaoUsuarios frm_GestaoUsuarios = new Frm_GestaoUsuarios();
            frm_GestaoUsuarios.Show();
        }
    }
}
