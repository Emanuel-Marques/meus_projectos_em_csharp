
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_CadCliente
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
            this.Txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Mtxt_contacto = new System.Windows.Forms.MaskedTextBox();
            this.Btn_gerir = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Enabled = false;
            this.Txt_nome.Location = new System.Drawing.Point(12, 30);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(282, 20);
            this.Txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contacto";
            // 
            // Btn_novo
            // 
            this.Btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_novo.Location = new System.Drawing.Point(72, 111);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(158, 23);
            this.Btn_novo.TabIndex = 4;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_salvar.Enabled = false;
            this.Btn_salvar.Location = new System.Drawing.Point(72, 140);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(158, 23);
            this.Btn_salvar.TabIndex = 5;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Mtxt_contacto
            // 
            this.Mtxt_contacto.Enabled = false;
            this.Mtxt_contacto.Location = new System.Drawing.Point(12, 74);
            this.Mtxt_contacto.Mask = "(+244)000-000-000";
            this.Mtxt_contacto.Name = "Mtxt_contacto";
            this.Mtxt_contacto.Size = new System.Drawing.Size(282, 20);
            this.Mtxt_contacto.TabIndex = 6;
            // 
            // Btn_gerir
            // 
            this.Btn_gerir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_gerir.Location = new System.Drawing.Point(72, 170);
            this.Btn_gerir.Name = "Btn_gerir";
            this.Btn_gerir.Size = new System.Drawing.Size(158, 23);
            this.Btn_gerir.TabIndex = 7;
            this.Btn_gerir.Text = "Gerir Clientes";
            this.Btn_gerir.UseVisualStyleBackColor = true;
            this.Btn_gerir.Click += new System.EventHandler(this.Btn_gerir_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_fechar.Location = new System.Drawing.Point(72, 199);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(158, 23);
            this.Btn_fechar.TabIndex = 8;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 229);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_gerir);
            this.Controls.Add(this.Mtxt_contacto);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente - Fercésar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.MaskedTextBox Mtxt_contacto;
        private System.Windows.Forms.Button Btn_gerir;
        private System.Windows.Forms.Button Btn_fechar;
    }
}