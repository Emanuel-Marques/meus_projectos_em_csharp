
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_Funcionarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.Txt_mae = new System.Windows.Forms.TextBox();
            this.Txt_pai = new System.Windows.Forms.TextBox();
            this.Txt_BI = new System.Windows.Forms.TextBox();
            this.Txt_natural = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Mtxt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_facebook = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Txt_bairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_municipio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Pb_foto = new System.Windows.Forms.PictureBox();
            this.Btn_foto = new System.Windows.Forms.Button();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_gerir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_natural);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_nome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_BI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_mae);
            this.groupBox1.Controls.Add(this.Txt_pai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome :";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Enabled = false;
            this.Txt_nome.Location = new System.Drawing.Point(6, 36);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(281, 20);
            this.Txt_nome.TabIndex = 1;
            this.Txt_nome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_mae
            // 
            this.Txt_mae.Enabled = false;
            this.Txt_mae.Location = new System.Drawing.Point(266, 75);
            this.Txt_mae.Name = "Txt_mae";
            this.Txt_mae.Size = new System.Drawing.Size(221, 20);
            this.Txt_mae.TabIndex = 1;
            this.Txt_mae.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txt_pai
            // 
            this.Txt_pai.Enabled = false;
            this.Txt_pai.Location = new System.Drawing.Point(6, 75);
            this.Txt_pai.Name = "Txt_pai";
            this.Txt_pai.Size = new System.Drawing.Size(217, 20);
            this.Txt_pai.TabIndex = 2;
            this.Txt_pai.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Txt_BI
            // 
            this.Txt_BI.Enabled = false;
            this.Txt_BI.Location = new System.Drawing.Point(6, 114);
            this.Txt_BI.Name = "Txt_BI";
            this.Txt_BI.Size = new System.Drawing.Size(281, 20);
            this.Txt_BI.TabIndex = 3;
            this.Txt_BI.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Txt_natural
            // 
            this.Txt_natural.Enabled = false;
            this.Txt_natural.Location = new System.Drawing.Point(6, 153);
            this.Txt_natural.Name = "Txt_natural";
            this.Txt_natural.Size = new System.Drawing.Size(281, 20);
            this.Txt_natural.TabIndex = 4;
            this.Txt_natural.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filho de ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "e de ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nº do BI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Naturalidade";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_facebook);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Txt_email);
            this.groupBox2.Controls.Add(this.Mtxt_telefone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(493, 111);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contactos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefone";
            // 
            // Mtxt_telefone
            // 
            this.Mtxt_telefone.Enabled = false;
            this.Mtxt_telefone.Location = new System.Drawing.Point(6, 37);
            this.Mtxt_telefone.Mask = "(+244)000-000-000";
            this.Mtxt_telefone.Name = "Mtxt_telefone";
            this.Mtxt_telefone.Size = new System.Drawing.Size(191, 20);
            this.Mtxt_telefone.TabIndex = 1;
            // 
            // Txt_email
            // 
            this.Txt_email.Enabled = false;
            this.Txt_email.Location = new System.Drawing.Point(6, 80);
            this.Txt_email.Name = "Txt_email";
            this.Txt_email.Size = new System.Drawing.Size(191, 20);
            this.Txt_email.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // Txt_facebook
            // 
            this.Txt_facebook.Enabled = false;
            this.Txt_facebook.Location = new System.Drawing.Point(232, 37);
            this.Txt_facebook.Name = "Txt_facebook";
            this.Txt_facebook.Size = new System.Drawing.Size(186, 20);
            this.Txt_facebook.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Facebook";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.Txt_bairro);
            this.groupBox3.Controls.Add(this.Txt_municipio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 328);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(493, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Localização";
            // 
            // Txt_bairro
            // 
            this.Txt_bairro.Enabled = false;
            this.Txt_bairro.Location = new System.Drawing.Point(6, 44);
            this.Txt_bairro.Name = "Txt_bairro";
            this.Txt_bairro.Size = new System.Drawing.Size(254, 20);
            this.Txt_bairro.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Bairro";
            // 
            // Txt_municipio
            // 
            this.Txt_municipio.Enabled = false;
            this.Txt_municipio.Location = new System.Drawing.Point(6, 83);
            this.Txt_municipio.Name = "Txt_municipio";
            this.Txt_municipio.Size = new System.Drawing.Size(254, 20);
            this.Txt_municipio.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Municipio";
            // 
            // Pb_foto
            // 
            this.Pb_foto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pb_foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Pb_foto.Image = global::Cyber_FerCesar_Sistema.Properties.Resources.Usuario;
            this.Pb_foto.Location = new System.Drawing.Point(570, 90);
            this.Pb_foto.Name = "Pb_foto";
            this.Pb_foto.Size = new System.Drawing.Size(240, 240);
            this.Pb_foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_foto.TabIndex = 3;
            this.Pb_foto.TabStop = false;
            // 
            // Btn_foto
            // 
            this.Btn_foto.Enabled = false;
            this.Btn_foto.Location = new System.Drawing.Point(570, 337);
            this.Btn_foto.Name = "Btn_foto";
            this.Btn_foto.Size = new System.Drawing.Size(240, 23);
            this.Btn_foto.TabIndex = 4;
            this.Btn_foto.Text = "Carregar Foto";
            this.Btn_foto.UseVisualStyleBackColor = true;
            this.Btn_foto.Click += new System.EventHandler(this.Btn_foto_Click);
            // 
            // Btn_novo
            // 
            this.Btn_novo.Location = new System.Drawing.Point(511, 397);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(75, 44);
            this.Btn_novo.TabIndex = 5;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Enabled = false;
            this.Btn_salvar.Location = new System.Drawing.Point(593, 397);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(86, 43);
            this.Btn_salvar.TabIndex = 6;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_gerir
            // 
            this.Btn_gerir.Location = new System.Drawing.Point(685, 398);
            this.Btn_gerir.Name = "Btn_gerir";
            this.Btn_gerir.Size = new System.Drawing.Size(97, 42);
            this.Btn_gerir.TabIndex = 7;
            this.Btn_gerir.Text = "Gerir Funcionários";
            this.Btn_gerir.UseVisualStyleBackColor = true;
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(788, 399);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(75, 41);
            this.Btn_fechar.TabIndex = 8;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Frm_Funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 453);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_gerir);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.Btn_foto);
            this.Controls.Add(this.Pb_foto);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Funcionarios";
            this.Text = "Cadastro de Funcionários";
            this.Load += new System.EventHandler(this.Frm_Funcionarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_natural;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_BI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_mae;
        private System.Windows.Forms.TextBox Txt_pai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Txt_facebook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_email;
        private System.Windows.Forms.MaskedTextBox Mtxt_telefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_bairro;
        private System.Windows.Forms.TextBox Txt_municipio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Pb_foto;
        private System.Windows.Forms.Button Btn_foto;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_gerir;
        private System.Windows.Forms.Button Btn_fechar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}