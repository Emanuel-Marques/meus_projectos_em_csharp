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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string username = txt_nomeUsuario.Text;
            string senha = txt_senha.Text;
            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário senha inválidos!");
                return;
            }

            string sql = "SELECT * FROM tb_usuarios WHERE T_USERNAME='"+username+"' AND T_SENHA='"+senha+"'";

            dt = Banco.dql(sql);
            if (dt.Rows.Count == 1)
            {
                Frm_Menu frm_Menu = new Frm_Menu(this);
                frm_Menu.Show();
                Globais.nivel = Convert.ToInt32(dt.Rows[0].Field<Int64>("N_NIVEL").ToString());
                Globais.nome = dt.Rows[0].Field<string>("T_NOME").ToString();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
            }
            this.Hide();
        }
    }
}
