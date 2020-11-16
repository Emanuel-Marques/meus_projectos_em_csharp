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
    public partial class Frm_GerirProdutos : Form
    {
        public Frm_GerirProdutos()
        {
            InitializeComponent();
        }

        private void Frm_GerirProdutos_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                    SELECT 
                            tbp.N_IDPRODUTO as 'Id',
                            tbp.T_NOMEPRODUTO as 'Produto',
                            tbp.N_QTDE as 'Quantidade',
                            tbp.N_PRECO_COMPRA as 'Preço de Compra',
                            tbp.N_PRECO_VENDA as 'Preço de Venda',
                            tbf.T_NOMEFORNECEDOR as 'Fornecedor'
                    FROM
                        tb_produtos as 'tbp'
                    INNER JOIN 
                        tb_fornecedores as 'tbf' on tbf.N_IDFORNECEDOR = tbp.N_IDFORNECEDOR
            ");
            dgv_produtos.DataSource = Banco.dql(query);
            dgv_produtos.Columns[0].Width = 20;
            dgv_produtos.Columns[1].Width = 170;
            dgv_produtos.Columns[2].Width = 80;
            dgv_produtos.Columns[5].Width = 120;
        }
    }
}
