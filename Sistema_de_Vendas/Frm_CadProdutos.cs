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
    public partial class Frm_CadProdutos : Form
    {
        public Frm_CadProdutos()
        {
            InitializeComponent();
        }

        private void Frm_CadProdutos_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        SELECT
                            N_IDFORNECEDOR,
                            T_NOMEFORNECEDOR
                        FROM
                            tb_fornecedores
            ");

            cb_fornecedor.DataSource = Banco.dql(query);
            cb_fornecedor.DisplayMember = "T_NOMEFORNECEDOR";
            cb_fornecedor.ValueMember = "N_IDFORNECEDOR";
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            txt_precoCompra.Enabled = true;
            txt_precoVenda.Enabled = true;
            nud_qtde.Enabled = true;
            cb_fornecedor.Enabled = true;
            btn_salvar.Enabled = true;
            btn_Novo.Enabled = false;
            txt_nome.Clear();
            txt_precoCompra.Clear();
            txt_precoVenda.Clear();
            nud_qtde.Value = 0;
           
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_precoCompra.Text == "" || txt_precoVenda.Text == "" )
            {
                MessageBox.Show("O preenchimento de todos os campos é obrigatório");
                return;
            }
            string querySalvar = String.Format(@"
                            INSERT INTO 
                                   tb_produtos
                                (
                                T_NOMEPRODUTO,
                                N_QTDE,
                                N_PRECO_COMPRA,
                                N_PRECO_VENDA,
                                N_IDFORNECEDOR
                                ) 
                            VALUES
                                   (
                                    '{0}',
                                    {1},
                                    {2},
                                    {3},
                                    {4}
                                    )
            ",txt_nome.Text,nud_qtde.Value,float.Parse(txt_precoCompra.Text),float.Parse(txt_precoVenda.Text),cb_fornecedor.SelectedValue);
            Banco.dml(querySalvar);
            MessageBox.Show("Produto Cadastrado!");
            txt_nome.Enabled = false;
            txt_precoCompra.Enabled = false;
            txt_precoVenda.Enabled = false;
            nud_qtde.Enabled = false;
            cb_fornecedor.Enabled = false;
            btn_salvar.Enabled = false;
            btn_Novo.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_GerirProdutos frm_GerirProdutos = new Frm_GerirProdutos();
            frm_GerirProdutos.Show();
            this.Close();
        }
    }
}
