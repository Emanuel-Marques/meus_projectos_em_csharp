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

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadProdutos frm_CadProdutos = new Frm_CadProdutos();
            frm_CadProdutos.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadCliente frm_CadCliente = new Frm_CadCliente();
            frm_CadCliente.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GestaoClientes frm_GestaoClientes = new Frm_GestaoClientes();
            frm_GestaoClientes.Show();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GestaoUsuarios frm_GestaoUsuarios = new Frm_GestaoUsuarios();
            frm_GestaoUsuarios.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GestaoProd frm_GestaoProd = new Frm_GestaoProd();
            frm_GestaoProd.Show();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_GestaoFornecedor frm_GestaoFornecedor = new Frm_GestaoFornecedor();
            frm_GestaoFornecedor.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadFornecedor frm_CadFornecedor = new Frm_CadFornecedor();
            frm_CadFornecedor.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_GestaoFuncionarios frm_GestaoFuncionarios = new Frm_GestaoFuncionarios();
            frm_GestaoFuncionarios.Show();
        }
    }
}
