
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_CadFornecedor
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
            this.Txt_telefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_nif = new System.Windows.Forms.TextBox();
            this.Btn_novo = new System.Windows.Forms.Button();
            this.Btn_salvar = new System.Windows.Forms.Button();
            this.Btn_gestao = new System.Windows.Forms.Button();
            this.Btn_fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // Txt_nome
            // 
            this.Txt_nome.Enabled = false;
            this.Txt_nome.Location = new System.Drawing.Point(53, 28);
            this.Txt_nome.Name = "Txt_nome";
            this.Txt_nome.Size = new System.Drawing.Size(219, 20);
            this.Txt_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefone";
            // 
            // Txt_telefone
            // 
            this.Txt_telefone.Enabled = false;
            this.Txt_telefone.Location = new System.Drawing.Point(53, 71);
            this.Txt_telefone.Name = "Txt_telefone";
            this.Txt_telefone.Size = new System.Drawing.Size(219, 20);
            this.Txt_telefone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NIF";
            // 
            // Txt_nif
            // 
            this.Txt_nif.Enabled = false;
            this.Txt_nif.Location = new System.Drawing.Point(53, 119);
            this.Txt_nif.Name = "Txt_nif";
            this.Txt_nif.Size = new System.Drawing.Size(219, 20);
            this.Txt_nif.TabIndex = 5;
            // 
            // Btn_novo
            // 
            this.Btn_novo.Location = new System.Drawing.Point(95, 145);
            this.Btn_novo.Name = "Btn_novo";
            this.Btn_novo.Size = new System.Drawing.Size(130, 23);
            this.Btn_novo.TabIndex = 6;
            this.Btn_novo.Text = "Novo";
            this.Btn_novo.UseVisualStyleBackColor = true;
            this.Btn_novo.Click += new System.EventHandler(this.Btn_novo_Click);
            // 
            // Btn_salvar
            // 
            this.Btn_salvar.Enabled = false;
            this.Btn_salvar.Location = new System.Drawing.Point(95, 175);
            this.Btn_salvar.Name = "Btn_salvar";
            this.Btn_salvar.Size = new System.Drawing.Size(130, 23);
            this.Btn_salvar.TabIndex = 7;
            this.Btn_salvar.Text = "Salvar";
            this.Btn_salvar.UseVisualStyleBackColor = true;
            this.Btn_salvar.Click += new System.EventHandler(this.Btn_salvar_Click);
            // 
            // Btn_gestao
            // 
            this.Btn_gestao.Location = new System.Drawing.Point(95, 204);
            this.Btn_gestao.Name = "Btn_gestao";
            this.Btn_gestao.Size = new System.Drawing.Size(130, 23);
            this.Btn_gestao.TabIndex = 8;
            this.Btn_gestao.Text = "Gerir Fornecedor";
            this.Btn_gestao.UseVisualStyleBackColor = true;
            this.Btn_gestao.Click += new System.EventHandler(this.Btn_gestao_Click);
            // 
            // Btn_fechar
            // 
            this.Btn_fechar.Location = new System.Drawing.Point(95, 233);
            this.Btn_fechar.Name = "Btn_fechar";
            this.Btn_fechar.Size = new System.Drawing.Size(130, 23);
            this.Btn_fechar.TabIndex = 9;
            this.Btn_fechar.Text = "Fechar";
            this.Btn_fechar.UseVisualStyleBackColor = true;
            this.Btn_fechar.Click += new System.EventHandler(this.Btn_fechar_Click);
            // 
            // Frm_CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 264);
            this.Controls.Add(this.Btn_fechar);
            this.Controls.Add(this.Btn_gestao);
            this.Controls.Add(this.Btn_salvar);
            this.Controls.Add(this.Btn_novo);
            this.Controls.Add(this.Txt_nif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_telefone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Frm_CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor - Fercésar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_nif;
        private System.Windows.Forms.Button Btn_novo;
        private System.Windows.Forms.Button Btn_salvar;
        private System.Windows.Forms.Button Btn_gestao;
        private System.Windows.Forms.Button Btn_fechar;
    }
}