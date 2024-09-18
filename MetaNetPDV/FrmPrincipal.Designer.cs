namespace MetaNetPDV
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formulárioVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentosEmitidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mercadoriaToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // mercadoriaToolStripMenuItem
            // 
            this.mercadoriaToolStripMenuItem.Name = "mercadoriaToolStripMenuItem";
            this.mercadoriaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.mercadoriaToolStripMenuItem.Text = "Mercadoria";
            this.mercadoriaToolStripMenuItem.Click += new System.EventHandler(this.mercadoriaToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formulárioVendaToolStripMenuItem,
            this.documentosEmitidosToolStripMenuItem});
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // formulárioVendaToolStripMenuItem
            // 
            this.formulárioVendaToolStripMenuItem.Name = "formulárioVendaToolStripMenuItem";
            this.formulárioVendaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.formulárioVendaToolStripMenuItem.Text = "Formulário Venda";
            this.formulárioVendaToolStripMenuItem.Click += new System.EventHandler(this.formulárioVendaToolStripMenuItem_Click);
            // 
            // documentosEmitidosToolStripMenuItem
            // 
            this.documentosEmitidosToolStripMenuItem.Name = "documentosEmitidosToolStripMenuItem";
            this.documentosEmitidosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.documentosEmitidosToolStripMenuItem.Text = "Documentos Emitidos";
            this.documentosEmitidosToolStripMenuItem.Click += new System.EventHandler(this.documentosEmitidosToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Terminal de Atendimento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formulárioVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentosEmitidosToolStripMenuItem;
    }
}

