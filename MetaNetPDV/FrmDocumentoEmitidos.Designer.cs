namespace MetaNetPDV
{
    partial class FrmDocumentoEmitidos
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
            this.lstVendas = new System.Windows.Forms.ListBox();
            this.lstItensVenda = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstVendas
            // 
            this.lstVendas.FormattingEnabled = true;
            this.lstVendas.Location = new System.Drawing.Point(47, 35);
            this.lstVendas.Name = "lstVendas";
            this.lstVendas.Size = new System.Drawing.Size(708, 160);
            this.lstVendas.TabIndex = 0;
            this.lstVendas.SelectedIndexChanged += new System.EventHandler(this.lstVendas_SelectedIndexChanged);
            // 
            // lstItensVenda
            // 
            this.lstItensVenda.FormattingEnabled = true;
            this.lstItensVenda.Location = new System.Drawing.Point(56, 219);
            this.lstItensVenda.Name = "lstItensVenda";
            this.lstItensVenda.Size = new System.Drawing.Size(698, 199);
            this.lstItensVenda.TabIndex = 1;
            // 
            // FrmDocumentoEmitidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstItensVenda);
            this.Controls.Add(this.lstVendas);
            this.Name = "FrmDocumentoEmitidos";
            this.Text = "FrmDocumentoEmitidos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstVendas;
        private System.Windows.Forms.ListBox lstItensVenda;
    }
}