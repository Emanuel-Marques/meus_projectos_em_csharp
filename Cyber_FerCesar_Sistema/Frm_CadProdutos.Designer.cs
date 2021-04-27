
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_CadProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nomeProd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nud_qtde = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_precoCompra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_precoVenda = new System.Windows.Forms.TextBox();
            this.Cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_gerir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_qtde)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto";
            // 
            // Txt_nomeProd
            // 
            this.Txt_nomeProd.Enabled = false;
            this.Txt_nomeProd.Location = new System.Drawing.Point(31, 62);
            this.Txt_nomeProd.Name = "Txt_nomeProd";
            this.Txt_nomeProd.Size = new System.Drawing.Size(293, 20);
            this.Txt_nomeProd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade";
            // 
            // Nud_qtde
            // 
            this.Nud_qtde.Enabled = false;
            this.Nud_qtde.Location = new System.Drawing.Point(330, 61);
            this.Nud_qtde.Name = "Nud_qtde";
            this.Nud_qtde.Size = new System.Drawing.Size(150, 20);
            this.Nud_qtde.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Preço de Compra";
            // 
            // Txt_precoCompra
            // 
            this.Txt_precoCompra.Enabled = false;
            this.Txt_precoCompra.Location = new System.Drawing.Point(31, 106);
            this.Txt_precoCompra.Name = "Txt_precoCompra";
            this.Txt_precoCompra.Size = new System.Drawing.Size(138, 20);
            this.Txt_precoCompra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(182, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço de Venda";
            // 
            // Txt_precoVenda
            // 
            this.Txt_precoVenda.Enabled = false;
            this.Txt_precoVenda.Location = new System.Drawing.Point(185, 106);
            this.Txt_precoVenda.Name = "Txt_precoVenda";
            this.Txt_precoVenda.Size = new System.Drawing.Size(139, 20);
            this.Txt_precoVenda.TabIndex = 7;
            // 
            // Cb_fornecedor
            // 
            this.Cb_fornecedor.Enabled = false;
            this.Cb_fornecedor.FormattingEnabled = true;
            this.Cb_fornecedor.Location = new System.Drawing.Point(330, 105);
            this.Cb_fornecedor.Name = "Cb_fornecedor";
            this.Cb_fornecedor.Size = new System.Drawing.Size(150, 21);
            this.Cb_fornecedor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(330, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Forncedor";
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(12, 147);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(121, 23);
            this.Btn_novo.TabIndex = 10;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Enabled = false;
            this.Btn_salvar.Location = new System.Drawing.Point(139, 147);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(117, 23);
            this.Btn_salvar.TabIndex = 11;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_gerir
            // 
            this.Btn_gerir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_gerir.Location = new System.Drawing.Point(262, 147);
            this.Btn_gerir.Name = "Btn_gerir";
            this.Btn_gerir.Size = new System.Drawing.Size(125, 23);
            this.Btn_gerir.TabIndex = 12;
            this.Btn_gerir.Text = "Gestão de Produtos";
            this.Btn_gerir.UseVisualStyleBackColor = true;
            this.Btn_gerir.Click += new System.EventHandler(this.Btn_gerir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(393, 147);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(124, 23);
            this.Btn_fechar.TabIndex = 13;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_CadProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 182);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_gerir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cb_fornecedor);
            this.Controls.Add(this.Txt_precoVenda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_precoCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nud_qtde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_nomeProd);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_CadProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos - Cyber Fercésar";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_qtde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nomeProd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Nud_qtde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_precoCompra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_precoVenda;
        private System.Windows.Forms.ComboBox Cb_fornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_gerir;
        private System.Windows.Forms.Button Btn_fechar;
    }
}