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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_entar_Click(object sender, EventArgs e)
        {
            string username = Txt_username.Text;
            string senha = Txt_senha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
                return;
            }
            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME = '" + username + "' AND T_SENHA = '" + senha + "'";

            string query = String.Format(@"
                               SELECT 
                                   tbu.N_IDUSUARIO,
                                   tbu.T_USERNAME,
                                   tbu.T_SENHA,
                                   tbu.N_NIVEL,
                                   tbu.T_STATUS,
                                   tbf.T_NOMEFUNCIONARIO
                               FROM
                                   tb_usuarios as tbu
                               INNER JOIN
                               tb_funcionario as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO

                       ");

            dt = Banco.dql(sql);

            if (dt.Rows.Count == 1)
            {
                dt = Banco.dql(query);
                Globais.nome = dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO");
                Globais.nivel = Convert.ToInt32(dt.Rows[0].Field<Int64>("N_NIVEL"));

                Frm_Menu frm_Menu = new Frm_Menu(this);
                frm_Menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
        }
    }
}
