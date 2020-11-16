using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Vendas
{
    public partial class Frm_CadUsuarios : Form
    {
        public Frm_CadUsuarios()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            cb_funcionario.Enabled = true;
            cb_nivel.Enabled = true;
            txt_username.Enabled = true;
            txt_senha.Enabled = true;
            txt_senha2.Enabled = true;
            btn_salvar.Enabled = true;
            btn_novo.Enabled = false;
            btn_gerir.Enabled = false;
            cb_funcionario.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Digite o nome de usuário e a senha");
                return;
            }
            if (txt_senha.Text != txt_senha2.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return;
            }

            string queryVerificar = String.Format(@"
                            SELECT 
                                T_USERNAME,
                                N_IDFUNCIONARIO
                            FROM 
                                tb_usuarios
            ");
            DataTable dt = new DataTable();
            dt = Banco.dql(queryVerificar);
            string username = "";
            int idFuncionario = 0;
            for (int i=0;i<dt.Rows.Count;i++)
            {
                username = dt.Rows[i].Field<string>("T_USERNAME");
                 idFuncionario = int.Parse(dt.Rows[i].Field<Int64>("N_IDFUNCIONARIO").ToString());
                if (username == txt_username.Text)
                {
                    MessageBox.Show("Usuário Já existe");
                    return;
                }
                if (idFuncionario == int.Parse(cb_funcionario.SelectedValue.ToString()))
                {
                    MessageBox.Show("O funcionário já possuí conta de usuário");
                    return;
                }
            }
            
            string queryInsert = String.Format(@"
                     INSERT INTO 
                            tb_usuarios(T_USERNAME,T_SENHA,N_NIVEL,N_IDFUNCIONARIO)
                     VALUES (
                                '{0}',
                                '{1}',
                                 {2},
                                 {3}
                            )
                
            ",txt_username.Text,txt_senha.Text,cb_nivel.SelectedItem,cb_funcionario.SelectedValue);

            Banco.dml(queryInsert);
            MessageBox.Show("Usuário Inserido!");
            cb_funcionario.Enabled = false;
            cb_nivel.Enabled = false;
            txt_username.Enabled = false;
            txt_senha.Enabled = false;
            txt_senha2.Enabled = false;
            btn_salvar.Enabled = false;
            btn_novo.Enabled = true;
            btn_gerir.Enabled = true;
        }

        private void Frm_CadUsuarios_Load(object sender, EventArgs e)
        {
            string vqueryFuncionarios = String.Format(@"
                            SELECT
                                N_IDFUNCIONARIO,
                                T_NOMEFUNCIONARIO
                           FROM
                               tb_funcionarios");

            DataTable dt = new DataTable();

            dt = Banco.dql(vqueryFuncionarios);
            Dictionary<int, string> funcionario = new Dictionary<int, string>();
            for (int i=0;i < dt.Rows.Count;i++)
            {
                funcionario.Add(int.Parse(dt.Rows[i].Field<Int64>("N_IDFUNCIONARIO").ToString()), dt.Rows[i].Field<string>("T_NOMEFUNCIONARIO").ToString());
            }
            
            cb_funcionario.DataSource = new BindingSource(funcionario,null);
            cb_funcionario.DisplayMember = "Value";
            cb_funcionario.ValueMember = "Key";
        }

        private void btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_GestaoUsuarios frm_GestaoUsuarios = new Frm_GestaoUsuarios();
            frm_GestaoUsuarios.ShowDialog();
            this.Close();
            
        }
    }
}
