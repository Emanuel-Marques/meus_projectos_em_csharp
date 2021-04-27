
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_GestaoUsuarios
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
            this.Dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nud_nivel = new System.Windows.Forms.NumericUpDown();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_excluir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_funcionarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_usuarios
            // 
            this.Dgv_usuarios.AllowUserToAddRows = false;
            this.Dgv_usuarios.AllowUserToDeleteRows = false;
            this.Dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_usuarios.Location = new System.Drawing.Point(12, 111);
            this.Dgv_usuarios.MultiSelect = false;
            this.Dgv_usuarios.Name = "Dgv_usuarios";
            this.Dgv_usuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_usuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_usuarios.RowHeadersVisible = false;
            this.Dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_usuarios.Size = new System.Drawing.Size(773, 302);
            this.Dgv_usuarios.TabIndex = 0;
            this.Dgv_usuarios.SelectionChanged += new System.EventHandler(this.Dgv_usuarios_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.No;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // Txt_id
            // 
            this.Txt_id.BackColor = System.Drawing.Color.Red;
            this.Txt_id.Cursor = System.Windows.Forms.Cursors.No;
            this.Txt_id.Location = new System.Drawing.Point(12, 26);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(35, 20);
            this.Txt_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // Txt_username
            // 
            this.Txt_username.Location = new System.Drawing.Point(53, 25);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(149, 20);
            this.Txt_username.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(208, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(208, 26);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.Size = new System.Drawing.Size(123, 20);
            this.Txt_senha.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nível";
            // 
            // Nud_nivel
            // 
            this.Nud_nivel.Location = new System.Drawing.Point(337, 25);
            this.Nud_nivel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_nivel.Name = "Nud_nivel";
            this.Nud_nivel.Size = new System.Drawing.Size(128, 20);
            this.Nud_nivel.TabIndex = 8;
            // 
            // Cb_status
            // 
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Location = new System.Drawing.Point(470, 24);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(124, 21);
            this.Cb_status.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Status";
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(12, 69);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(108, 36);
            this.Btn_novo.TabIndex = 11;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Location = new System.Drawing.Point(237, 69);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(101, 36);
            this.Btn_salvar.TabIndex = 12;
            this.Btn_salvar.Text = "Salvar Alterações";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_excluir
            // 
            this.Btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_excluir.Location = new System.Drawing.Point(483, 69);
            this.Btn_excluir.Name = "Btn_excluir";
            this.Btn_excluir.Size = new System.Drawing.Size(111, 36);
            this.Btn_excluir.TabIndex = 13;
            this.Btn_excluir.Text = "Excluir";
            this.Btn_excluir.UseVisualStyleBackColor = true;
            this.Btn_excluir.Click += new System.EventHandler(this.Btn_excluir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(694, 69);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(77, 36);
            this.Btn_fechar.TabIndex = 14;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(608, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nome do Funcionário";
            // 
            // Cb_funcionarios
            // 
            this.Cb_funcionarios.FormattingEnabled = true;
            this.Cb_funcionarios.Location = new System.Drawing.Point(611, 26);
            this.Cb_funcionarios.Name = "Cb_funcionarios";
            this.Cb_funcionarios.Size = new System.Drawing.Size(174, 21);
            this.Cb_funcionarios.TabIndex = 16;
            // 
            // Frm_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 425);
            this.Controls.Add(this.Cb_funcionarios);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_excluir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.Nud_nivel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuários - Fercésar";
            this.Load += new System.EventHandler(this.Frm_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Nud_nivel;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_excluir;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_funcionarios;
    }
}