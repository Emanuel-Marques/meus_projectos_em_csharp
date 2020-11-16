using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Vendas
{
   
    public partial class Frm_CadFuncionarios : Form
    {
        string origemCompleta = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public Frm_CadFuncionarios()
        {
            InitializeComponent();
        }

        private void btn_gerir_Click(object sender, EventArgs e)
        {
            Frm_GerirFuncionarios frm_GerirFuncionarios = new Frm_GerirFuncionarios();
            frm_GerirFuncionarios.ShowDialog();
            this.Close();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            txt_nome.Enabled = true;
            txt_pai.Enabled = true;
            txt_mae.Enabled = true;
            txt_naturalidade.Enabled = true;
            txt_bairro.Enabled = true;
            txt_bi.Enabled = true;
            txt_email.Enabled = true;
            txt_telefone.Enabled = true;
            txt_municipio.Enabled = true;
            btn_novo.Enabled = false;
            btn_salvar.Enabled = true;
            btn_foto.Enabled = true;
            txt_nome.Focus();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (txt_nome.Text == "" || txt_pai.Text == "" ||txt_mae.Text == "" || txt_naturalidade.Text == "" || txt_municipio.Text == "" ||txt_telefone.Text == "" ||txt_email.Text == "" ||txt_bi.Text == "" || txt_bairro.Text == "")
            {
                MessageBox.Show("Todos os campos são obrigatórios!");
                return;
            }
            if (destinoCompleto == "")
            {
                if (MessageBox.Show("Sem foto selecionada, deseja continuar?","Continuar?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleta,destinoCompleto,true);
                if (File.Exists(destinoCompleto))
                {
                    pb_funcionario.ImageLocation = destinoCompleto;
                }
                else
                {
                    if(MessageBox.Show("ERRO ao localizar foto, deseja continuar ?","Continuar?",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            string queryInsertFuncionario = String.Format(@"
                            INSERT INTO
                                tb_funcionarios
                            (T_NOMEFUNCIONARIO,
                             T_PAI,
                             T_MAE,
                             T_BI,
                             T_NATURAL,
                                T_TELEFONE,
                                T_EMAIL,
                                T_BAIRRO,
                                T_MUNICIPIO,
                                T_FOTO)
                              VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')
            ",txt_nome.Text,txt_pai.Text,txt_mae.Text,txt_bi.Text,txt_naturalidade.Text,txt_telefone.Text,txt_email.Text,txt_bairro.Text,txt_municipio.Text,destinoCompleto);
            Banco.dml(queryInsertFuncionario);
            txt_nome.Enabled = false;
            txt_pai.Enabled = false;
            txt_mae.Enabled = false;
            txt_naturalidade.Enabled = false;
            txt_bairro.Enabled = false;
            txt_bi.Enabled = false;
            txt_email.Enabled = false;
            txt_telefone.Enabled = false;
            txt_municipio.Enabled = false;
            btn_novo.Enabled = true;
            btn_salvar.Enabled = false;
            MessageBox.Show("Funcionário cadastrado!");
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleta = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja sobrepor ?","Sobrepor ?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            pb_funcionario.ImageLocation = origemCompleta;
        }
    }
}
