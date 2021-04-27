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
    public partial class Frm_CadFornecedor : Form
    {
        public Frm_CadFornecedor()
        {
            InitializeComponent();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Txt_nome.Enabled = true;
            Txt_nome.Clear();
            Txt_nome.Focus();
            Txt_telefone.Enabled = true;
            Txt_telefone.Clear();
            Txt_nif.Enabled = true;
            Txt_nif.Clear();
            Btn_salvar.Enabled = true;
            Btn_novo.Enabled = false;



        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if (Txt_nome.Text == "" || Txt_telefone.Text =="" || Txt_nif.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }
            Txt_nome.Enabled = false;
            Txt_telefone.Enabled = false;
            Txt_nif.Enabled = false;
            Btn_salvar.Enabled = false;
            Btn_novo.Enabled = true;

            string query = String.Format(@"
                                            INSERT INTO 
                                                        tb_fornecedores(T_NOMEFORNECEDOR,T_TELEFONE,T_NIF)
                                            VALUES('{0}','{1}','{2}')                                            
            ",Txt_nome.Text,Txt_telefone.Text,Txt_nif.Text);
            Banco.dml(query);
            MessageBox.Show("Fornecedor Cadastrado!");
        }

        private void Btn_gestao_Click(object sender, EventArgs e)
        {
            Frm_GestaoFornecedor frm_GestaoFornecedor = new Frm_GestaoFornecedor();
            frm_GestaoFornecedor.Show();
            this.Close();
        }
    }
}
