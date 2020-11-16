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
    public partial class Frm_Menu : Form
    {
        Form1 login;
        public Frm_Menu(Form1 f)
        {
            InitializeComponent();
            login = f;
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadUsuarios frm_CadUsuarios = new Frm_CadUsuarios();
            frm_CadUsuarios.ShowDialog();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GestaoUsuarios frm_GestaoUsuarios = new Frm_GestaoUsuarios();
            frm_GestaoUsuarios.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadFuncionarios frm_CadFuncionarios = new Frm_CadFuncionarios();
            frm_CadFuncionarios.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GerirFuncionarios frm_GerirFuncionarios = new Frm_GerirFuncionarios();
            frm_GerirFuncionarios.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadProdutos frm_CadProdutos = new Frm_CadProdutos();
            frm_CadProdutos.ShowDialog();
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GerirProdutos frm_GerirProdutos = new Frm_GerirProdutos();
            frm_GerirProdutos.ShowDialog();
        }
    }
}
