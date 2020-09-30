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
    public partial class Frm_Menu : Form
    {
        Form1 form1;
        public Frm_Menu(Form1 f)
        {
            InitializeComponent();
            form1 = f;
        }
        private static void AbreForm(int nivel, Form form)
        {
            if (Globais.nivel > 0)
            {
                form.Show();
            }
            else
            {
                MessageBox.Show("Acesso Negado!");
            }
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
            form1.txt_nomeUsuario.Text = "";
            form1.txt_senha.Text = "";
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadFuncionarios janela = new Frm_CadFuncionarios();
            janela.TopLevel = false;
            janela.WindowState = FormWindowState.Maximized;
            AbreForm(1,janela);
            pnl_painel.Controls.Add(janela);

        }

        private void gerirUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestaoUsuarios frm_GestaoUsuarios = new Frm_GestaoUsuarios();
            frm_GestaoUsuarios.TopLevel = false;
            AbreForm(1,frm_GestaoUsuarios);
            pnl_painel.Controls.Add(frm_GestaoUsuarios);
        }
    }
}
