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
    public partial class Frm_Menu : Form
    {
        Form1 form1;
        public Frm_Menu(Form1 f)
        {
            InitializeComponent();
            form1 = f;
            Lbl_nome.Text = Globais.nome;
            Lbl_nivel.Text = Globais.nivel.ToString();

            if (Lbl_nivel.Text == "1")
            {
                Lbl_tipoConta.Text = "Administrador";
            }
            else
            {
                Lbl_tipoConta.Text = "Vendedor";
            }
        }

        private void Frm_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Frm_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Funcionarios frm_Funcionarios = new Frm_Funcionarios();
            frm_Funcionarios.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();

        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadUsuario frm_CadUsuario = new Frm_CadUsuario();
            frm_CadUsuario.Show();
        }
    }
}
