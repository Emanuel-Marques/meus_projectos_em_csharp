
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_CadUsuario
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
            this.Cb_nome = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_senha2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.Btn_GerirUsuarios = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Cb_status = new System.Windows.Forms.ComboBox();
            this.Nud_nivel = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_nivel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Funcionário";
            // 
            // Cb_nome
            // 
            this.Cb_nome.Enabled = false;
            this.Cb_nome.FormattingEnabled = true;
            this.Cb_nome.Location = new System.Drawing.Point(15, 25);
            this.Cb_nome.Name = "Cb_nome";
            this.Cb_nome.Size = new System.Drawing.Size(221, 21);
            this.Cb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username";
            // 
            // Txt_username
            // 
            this.Txt_username.Enabled = false;
            this.Txt_username.Location = new System.Drawing.Point(257, 26);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(248, 20);
            this.Txt_username.TabIndex = 3;
            // 
            // Txt_senha
            // 
            this.Txt_senha.Enabled = false;
            this.Txt_senha.Location = new System.Drawing.Point(15, 71);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.Size = new System.Drawing.Size(221, 20);
            this.Txt_senha.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repita a senha";
            // 
            // Txt_senha2
            // 
            this.Txt_senha2.Enabled = false;
            this.Txt_senha2.Location = new System.Drawing.Point(257, 71);
            this.Txt_senha2.Name = "Txt_senha2";
            this.Txt_senha2.Size = new System.Drawing.Size(248, 20);
            this.Txt_senha2.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nível de Acesso";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_fechar);
            this.panel1.Controls.Add(this.Btn_GerirUsuarios);
            this.panel1.Controls.Add(this.Btn_salvar);
            this.panel1.Controls.Add(this.Btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 31);
            this.panel1.TabIndex = 10;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(368, 5);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(137, 23);
            this.Btn_fechar.TabIndex = 3;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Btn_GerirUsuarios
            // 
            this.Btn_GerirUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_GerirUsuarios.Location = new System.Drawing.Point(235, 4);
            this.Btn_GerirUsuarios.Name = "Btn_GerirUsuarios";
            this.Btn_GerirUsuarios.Size = new System.Drawing.Size(127, 23);
            this.Btn_GerirUsuarios.TabIndex = 2;
            this.Btn_GerirUsuarios.Text = "Gerir Usuários";
            this.Btn_GerirUsuarios.UseVisualStyleBackColor = true;
            this.Btn_GerirUsuarios.Click += new System.EventHandler(this.Btn_GerirUsuarios_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Enabled = false;
            this.Btn_salvar.Location = new System.Drawing.Point(116, 5);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(113, 23);
            this.Btn_salvar.TabIndex = 1;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(4, 4);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(106, 23);
            this.Btn_novo.TabIndex = 0;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Status";
            // 
            // Cb_status
            // 
            this.Cb_status.Enabled = false;
            this.Cb_status.FormattingEnabled = true;
            this.Cb_status.Location = new System.Drawing.Point(257, 114);
            this.Cb_status.Name = "Cb_status";
            this.Cb_status.Size = new System.Drawing.Size(248, 21);
            this.Cb_status.TabIndex = 12;
            // 
            // Nud_nivel
            // 
            this.Nud_nivel.Enabled = false;
            this.Nud_nivel.Location = new System.Drawing.Point(15, 115);
            this.Nud_nivel.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nud_nivel.Name = "Nud_nivel";
            this.Nud_nivel.Size = new System.Drawing.Size(221, 20);
            this.Nud_nivel.TabIndex = 13;
            this.Nud_nivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Frm_CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 196);
            this.Controls.Add(this.Nud_nivel);
            this.Controls.Add(this.Cb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_senha2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_CadUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadstro de Usuário - Cyber Fercésar";
            this.Load += new System.EventHandler(this.Frm_CadUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nud_nivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cb_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_senha2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.Button Btn_GerirUsuarios;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Cb_status;
        private System.Windows.Forms.NumericUpDown Nud_nivel;
    }
}