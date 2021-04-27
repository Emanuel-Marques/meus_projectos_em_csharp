
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_GestaoProd
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nud_qtde = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_precoCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_precoVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_fornecedor = new System.Windows.Forms.ComboBox();
            this.Dgv_produtos = new System.Windows.Forms.DataGridView();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_qtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_produtos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.Color.Red;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.Txt_id.Enabled = false;
            this.Txt_id.Location = new System.Drawing.Point(13, 30);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(31, 20);
            this.Txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do Produto";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(50, 30);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(217, 20);
            this.Txt_nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade";
            // 
            // Nud_qtde
            // 
            this.Nud_qtde.Location = new System.Drawing.Point(273, 30);
            this.Nud_qtde.Name = "Nud_qtde";
            this.Nud_qtde.Size = new System.Drawing.Size(75, 20);
            this.Nud_qtde.TabIndex = 5;
            this.Nud_qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço de Compra";
            // 
            // Txt_precoCompra
            // 
            this.Txt_precoCompra.Location = new System.Drawing.Point(354, 30);
            this.Txt_precoCompra.Name = "Txt_precoCompra";
            this.Txt_precoCompra.Size = new System.Drawing.Size(103, 20);
            this.Txt_precoCompra.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço de Venda";
            // 
            // Txt_precoVenda
            // 
            this.Txt_precoVenda.Location = new System.Drawing.Point(463, 30);
            this.Txt_precoVenda.Name = "Txt_precoVenda";
            this.Txt_precoVenda.Size = new System.Drawing.Size(115, 20);
            this.Txt_precoVenda.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(581, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fornecedor";
            // 
            // Cb_fornecedor
            // 
            this.Cb_fornecedor.FormattingEnabled = true;
            this.Cb_fornecedor.Location = new System.Drawing.Point(584, 29);
            this.Cb_fornecedor.Name = "Cb_fornecedor";
            this.Cb_fornecedor.Size = new System.Drawing.Size(140, 21);
            this.Cb_fornecedor.TabIndex = 11;
            // 
            // Dgv_produtos
            // 
            this.Dgv_produtos.AllowUserToAddRows = false;
            this.Dgv_produtos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_produtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_produtos.Location = new System.Drawing.Point(13, 98);
            this.Dgv_produtos.MultiSelect = false;
            this.Dgv_produtos.Name = "Dgv_produtos";
            this.Dgv_produtos.ReadOnly = true;
            this.Dgv_produtos.RowHeadersVisible = false;
            this.Dgv_produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_produtos.Size = new System.Drawing.Size(711, 340);
            this.Dgv_produtos.TabIndex = 12;
            this.Dgv_produtos.SelectionChanged += new System.EventHandler(this.Dgv_produtos_SelectionChanged);
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(13, 66);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(157, 23);
            this.Btn_novo.TabIndex = 13;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(219, 66);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(162, 23);
            this.Btn_salvar.TabIndex = 14;
            this.Btn_salvar.Text = "Salvar Alterações";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluir.Location = new System.Drawing.Point(417, 66);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(149, 23);
            this.Btn_excluir.TabIndex = 15;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(584, 66);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Fechar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_GestaoProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.Dgv_produtos);
            this.Controls.Add(this.Cb_fornecedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_precoVenda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_precoCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Nud_qtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_GestaoProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Produtos  - Fercésar";
            this.Load += new System.EventHandler(this.Frm_GestaoProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_qtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_produtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Nud_qtde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_precoCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_precoVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_fornecedor;
        private System.Windows.Forms.DataGridView Dgv_produtos;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button button4;
    }
}