using System;
using System.Windows.Forms;

namespace MetaNetPDV
{
    public partial class FrmPrincipal : Form
    {
        private readonly string cnStr = "Server=10.250.123.10;Database=metanetdb;Persist Security Info=False;User ID=sa;Password=N@net431;TrustServerCertificate=True;Connection Timeout=30;";
        private readonly Database db;
        public FrmPrincipal()
        {
            InitializeComponent();
            db = new Database(cnStr);
        }

        private void mercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Helper.FormAberto("FrmMercadoria", this))
            {
                FrmMercadoria newMDIChild = new FrmMercadoria(db);
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void formulárioVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Helper.FormAberto("FrmVenda", this))
            {
                FrmVenda newMDIChild = new FrmVenda(db);
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }

        private void documentosEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Helper.FormAberto("FrmDocumentosEmitidos", this))
            {
                FrmDocumentoEmitidos newMDIChild = new FrmDocumentoEmitidos(db);
                newMDIChild.MdiParent = this;
                newMDIChild.Show();
            }
        }
    }
}
