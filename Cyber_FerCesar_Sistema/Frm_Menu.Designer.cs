
namespace Cyber_FerCesar_Sistema
{
    partial class Frm_Menu
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
            this.Pnl_inferior = new System.Windows.Forms.Panel();
            this.Lbl_tipoConta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lbl_nivel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_nome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pnl_inferior.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_inferior
            // 
            this.Pnl_inferior.Controls.Add(this.Lbl_tipoConta);
            this.Pnl_inferior.Controls.Add(this.label5);
            this.Pnl_inferior.Controls.Add(this.Lbl_nivel);
            this.Pnl_inferior.Controls.Add(this.label3);
            this.Pnl_inferior.Controls.Add(this.Lbl_nome);
            this.Pnl_inferior.Controls.Add(this.label1);
            this.Pnl_inferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_inferior.Location = new System.Drawing.Point(0, 422);
            this.Pnl_inferior.Name = "Pnl_inferior";
            this.Pnl_inferior.Size = new System.Drawing.Size(800, 28);
            this.Pnl_inferior.TabIndex = 0;
            // 
            // Lbl_tipoConta
            // 
            this.Lbl_tipoConta.AutoSize = true;
            this.Lbl_tipoConta.Location = new System.Drawing.Point(518, 6);
            this.Lbl_tipoConta.Name = "Lbl_tipoConta";
            this.Lbl_tipoConta.Size = new System.Drawing.Size(55, 13);
            this.Lbl_tipoConta.TabIndex = 5;
            this.Lbl_tipoConta.Text = "----------------";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Conta: ";
            // 
            // Lbl_nivel
            // 
            this.Lbl_nivel.AutoSize = true;
            this.Lbl_nivel.Location = new System.Drawing.Point(345, 6);
            this.Lbl_nivel.Name = "Lbl_nivel";
            this.Lbl_nivel.Size = new System.Drawing.Size(37, 13);
            this.Lbl_nivel.TabIndex = 3;
            this.Lbl_nivel.Text = "----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nível de Acesso: ";
            // 
            // Lbl_nome
            // 
            this.Lbl_nome.AutoSize = true;
            this.Lbl_nome.Location = new System.Drawing.Point(99, 6);
            this.Lbl_nome.Name = "Lbl_nome";
            this.Lbl_nome.Size = new System.Drawing.Size(58, 13);
            this.Lbl_nome.TabIndex = 1;
            this.Lbl_nome.Text = "-----------------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome de usuário:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.gestãoToolStripMenuItem,
            this.vendaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.usuárioToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.funcionáriosToolStripMenuItem.Text = "Funcionário";
            this.funcionáriosToolStripMenuItem.Click += new System.EventHandler(this.funcionáriosToolStripMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            this.usuárioToolStripMenuItem.Click += new System.EventHandler(this.usuárioToolStripMenuItem_Click);
            // 
            // gestãoToolStripMenuItem
            // 
            this.gestãoToolStripMenuItem.Name = "gestãoToolStripMenuItem";
            this.gestãoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.gestãoToolStripMenuItem.Text = "Gestão";
            // 
            // vendaToolStripMenuItem
            // 
            this.vendaToolStripMenuItem.Name = "vendaToolStripMenuItem";
            this.vendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.vendaToolStripMenuItem.Text = "Venda";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_inferior);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Cyber Fercésar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Menu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Menu_FormClosed);
            this.Pnl_inferior.ResumeLayout(false);
            this.Pnl_inferior.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_inferior;
        private System.Windows.Forms.Label Lbl_tipoConta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_nivel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Lbl_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}