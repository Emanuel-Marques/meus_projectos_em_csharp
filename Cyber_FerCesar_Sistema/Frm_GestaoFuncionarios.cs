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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Cyber_FerCesar_Sistema
{
    public partial class Frm_GestaoFuncionarios : Form
    {
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";
        string imagemAntiga = "";
        public Frm_GestaoFuncionarios()
        {
            InitializeComponent();
        }

        private void Frm_GestaoFuncionarios_Load(object sender, EventArgs e)
        {
            string query = String.Format(@"
                        SELECT 
                                N_IDFUNCIONARIO as 'Id',
                                T_NOMEFUNCIONARIO as 'Nome',
                                T_PAI as 'Pai',
                                T_MAE as 'Mãe',
                                T_BI as 'Nº do BI',
                                T_NATURALIDADE as 'Naturalidade',
                                T_TELEFONE as 'Telefone',
                                T_EMAIL as 'Email',
                                T_FACEBOOK as 'Facebook',
                                T_BAIRRO as 'Bairro',
                                T_MUNICIPIO as 'Municipio'
                        FROM
                                tb_funcionario
            ");
            Dgv_funcionarios.DataSource = Banco.dql(query);
            Dgv_funcionarios.Columns[0].Width = 20;
            Dgv_funcionarios.Columns[1].Width = 200;
            Dgv_funcionarios.Columns[2].Width = 150;
            Dgv_funcionarios.Columns[3].Width = 150;
            Dgv_funcionarios.Columns[4].Width = 100;
            Dgv_funcionarios.Columns[5].Width = 80;
            Dgv_funcionarios.Columns[6].Width = 100;
            Dgv_funcionarios.Columns[7].Width = 80;
            Dgv_funcionarios.Columns[8].Width = 80;
            Dgv_funcionarios.Columns[9].Width = 50;
            Dgv_funcionarios.Columns[10].Width = 50;
        }

        private void Dgv_funcionarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.SelectedRows.Count > 0)
            {
                string id = dgv.SelectedRows[0].Cells[0].Value.ToString();

                string sql = String.Format(@"
                            SELECT 
                                    *
                            FROM
                                    tb_funcionario
                            WHERE
                                    N_IDFUNCIONARIO = {0}
                ",id);

                DataTable dt = new DataTable();

                dt = Banco.dql(sql);

                Txt_id.Text = dt.Rows[0].Field<Int64>("N_IDFUNCIONARIO").ToString();
                Txt_nome.Text = dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO");
                Txt_pai.Text = dt.Rows[0].Field<string>("T_PAI");
                Txt_mae.Text = dt.Rows[0].Field<string>("T_MAE");
                Txt_bi.Text = dt.Rows[0].Field<string>("T_BI");
                Txt_naturalidade.Text = dt.Rows[0].Field<string>("T_NATURALIDADE");
                Txt_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                Txt_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
                Txt_Facebook.Text = dt.Rows[0].Field<string>("T_FACEBOOK");
                Txt_bairro.Text = dt.Rows[0].Field<string>("T_BAIRRO");
                Txt_municipio.Text = dt.Rows[0].Field<string>("T_MUNICIPIO");
                if (dt.Rows[0].Field<string>("T_FOTO") == "")
                {
                    Pb_foto.Image = Properties.Resources.Usuario;
                }
                else
                {
                    Pb_foto.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                    imagemAntiga = dt.Rows[0].Field<string>("T_FOTO");
                }
            }
        }

        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_novo_Click(object sender, EventArgs e)
        {
            Frm_Funcionarios frm_Funcionarios = new Frm_Funcionarios();
            frm_Funcionarios.Show();
            this.Close();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar registo?","Continuar?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                String sql = String.Format(@"
                            DELETE FROM
                                        tb_funcionario
                            WHERE
                                        N_IDFUNCIONARIO ={0}
                ",Txt_id.Text);
                Banco.dml(sql);
                MessageBox.Show("Registo apagado!");
                Dgv_funcionarios.Rows.Remove(Dgv_funcionarios.CurrentRow);
            }
        }

        private void Btn_salvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imagem antiga: "+imagemAntiga+ "|||| Imagem final: "+destinoCompleto);
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto,destinoCompleto,true);
                if (imagemAntiga != destinoCompleto)
                {
                    System.IO.File.Delete(imagemAntiga);
                }
               
                if (File.Exists(destinoCompleto))
                {
                    Pb_foto.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("ERRO ao localizar a imagem, deseja continuar?","ERRO",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }

            string sql = String.Format(@"
                                            UPDATE
                                                    tb_funcionario
                                            SET
                                                    T_NOMEFUNCIONARIO = '{0}',
                                                    T_PAI = '{1}',
                                                    T_MAE = '{2}',
                                                    T_BI = '{3}',
                                                    T_NATURALIDADE = '{4}',
                                                    T_TELEFONE = '{5}',
                                                    T_EMAIL = '{6}',
                                                    T_FACEBOOK = '{7}',
                                                    T_BAIRRO = '{8}',
                                                    T_MUNICIPIO = '{9}',
                                                    T_FOTO = '{10}'
                                             WHERE
                                                    N_IDFUNCIONARIO = {11}
                    
            ",Txt_nome.Text,Txt_pai.Text,Txt_mae.Text,Txt_bi.Text,Txt_naturalidade.Text,Txt_telefone.Text,Txt_email.Text,Txt_Facebook.Text,Txt_bairro.Text,Txt_municipio.Text,destinoCompleto,Txt_id.Text);
            Banco.dml(sql);
            MessageBox.Show("Dados do funcionário actualizado!");
            string query = String.Format(@"
                        SELECT 
                                N_IDFUNCIONARIO as 'Id',
                                T_NOMEFUNCIONARIO as 'Nome',
                                T_PAI as 'Pai',
                                T_MAE as 'Mãe',
                                T_BI as 'Nº do BI',
                                T_NATURALIDADE as 'Naturalidade',
                                T_TELEFONE as 'Telefone',
                                T_EMAIL as 'Email',
                                T_FACEBOOK as 'Facebook',
                                T_BAIRRO as 'Bairro',
                                T_MUNICIPIO as 'Municipio'
                        FROM
                                tb_funcionario
            ");
            Dgv_funcionarios.DataSource = Banco.dql(query);
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
                if (MessageBox.Show("Arquivo já existe, deseja sobrepor ?","Substituir ?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
              
            }
            Pb_foto.ImageLocation = origemCompleto;
        }

        private void Btn_Imprimir_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string query = String.Format(@"
                                                SELECT 
                                                       *
                                                FROM
                                                        tb_funcionario
                                                WHERE
                                                        N_IDFUNCIONARIO = {0}
                ",Txt_id.Text);
                DataTable dtFuncionarios = Banco.dql(query);
                string nomeArquivo = saveFileDialog1.FileName.ToString();

                FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);

                Document doc = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

                doc.Open();
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminhoFotos + "Fercesar3.jpg");
                logo.ScaleToFit(135f, 103f);
                logo.Alignment = Element.ALIGN_CENTER;
                doc.Add(logo);
                string dados = "";
                Paragraph paragrafo = new Paragraph(dados,new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 16, (int)System.Drawing.FontStyle.Bold));

                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add("Dados do Funcionário\n");
                paragrafo.Add("___________________________________________________________");

                doc.Add(paragrafo);
                doc.Close();

            }
        }
    }
}
