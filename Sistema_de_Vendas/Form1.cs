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
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_username.Focus();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string queryConsulta = String.Format(@"
                        SELECT 
                                tbu.N_IDUSUARIO,
                                tbu.T_USERNAME,
                                tbu.T_SENHA,
                                tbu.N_NIVEL,
                                tbf.T_NOMEFUNCIONARIO
                        FROM 
                                tb_usuarios  as tbu
                        INNER JOIN 
                                tb_funcionarios as tbf on tbf.N_IDFUNCIONARIO = tbu.N_IDFUNCIONARIO
                        WHERE 
                                tbu.T_USERNAME ='{0}'
                        and
                                tbu.T_SENHA = '{1}'
                        
                        ", txt_username.Text,txt_senha.Text);

            if (txt_username.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Os campos não podem ficar em branco");
                return;
            }

            dt = Banco.dql(queryConsulta);

            if (dt.Rows.Count == 1)
            {
                Globais.nome = dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO");
                Globais.username = dt.Rows[0].Field<string>("T_USERNAME");
                Globais.senha = dt.Rows[0].Field<string>("T_SENHA");
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_NIVEL").ToString());
                this.Hide();
               // MessageBox.Show(Globais.nome);
                Frm_Menu frm_Menu = new Frm_Menu(this);
                frm_Menu.Show();
            }
            else
            {
                MessageBox.Show("Username ou senha incorreto");
            }



            
        }
    }
}
