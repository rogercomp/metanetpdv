using Dapper;
using System;
using System.Windows.Forms;

namespace MetaNetPDV
{

    public partial class FrmMercadoria : Form
    {
        private Database _db;
        public FrmMercadoria(Database db)
        {
            InitializeComponent();
            txtPreco.KeyPress += Helper.ApenasValorNumerico;
            txtCodigoBarras.KeyPress += Helper.ApenasDigitosNumericos;
            _db = db;
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            string codigoBarras = txtCodigoBarras.Text;
            string descricao = txtDescricao.Text;
            decimal preco = Convert.ToDecimal(txtPreco.Text);

            using (var conn = _db.GetConnection())
            {
                conn.Execute("INSERT INTO Mercadoria (CodigoBarras, Descricao, Preco) VALUES (@CodigoBarras, @Descricao, @Preco)",
                             new { CodigoBarras = codigoBarras, Descricao = descricao, Preco = preco });
            }
            MessageBox.Show("Mercadoria cadastrada com sucesso!");
        }
    }
}

