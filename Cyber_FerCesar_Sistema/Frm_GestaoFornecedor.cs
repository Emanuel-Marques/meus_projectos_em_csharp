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
    public partial class Frm_GestaoFornecedor : Form
    {
        public Frm_GestaoFornecedor()
        {
            InitializeComponent();
        }

        private void Frm_GestaoFornecedor_Load(object sender, EventArgs e)
        {
            string sql = String.Format(@"
                                    SELECT 
                                            N_IDFORNECEDOR as 'Id',
                                            T_NOMEFORNECEDOR as 'Nome',
                                            T_TELEFONE as 'Teçefone',
                                            T_NIF as 'NIF'
                                    FROM
                                            tb_fornecedores
            ");
            Dgv_fornecedor.DataSource = Banco.dql(sql);

            Dgv_fornecedor.Columns[0].Width = 20;
            Dgv_fornecedor.Columns[1].Width = 200;
            Dgv_fornecedor.Columns[2].Width = 100;
            Dgv_fornecedor.Columns[3].Width = 100;

        }

        private void Dgv_fornecedor_SelectionChanged(object sender, EventArgs e)
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
                                                            tb_fornecedores
                                                    WHERE
                                                            N_IDFORNECEDOR = {0}
                ",id);
                dt = Banco.dql(query);
                Txt_id.Text = dt.Rows[0].Field<Int64>("N_IDFORNECEDOR").ToString();
                Txt_nome.Text = dt.Rows[0].Field<string>("T_NOMEFORNECEDOR");
                Txt_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                Txt_nif.Text = dt.Rows[0].Field<string>("T_NIF");
            }
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadFornecedor frm_CadFornecedor = new Frm_CadFornecedor();
            frm_CadFornecedor.Show();
            this.Close();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        UPDATE
                                tb_fornecedores 
                        SET
                                T_NOMEFORNECEDOR = '{0}', 
                                T_TELEFONE = '{1}', 
                                T_NIF = '{2}'
                        WHERE
                                N_IDFORNECEDOR = {3}
            ",Txt_nome.Text,Txt_telefone.Text,Txt_nif.Text,Txt_id.Text);
            Banco.dml(query);
            MessageBox.Show("Dados do fornecedor actualizado!");
            string sql = String.Format(@"
                                    SELECT 
                                            N_IDFORNECEDOR as 'Id',
                                            T_NOMEFORNECEDOR as 'Nome',
                                            T_TELEFONE as 'Teçefone',
                                            T_NIF as 'NIF'
                                    FROM
                                            tb_fornecedores
            ");
            Dgv_fornecedor.DataSource = Banco.dql(sql);
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            string sql = String.Format(@"
                                DELETE FROM
                                        tb_fornecedores
                                WHERE
                                        N_IDFORNECEDOR = {0}
            ",Txt_id.Text);
            Banco.dml(sql);
            MessageBox.Show("Registo apagado!");
            Dgv_fornecedor.Rows.Remove(Dgv_fornecedor.CurrentRow);
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
