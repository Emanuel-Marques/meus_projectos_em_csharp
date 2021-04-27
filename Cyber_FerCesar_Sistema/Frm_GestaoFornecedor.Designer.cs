
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_GestaoFornecedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_fornecedor = new System.Windows.Forms.DataGridView();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_telefone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_nif = new System.Windows.Forms.TextBox();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.Color.Red;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.Txt_id.Enabled = false;
            this.Txt_id.Location = new System.Drawing.Point(470, 29);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(45, 20);
            this.Txt_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // Dgv_fornecedor
            // 
            this.Dgv_fornecedor.AllowUserToAddRows = false;
            this.Dgv_fornecedor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_fornecedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_fornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_fornecedor.Location = new System.Drawing.Point(12, 12);
            this.Dgv_fornecedor.MultiSelect = false;
            this.Dgv_fornecedor.Name = "Dgv_fornecedor";
            this.Dgv_fornecedor.ReadOnly = true;
            this.Dgv_fornecedor.RowHeadersVisible = false;
            this.Dgv_fornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_fornecedor.Size = new System.Drawing.Size(452, 323);
            this.Dgv_fornecedor.TabIndex = 3;
            this.Dgv_fornecedor.SelectionChanged += new System.EventHandler(this.Dgv_fornecedor_SelectionChanged);
            // 
            // Txt_nome
            // 
            this.Txt_nome.Location = new System.Drawing.Point(470, 78);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(157, 20);
            this.Txt_nome.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefone";
            // 
            // Txt_telefone
            // 
            this.Txt_telefone.Location = new System.Drawing.Point(470, 122);
            this.Txt_telefone.Name = "Txt_telefone";
            this.Txt_telefone.Size = new System.Drawing.Size(157, 20);
            this.Txt_telefone.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "NIF";
            // 
            // Txt_nif
            // 
            this.Txt_nif.Location = new System.Drawing.Point(470, 166);
            this.Txt_nif.Name = "Txt_nif";
            this.Txt_nif.Size = new System.Drawing.Size(157, 20);
            this.Txt_nif.TabIndex = 8;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(470, 223);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(155, 23);
            this.Btn_novo.TabIndex = 9;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(470, 253);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(155, 23);
            this.Btn_salvar.TabIndex = 10;
            this.Btn_salvar.Text = "Salvar Alterações";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluir.Location = new System.Drawing.Point(470, 283);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(155, 23);
            this.Btn_excluir.TabIndex = 11;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(470, 312);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(155, 23);
            this.Btn_fechar.TabIndex = 12;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_GestaoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 347);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.Txt_nif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.Dgv_fornecedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_GestaoFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Fornecedores - Fercésar";
            this.Load += new System.EventHandler(this.Frm_GestaoFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_fornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_fornecedor;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_telefone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_nif;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_fechar;
    }
}