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
    public partial class Frm_CadCliente : Form
    {
        public Frm_CadCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Txt_nome.Enabled = true;
            Mtxt_contacto.Enabled = true;
            Txt_nome.Clear();
            Mtxt_contacto.Clear();
            Btn_salvar.Enabled = true;
            Btn_novo.Enabled = false;
            Txt_nome.Focus();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (Txt_nome.Text == "" || Txt_nome.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }
            string query = String.Format(@"
                                INSERT 
                                    INTO
                                           tb_clientes(T_NOMECLIENTE,T_CONTACTO)
                                VALUES('{0}','{1}')
            ",Txt_nome.Text,Mtxt_contacto.Text);
            Banco.dml(query);
            MessageBox.Show("Cliente cadastrado!");
            Txt_nome.Enabled = false;
            Mtxt_contacto.Enabled = false;
            Btn_salvar.Enabled = false;
            Btn_novo.Enabled = true;
        }

        private void Btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_GestaoClientes frm_GestaoClientes = new Frm_GestaoClientes();
            frm_GestaoClientes.Show();
            this.Close();
        }
    }
}
