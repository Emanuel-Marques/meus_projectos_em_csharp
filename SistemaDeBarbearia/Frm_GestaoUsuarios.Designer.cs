namespace SistemaDeBarbearia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_usuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomeUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_usernameUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_senha2 = new System.Windows.Forms.TextBox();
            this.nud_nivel = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_usuarios
            // 
            this.dgv_usuarios.AllowUserToAddRows = false;
            this.dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_usuarios.Location = new System.Drawing.Point(244, 12);
            this.dgv_usuarios.MultiSelect = false;
            this.dgv_usuarios.Name = "dgv_usuarios";
            this.dgv_usuarios.ReadOnly = true;
            this.dgv_usuarios.RowHeadersVisible = false;
            this.dgv_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_usuarios.Size = new System.Drawing.Size(345, 258);
            this.dgv_usuarios.TabIndex = 0;
            this.dgv_usuarios.SelectionChanged += new System.EventHandler(this.dgv_usuarios_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 40);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // txt_idUser
            // 
            this.txt_idUser.Enabled = false;
            this.txt_idUser.Location = new System.Drawing.Point(8, 30);
            this.txt_idUser.Name = "txt_idUser";
            this.txt_idUser.Size = new System.Drawing.Size(62, 20);
            this.txt_idUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // txt_nomeUser
            // 
            this.txt_nomeUser.Location = new System.Drawing.Point(8, 74);
            this.txt_nomeUser.Name = "txt_nomeUser";
            this.txt_nomeUser.Size = new System.Drawing.Size(218, 20);
            this.txt_nomeUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome de Usuário";
            // 
            // txt_usernameUser
            // 
            this.txt_usernameUser.Location = new System.Drawing.Point(8, 118);
            this.txt_usernameUser.Name = "txt_usernameUser";
            this.txt_usernameUser.Size = new System.Drawing.Size(218, 20);
            this.txt_usernameUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha :";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(8, 162);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(100, 20);
            this.txt_senha.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Repita a senha :";
            // 
            // txt_senha2
            // 
            this.txt_senha2.Location = new System.Drawing.Point(118, 161);
            this.txt_senha2.Name = "txt_senha2";
            this.txt_senha2.Size = new System.Drawing.Size(108, 20);
            this.txt_senha2.TabIndex = 11;
            // 
            // nud_nivel
            // 
            this.nud_nivel.Location = new System.Drawing.Point(8, 205);
            this.nud_nivel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_nivel.Name = "nud_nivel";
            this.nud_nivel.Size = new System.Drawing.Size(100, 20);
            this.nud_nivel.TabIndex = 12;
            this.nud_nivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Nível de Acesso :";
            // 
            // btn_novo
            // 
            this.btn_novo.Location = new System.Drawing.Point(8, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(120, 23);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(134, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(143, 23);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Location = new System.Drawing.Point(283, 5);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(154, 23);
            this.btn_excluir.TabIndex = 2;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(443, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(146, 23);
            this.btn_fechar.TabIndex = 3;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // Frm_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nud_nivel);
            this.Controls.Add(this.txt_senha2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_usernameUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nomeUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_usuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuários";
            this.Load += new System.EventHandler(this.Frm_GestaoUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_usuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomeUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_usernameUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_senha2;
        private System.Windows.Forms.NumericUpDown nud_nivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_novo;
    }
}