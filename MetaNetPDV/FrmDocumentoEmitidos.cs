using Dapper;
using MetaNetPDV.Domain;
using System.Linq;
using System.Windows.Forms;

namespace MetaNetPDV
{
    public partial class FrmDocumentoEmitidos : Form
    {
        private Database _db;
        public FrmDocumentoEmitidos(Database db)
        {
            InitializeComponent();
            _db = db;
            CarregarVendas();
            lstVendas.SelectedIndex = 0;
        }

        private void CarregarVendas()
        {
            using (var conn = _db.GetConnection())
            {
                var vendas = conn.Query<Venda>(@"SELECT * 
                                                 FROM Venda with(nolock)").ToList();
                lstVendas.DataSource = vendas;
                lstVendas.DisplayMember = "DataVenda"  ; 
            }
        }

        private void lstVendas_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (lstVendas.SelectedItem != null)
            {
                var venda = (Venda)lstVendas.SelectedItem;

                using (var conn = _db.GetConnection())
                {
                    var itensVenda = conn.Query<ItemVenda>(@"SELECT iv.*, m.Descricao 
                                                             FROM ItemVenda iv with(nolock) 
                                                             INNER JOIN Mercadoria m with(nolock) ON m.Id = iv.MercadoriaID  
                                                             WHERE iv.VendaId = @VendaId ", new { VendaId = venda.Id }).ToList();
                    lstItensVenda.DataSource = itensVenda;
                    lstItensVenda.DisplayMember = "Descricao"; 
                }
            }
        }
    }
}
