namespace SistemaDeBarbearia
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.funcionáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestãoDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerirUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.terminarSessãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_painel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.funcionáriosToolStripMenuItem,
            this.gestãoDeUsuáriosToolStripMenuItem,
            this.contaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // funcionáriosToolStripMenuItem
            // 
            this.funcionáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarFuncionárioToolStripMenuItem});
            this.funcionáriosToolStripMenuItem.Name = "funcionáriosToolStripMenuItem";
            this.funcionáriosToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.funcionáriosToolStripMenuItem.Text = "Gestão de Funcionários";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            this.cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            this.cadastrarFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            this.cadastrarFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFuncionárioToolStripMenuItem_Click);
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            this.gestãoDeUsuáriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerirUsuáriosToolStripMenuItem});
            this.gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            this.gestãoDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            // 
            // gerirUsuáriosToolStripMenuItem
            // 
            this.gerirUsuáriosToolStripMenuItem.Name = "gerirUsuáriosToolStripMenuItem";
            this.gerirUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gerirUsuáriosToolStripMenuItem.Text = "Gerir Usuários";
            this.gerirUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.gerirUsuáriosToolStripMenuItem_Click);
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.terminarSessãoToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // terminarSessãoToolStripMenuItem
            // 
            this.terminarSessãoToolStripMenuItem.Name = "terminarSessãoToolStripMenuItem";
            this.terminarSessãoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.terminarSessãoToolStripMenuItem.Text = "Terminar Sessão";
            this.terminarSessãoToolStripMenuItem.Click += new System.EventHandler(this.terminarSessãoToolStripMenuItem_Click);
            // 
            // pnl_painel
            // 
            this.pnl_painel.BackColor = System.Drawing.Color.Transparent;
            this.pnl_painel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_painel.Location = new System.Drawing.Point(0, 24);
            this.pnl_painel.Name = "pnl_painel";
            this.pnl_painel.Size = new System.Drawing.Size(703, 447);
            this.pnl_painel.TabIndex = 1;
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaDeBarbearia.Properties.Resources.fundo_MenuPrincipal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 471);
            this.Controls.Add(this.pnl_painel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem funcionáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem terminarSessãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_painel;
        private System.Windows.Forms.ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerirUsuáriosToolStripMenuItem;
    }
}