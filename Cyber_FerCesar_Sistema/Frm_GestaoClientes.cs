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
    public partial class Frm_GestaoClientes : Form
    {
       
        public Frm_GestaoClientes()
        {
            InitializeComponent();
            string sql = String.Format(@"
                                SELECT 
                                        N_IDCLIENTE as 'Id',
                                        T_NOMECLIENTE as 'Nome do Cliente',
                                        T_CONTACTO as 'Contacto'
                                FROM
                                        tb_clientes
            ");
            Dgv_clientes.DataSource = Banco.dql(sql);
            Dgv_clientes.Columns[0].Width = 20;
            Dgv_clientes.Columns[1].Width = 250;
            Dgv_clientes.Columns[2].Width = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = String.Format(@"
                                UPDATE 
                                        tb_clientes
                                SET
                                        T_NOMECLIENTE = '{0}',
                                        T_CONTACTO = '{1}'
                                WHERE
                                        N_IDCLIENTE = {2}
            ",Txt_nomeCliente.Text,Mtxt_contacto.Text,Txt_id.Text);
            Banco.dml(query);
            MessageBox.Show("Cadastro Actualizado!");

            string sql = String.Format(@"
                                SELECT 
                                        N_IDCLIENTE as 'Id',
                                        T_NOMECLIENTE as 'Nome do Cliente',
                                        T_CONTACTO as 'Contacto'
                                FROM
                                        tb_clientes
            ");
            Dgv_clientes.DataSource = Banco.dql(sql);
        }

        private void Dgv_clientes_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                string idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string sql = String.Format(@"
                                        SELECT 
                                                *
                                        FROM
                                                tb_clientes
                                        WHERE
                                                N_IDCLIENTE = {0}
                ",idSelecionado);

                dt = Banco.dql(sql);
                Txt_id.Text = dt.Rows[0].Field<Int64>("N_IDCLIENTE").ToString();
                Txt_nomeCliente.Text = dt.Rows[0].Field<string>("T_NOMECLIENTE");
                Mtxt_contacto.Text = dt.Rows[0].Field<string>("T_CONTACTO");
            }

        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_CadCliente frm_CadCliente = new Frm_CadCliente();
            frm_CadCliente.Show();
            this.Close();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Quer eliminar registo?", "Confirmar", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                string sql = String.Format(@"
                                    DELETE FROM
                                                tb_clientes
                                    WHERE
                                                N_IDCLIENTE = {0}
                ",Txt_id.Text);
                Banco.dml(sql);
                MessageBox.Show("Registo excluido!");
                Dgv_clientes.Rows.Remove(Dgv_clientes.CurrentRow);
            }
        }
    }
}
