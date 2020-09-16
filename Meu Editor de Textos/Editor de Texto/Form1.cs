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

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null; 
        public Form1()
        {
            InitializeComponent();
        }
        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter dcta_streamWriter = new StreamWriter(arquivo);
                    dcta_streamWriter.Flush();
                    dcta_streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    dcta_streamWriter.Write(this.richTextBox1.Text);
                    dcta_streamWriter.Flush();
                    dcta_streamWriter.Close();
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Erro na gravação" + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\Users\Emanuel Marques\Documents\Loc\";
            openFileDialog1.Filter = "(*.dcta*)| *.dcta";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if(dr == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                 FileStream arquivo = new FileStream(openFileDialog1.FileName,FileMode.Open,FileAccess.Read);
                 StreamReader dcta_streamReader = new StreamReader(arquivo);
                 dcta_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                 this.richTextBox1.Text = "";
                    string linha = dcta_streamReader.ReadLine();
                    while (linha != null)
                    {
                        this.richTextBox1.Text = linha + "\n";
                        linha = dcta_streamReader.ReadLine();
                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Erro na leitura" + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if(richTextBox1.SelectionLength > 0)
            {
                richTextBox1.Copy();
            }
        }
        private void Colar()
        {
            richTextBox1.Paste();
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Negrito()
        {
            string nome_da_Fonte = null;
            float tamanho_da_fonte = 0;
            bool n, s, i = false;

            nome_da_Fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            s = richTextBox1.SelectionFont.Underline;
            i = richTextBox1.SelectionFont.Italic;

            richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Regular);

            if (n == false)
            {
                if (s == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                else if (s == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if(s == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (s == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold);
                }


            }
            else
            {
                if (s == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (s == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (s == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte,FontStyle.Italic);
                }
            }
           
        }
        private void Italico()
        {
            string nome_da_Fonte = null;
            float tamanho_da_fonte = 0;
            bool n, s, i = false;

            nome_da_Fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            s = richTextBox1.SelectionFont.Underline;
            i = richTextBox1.SelectionFont.Italic;

            richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Regular);

            if (i == false)
            {
                if (s == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline | FontStyle.Bold);
                }
                else if (s == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (s == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (s == false & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Italic);
                }


            }
            else
            {
                if (s == true & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Bold);
                }
                else if (s == true & n == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (s == false & n == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }
        private void Sublinhado()
        {
            string nome_da_Fonte = null;
            float tamanho_da_fonte = 0;
            bool n, s, i = false;

            nome_da_Fonte = richTextBox1.Font.Name;
            tamanho_da_fonte = richTextBox1.Font.Size;
            n = richTextBox1.SelectionFont.Bold;
            s = richTextBox1.SelectionFont.Underline;
            i = richTextBox1.SelectionFont.Italic;

            richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Regular);

            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Underline);
                }


            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(nome_da_Fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }

        private void Alinhar_Esquerda()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void Alinhar_Direita()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Alinhar_Centro()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void imprimir()
        {
            printDialog1.Document = printDocument1;

            string texto = this.richTextBox1.Text;

            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            Alinhar_Esquerda();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhar_Esquerda();
        }

        private void btn_centro_Click(object sender, EventArgs e)
        {
            Alinhar_Centro();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhar_Centro();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alinhar_Direita();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            Alinhar_Direita();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;

            //definindo as margens
            float MargemEsquerda = e.MarginBounds.Left - 50;
            float MargemSuperior = e.MarginBounds.Top - 50;

            if (MargemEsquerda < 5)
            {
                MargemEsquerda = 20;
            }
            if (MargemSuperior < 5)
            {
                MargemSuperior = 20;
            }

            //configurando a fonte, pincel, altura das linhas
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            //define a quantidade de linhas que cabe em uma página
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);

            //pegando as linhas que estão no richTextBox1
            linha = leitura.ReadLine();

            //neste loop eu vou determinar: 
            while (cont < linhasPagina)
            {
                //a posição de onde eu quero que seja impressa
                PosY = (MargemSuperior + (cont * fonte.GetHeight(e.Graphics)));
                //desenhando a linha que será impressa
                e.Graphics.DrawString(linha, fonte, pincel, MargemEsquerda, PosY, new StringFormat());
                //incrementando o contador
                cont += 1;
                //buscar uma nova linha
                linha = leitura.ReadLine();
            }
            // verificando se tem uma nova página
            if(linha != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            pincel.Dispose();
            }
    }

    
}
