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

namespace Sistema_de_Vendas
{
    public partial class Frm_GerirFuncionarios : Form
    {
        string origemCompleta = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFotos;
        string destinoCompleto = "";

        string imagemApagar = "";

        string query = "";
        string idSelecionado = "";
        public Frm_GerirFuncionarios()
        {
            InitializeComponent();
        }

        private void Frm_GerirFuncionarios_Load(object sender, EventArgs e)
        {
            query = String.Format(@"
                        SELECT 
                                N_IDFUNCIONARIO as 'Id',
                                T_NOMEFUNCIONARIO as 'Nome',
                                T_TELEFONE as 'Telefone', 
                                T_EMAIL as 'Email', 
                                T_BAIRRO as 'Bairro', 
                                T_MUNICIPIO as 'Municipio' 
                        FROM
                                tb_funcionarios
            ");
            dgv_funcionarios.DataSource = Banco.dql(query);
            dgv_funcionarios.Columns[0].Width = 20;
            dgv_funcionarios.Columns[1].Width = 200;
            dgv_funcionarios.Columns[2].Width = 120;
            dgv_funcionarios.Columns[3].Width = 200;
            dgv_funcionarios.Columns[4].Width = 170;
            dgv_funcionarios.Columns[5].Width = 200;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Frm_CadFuncionarios frm_CadFuncionarios = new Frm_CadFuncionarios();
            frm_CadFuncionarios.ShowDialog();
        }

        private void dgv_funcionarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView) sender;
            int linhas = dgv.SelectedRows.Count;
            if (linhas > 0)
            {
                idSelecionado = dgv.SelectedRows[0].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                string funcionarios = String.Format(@"
                                SELECT 
                                        *
                                FROM
                                        tb_funcionarios
                                WHERE
                                        N_IDFUNCIONARIO = {0}
                ",idSelecionado);
                dt = Banco.dql(funcionarios);
                txt_id.Text = dt.Rows[0].Field<Int64>("N_IDFUNCIONARIO").ToString();
                txt_nome.Text = dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO");
                txt_pai.Text = dt.Rows[0].Field<string>("T_PAI");
                txt_mae.Text = dt.Rows[0].Field<string>("T_MAE");
                txt_bi.Text = dt.Rows[0].Field<string>("T_BI");
                txt_naturalidade.Text = dt.Rows[0].Field<string>("T_NATURAL");
                txt_telefone.Text = dt.Rows[0].Field<string>("T_TELEFONE");
                txt_email.Text = dt.Rows[0].Field<string>("T_EMAIL");
                txt_bairro.Text = dt.Rows[0].Field<string>("T_BAIRRO");
                txt_municipio.Text = dt.Rows[0].Field<string>("T_MUNICIPIO");
                pb_funcionario.ImageLocation = dt.Rows[0].Field<string>("T_FOTO");
                imagemApagar = dt.Rows[0].Field<string>("T_FOTO");

            }
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
                if (MessageBox.Show("Arquivo já existe, deseja sobrepor?","Sobrepor?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            pb_funcionario.ImageLocation = origemCompleta;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            query = String.Format(@"
                        SELECT 
                                *
                        FROM
                                tb_funcionarios
                        WHERE
                                N_IDFUNCIONARIO = {0}
            ",txt_id.Text);
            DataTable dt = Banco.dql(query);

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
                string nomeArquivoECaminho = saveFileDialog1.FileName;

                FileStream arquivoPDF = new FileStream(nomeArquivoECaminho, FileMode.Create);

                Document dadosUsuario = new Document(PageSize.A4);
                PdfWriter escritorPDF = PdfWriter.GetInstance(dadosUsuario, arquivoPDF);

                Paragraph paragrafo1 = new Paragraph();
                paragrafo1.Add("Dados do Funcionário");
                paragrafo1.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold);
                paragrafo1.Alignment = Element.ALIGN_CENTER;

                Paragraph paragrafo2 = new Paragraph();
                paragrafo2.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,12,(int)System.Drawing.FontStyle.Regular);
                paragrafo2.Alignment = Element.ALIGN_JUSTIFIED;
                paragrafo2.Add("Nome : "+dt.Rows[0].Field<string>("T_NOMEFUNCIONARIO"));

                iTextSharp.text.Image Foto = iTextSharp.text.Image.GetInstance(dt.Rows[0].Field<string>("T_FOTO"));
                Foto.Alignment = Element.ALIGN_RIGHT;
                Foto.ScaleToFit(100f, 100f);

                dadosUsuario.Open();
                
                dadosUsuario.Add(paragrafo1);
                dadosUsuario.Add(Foto);
                dadosUsuario.Add(paragrafo2);

                dadosUsuario.Close();

                if (MessageBox.Show("Deseja Abrir o relatório?","Relatório",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(nomeArquivoECaminho);
                }


            }
             
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (pb_funcionario.Image == Properties.Resources.Usuario)
            {
                if (MessageBox.Show("Sem imagem selecionada, deseja continuar?","Continuar ?",MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                if (File.Exists(imagemApagar))
                {
                    File.Delete(imagemApagar);
                }
                System.IO.File.Copy(origemCompleta,destinoCompleto,true);
                
                if (File.Exists(destinoCompleto))
                {
                    pb_funcionario.ImageLocation = destinoCompleto;
                }
                else
                {
                    if (MessageBox.Show("Erro ao localizar a foto","ERRO!",MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            
            query = String.Format(@"
                    UPDATE 
                        tb_funcionarios
                    SET 
                                T_NOMEFUNCIONARIO = '{0}',
                                T_PAI = '{1}',
                                T_MAE = '{2}',
                                T_BI = '{3}',
                                T_NATURAL = '{4}',
                                T_TELEFONE = '{5}', 
                                T_EMAIL = '{6}' , 
                                T_BAIRRO = '{7}', 
                                T_MUNICIPIO = '{8}',
                                T_FOTO = '{9}'
                    WHERE
                                N_IDFUNCIONARIO = '{10}'
            ",txt_nome.Text,txt_pai.Text,txt_mae.Text,txt_bi.Text,txt_naturalidade.Text,txt_telefone.Text,txt_email.Text,txt_bairro.Text,txt_municipio.Text,destinoCompleto,txt_id.Text);
            Banco.dml(query);
            MessageBox.Show("Dados Actualizados!");
            query = String.Format(@"
                        SELECT 
                                N_IDFUNCIONARIO as 'Id',
                                T_NOMEFUNCIONARIO as 'Nome',
                                T_TELEFONE as 'Telefone', 
                                T_EMAIL as 'Email', 
                                T_BAIRRO as 'Bairro', 
                                T_MUNICIPIO as 'Municipio' 
                        FROM
                                tb_funcionarios
            ");
            dgv_funcionarios.DataSource = Banco.dql(query);
        }

        private void btn_gerir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar registo ? ","Confirmar Exclusão",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                query = String.Format(@"
                        DELETE FROM
                               tb_funcionarios
                        WHERE
                               N_IDFUNCIONARIO= {0}
                 ",txt_id.Text);
                Banco.dml(query);
                dgv_funcionarios.Rows.Remove(dgv_funcionarios.CurrentRow);
                MessageBox.Show("Registo apagado!");
            }
            
        }
    }
}
