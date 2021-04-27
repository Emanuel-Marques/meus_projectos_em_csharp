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
    public partial class Frm_CadProdutos : Form
    {
        public Frm_CadProdutos()
        {
            InitializeComponent();

            string sql = String.Format(@"
                                            SELECT
                                                   N_IDFORNECEDOR,
                                                   T_NOMEFORNECEDOR
                                            FROM
                                                    tb_fornecedores
                                            
                                        
            ");
            Cb_fornecedor.DataSource = Banco.dql(sql);
            Cb_fornecedor.DisplayMember = "T_NOMEFORNECEDOR";
            Cb_fornecedor.ValueMember = "N_IDFORNECEDOR";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Txt_nomeProd.Text == "" || Txt_precoCompra.Text == "" || Txt_precoVenda.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }
            Txt_nomeProd.Enabled = false;
            Nud_qtde.Enabled = false;
            Txt_precoCompra.Enabled = false;
            Txt_precoVenda.Enabled = false;
            Cb_fornecedor.Enabled = false;
            Btn_salvar.Enabled = false;
            Btn_novo.Enabled = true;
            string query = String.Format(@"
                            INSERT 
                                INTO
                                    tb_produtos
                                               (
                                                T_NOMEPRODUTO,
                                                N_QTDE,
                                                N_PRECOCOMPRA,
                                                N_PRECOVENDA,
                                                N_IDFORNECEDOR
                                                )
                                VALUES(
                                        '{0}',{1},{2},{3},{4}
                                       )
            ", Txt_nomeProd.Text,Nud_qtde.Value,Convert.ToDouble(Txt_precoCompra.Text),Convert.ToDouble(Txt_precoVenda.Text),Cb_fornecedor.SelectedValue);
            Banco.dml(query);
            MessageBox.Show("Produto Cadastrado!");

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Txt_nomeProd.Clear();
            Nud_qtde.Value = 0;
            Txt_precoCompra.Clear();
            Txt_precoVenda.Clear();


            Txt_nomeProd.Enabled = true;
            Nud_qtde.Enabled = true;
            Txt_precoCompra.Enabled = true;
            Txt_precoVenda.Enabled = true;
            Cb_fornecedor.Enabled = true;
            Btn_salvar.Enabled = true;
            Btn_novo.Enabled = false;
            Txt_nomeProd.Focus();

        }

        private void Btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_GestaoProd frm_GestaoProd = new Frm_GestaoProd();
            frm_GestaoProd.Show();
        }
    }
}
