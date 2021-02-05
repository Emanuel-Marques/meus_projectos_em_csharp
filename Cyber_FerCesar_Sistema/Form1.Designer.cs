
namespace Cyber_FerCesar_Sistema
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_senha = new System.Windows.Forms.TextBox();
            this.Btn_entar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome de usuário";
            // 
            // Txt_username
            // 
            this.Txt_username.Location = new System.Drawing.Point(66, 107);
            this.Txt_username.Name = "Txt_username";
            this.Txt_username.Size = new System.Drawing.Size(182, 20);
            this.Txt_username.TabIndex = 1;
            this.Txt_username.Text = "EJM2001";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // Txt_senha
            // 
            this.Txt_senha.Location = new System.Drawing.Point(66, 172);
            this.Txt_senha.Name = "Txt_senha";
            this.Txt_senha.PasswordChar = '*';
            this.Txt_senha.Size = new System.Drawing.Size(182, 20);
            this.Txt_senha.TabIndex = 3;
            this.Txt_senha.Text = "123";
            // 
            // Btn_entar
            // 
            this.Btn_entar.Location = new System.Drawing.Point(99, 211);
            this.Btn_entar.Name = "Btn_entar";
            this.Btn_entar.Size = new System.Drawing.Size(114, 38);
            this.Btn_entar.TabIndex = 4;
            this.Btn_entar.Text = "Entrar";
            this.Btn_entar.UseVisualStyleBackColor = true;
            this.Btn_entar.Click += new System.EventHandler(this.Btn_entar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 294);
            this.Controls.Add(this.Btn_entar);
            this.Controls.Add(this.Txt_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_username);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_senha;
        private System.Windows.Forms.Button Btn_entar;
    }
}

