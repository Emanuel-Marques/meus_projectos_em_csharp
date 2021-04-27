
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_GestaoClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_clientes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_nomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mtxt_contacto = new System.Windows.Forms.MaskedTextBox();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_clientes
            // 
            this.Dgv_clientes.AllowUserToAddRows = false;
            this.Dgv_clientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.Dgv_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Dgv_clientes.EnableHeadersVisualStyles = false;
            this.Dgv_clientes.Location = new System.Drawing.Point(12, 52);
            this.Dgv_clientes.MultiSelect = false;
            this.Dgv_clientes.Name = "Dgv_clientes";
            this.Dgv_clientes.ReadOnly = true;
            this.Dgv_clientes.RowHeadersVisible = false;
            this.Dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_clientes.Size = new System.Drawing.Size(394, 200);
            this.Dgv_clientes.TabIndex = 0;
            this.Dgv_clientes.SelectionChanged += new System.EventHandler(this.Dgv_clientes_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.Color.Red;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.Txt_id.Enabled = false;
            this.Txt_id.Location = new System.Drawing.Point(12, 26);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(43, 20);
            this.Txt_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // Txt_nomeCliente
            // 
            this.Txt_nomeCliente.Location = new System.Drawing.Point(61, 26);
            this.Txt_nomeCliente.Name = "Txt_nomeCliente";
            this.Txt_nomeCliente.Size = new System.Drawing.Size(239, 20);
            this.Txt_nomeCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Contacto";
            // 
            // Mtxt_contacto
            // 
            this.Mtxt_contacto.Location = new System.Drawing.Point(306, 26);
            this.Mtxt_contacto.Name = "Mtxt_contacto";
            this.Mtxt_contacto.Size = new System.Drawing.Size(100, 20);
            this.Mtxt_contacto.TabIndex = 6;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Location = new System.Drawing.Point(13, 259);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(97, 23);
            this.Btn_novo.TabIndex = 7;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Location = new System.Drawing.Point(116, 259);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(110, 23);
            this.Btn_salvar.TabIndex = 8;
            this.Btn_salvar.Text = "Gravar Alterações";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Location = new System.Drawing.Point(232, 259);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(78, 23);
            this.Btn_excluir.TabIndex = 9;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(316, 259);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(90, 23);
            this.Btn_fechar.TabIndex = 10;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_GestaoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 291);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.Mtxt_contacto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_nomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_clientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_GestaoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Clientes - Fercésar";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_clientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_nomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Mtxt_contacto;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_fechar;
    }
}