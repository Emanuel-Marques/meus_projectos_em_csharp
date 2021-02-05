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

namespace Cyber_FerCesar_Sistema
{
    public partial class Frm_Funcionarios : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        public Frm_Funcionarios()
        {
            InitializeComponent();
        }

        private void Frm_Funcionarios_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Txt_nome.Enabled = true;
            Txt_pai.Enabled = true;
            Txt_mae.Enabled = true;
            Txt_BI.Enabled = true;
            Txt_natural.Enabled = true;
            Mtxt_telefone.Enabled = true;
            Txt_email.Enabled = true;
            Txt_facebook.Enabled = true;
            Txt_bairro.Enabled = true;
            Txt_municipio.Enabled = true;
            Btn_salvar.Enabled = true;
            Btn_foto.Enabled = true;
            Btn_novo.Enabled = false;

            Txt_nome.Clear();
            Txt_pai.Clear();
            Txt_mae.Clear();
            Txt_BI.Clear();
            Txt_natural.Clear();
            Mtxt_telefone.Clear();
            Txt_email.Clear();
            Txt_facebook.Clear();
            Txt_bairro.Clear();
            Txt_municipio.Clear();
            Pb_foto.Image = Properties.Resources.Usuario;

            Txt_nome.Focus();
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            if(Txt_nome.Text == "" || Txt_pai.Text == "" || Txt_mae.Text == "" || Txt_natural.Text == "" || Txt_BI.Text == "" || Txt_email.Text == "" || Txt_facebook.Text == "" || Txt_municipio.Text == "" || Txt_bairro.Text == "" || Mtxt_telefone.Text == "")
            {
                MessageBox.Show("TODOS OS CAMPOS SÃO OBRIGATÓRIOS!");
                return;
            }
            if (destinoCompleto == "")
            {
               
                if (MessageBox.Show("Sem foto selecionada, deseja continuar ?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    Pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO ao localizar a imagem, deseja continuar ?","Continuar?",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string query =String.Format( @" INSERT 
                                INTO 
                                    tb_funcionario
                                (
                                  T_NOMEFUNCIONARIO,
                                   T_PAI,
                                    T_MAE,
                                    T_BI,
                                    T_NATURALIDADE,
                                    T_TELEFONE,
                                    T_EMAIL,
                                    T_FACEBOOK,
                                    T_BAIRRO,
                                    T_MUNICIPIO,
                                    T_FOTO
                                )
                            VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')
         ",Txt_nome.Text,Txt_pai.Text,Txt_mae.Text,Txt_BI.Text,Txt_natural.Text,Mtxt_telefone.Text,Txt_email.Text,Txt_facebook.Text,Txt_bairro.Text,Txt_municipio.Text,destinoCompleto);

            Banco.dml(query);
            MessageBox.Show("Funcionárion Cadastrado!");

            Txt_nome.Enabled = false;
            Txt_pai.Enabled = false;
            Txt_mae.Enabled = false;
            Txt_BI.Enabled = false;
            Txt_natural.Enabled = false;
            Mtxt_telefone.Enabled = false;
            Txt_email.Enabled = false;
            Txt_facebook.Enabled = false;
            Txt_bairro.Enabled = false;
            Txt_municipio.Enabled = false;
            Btn_salvar.Enabled = false;
            Btn_foto.Enabled = false;
            Btn_novo.Enabled = true;
        }

        private void Btn_foto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + Globais.FotosFuncionarios + foto;
            }
            if (File.Exists(destinoCompleto))
            {
                if (MessageBox.Show("Arquivo já existe, deseja sobrescrever?","Substituir?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            Pb_foto.ImageLocation = origemCompleto;
        }
    }
}
