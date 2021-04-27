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
    public partial class Frm_GestaoProd : Form
    {
        public Frm_GestaoProd()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadProdutos frm_CadProdutos = new Frm_CadProdutos();
            frm_CadProdutos.Show();
            this.Close();
        }

        private void Frm_GestaoProd_Load(object sender, EventArgs e)
        {
            string sql = String.Format(@"
                                SELECT 
                                       tbp.N_IDPRODUTO as 'Id',
                                       tbp.T_NOMEPRODUTO as 'Nome do Produto',
                                       tbp.N_QTDE as 'Quantidade',
                                       tbp.N_PRECOCOMPRA as 'Preço de Compra',
                                       tbp.N_PRECOVENDA as 'Preço de Venda',
                                       tbf.T_NOMEFORNECEDOR as 'Fornecedor'
                                FROM
                                        tb_produtos as tbp
                                INNER JOIN
                                        tb_fornecedores as tbf on tbf.N_IDFORNECEDOR = tbp.N_IDFORNECEDOR
            ");
            Dgv_produtos.DataSource = Banco.dql(sql);

            sql = String.Format(@"
                                    SELECT 
                                            *
                                    FROM
                                            tb_fornecedores
            ");
            Cb_fornecedor.Items.Clear();
            Cb_fornecedor.DataSource = Banco.dql(sql);
            Cb_fornecedor.DisplayMember = "T_NOMEFORNECEDOR";
            Cb_fornecedor.ValueMember = "N_IDFORNECEDOR";
        }

        private void Dgv_produtos_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                DataTable dt = new DataTable();

                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();
                string query = String.Format(@"
                                        SELECT
                                                *
                                        FROM
                                                tb_produtos
                                        WHERE
                                                N_IDPRODUTO = {0}
                ",id);
                dt = Banco.dql(query);
                Txt_id.Text = dt.Rows[0].Field<Int64>("N_IDPRODUTO").ToString();
                Txt_nome.Text = dt.Rows[0].Field<string>("T_NOMEPRODUTO");
                Nud_qtde.Value = dt.Rows[0].Field<Int64>("N_QTDE");
                Txt_precoCompra.Text = dt.Rows[0].Field<Double>("N_PRECOCOMPRA").ToString();
                Txt_precoVenda.Text = dt.Rows[0].Field<Double>("N_PRECOVENDA").ToString();
                Cb_fornecedor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDFORNECEDOR");
            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                                    UPDATE
                                            tb_produtos
                                    SET
                                            T_NOMEPRODUTO = '{0}',
                                            N_QTDE = {1},
                                            N_PRECOCOMPRA = {2},
                                            N_PRECOVENDA = {3},
                                            N_IDFORNECEDOR = {4}
                                    WHERE
                                            N_IDPRODUTO = {5}
            ",Txt_nome.Text,Nud_qtde.Value,Txt_precoCompra.Text,Txt_precoVenda.Text,Cb_fornecedor.SelectedValue,Txt_id.Text);

            Banco.dml(query);
            MessageBox.Show("Dados do produto actualizado!");

            string sql = String.Format(@"
                                SELECT 
                                       tbp.N_IDPRODUTO as 'Id',
                                       tbp.T_NOMEPRODUTO as 'Nome do Produto',
                                       tbp.N_QTDE as 'Quantidade',
                                       tbp.N_PRECOCOMPRA as 'Preço de Compra',
                                       tbp.N_PRECOVENDA as 'Preço de Venda',
                                       tbf.T_NOMEFORNECEDOR as 'Fornecedor'
                                FROM
                                        tb_produtos as tbp
                                INNER JOIN
                                        tb_fornecedores as tbf on tbf.N_IDFORNECEDOR = tbp.N_IDFORNECEDOR
            ");
            Dgv_produtos.DataSource = Banco.dql(sql);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            string queryApagar = String.Format(@"
                            DELETE FROM
                                               tb_produtos
                            WHERE
                                                N_IDPRODUTO = {0}
            ",Txt_id.Text);
            Banco.dml(queryApagar);

            MessageBox.Show("Registo apagado!");
            Dgv_produtos.Rows.Remove(Dgv_produtos.CurrentRow);
        }
    }
}
