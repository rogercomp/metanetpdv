using Dapper;
using MetaNetPDV.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MetaNetPDV
{

    public partial class FrmVenda : Form
    {
        private Database _db;
        private List<ItemVenda> _itensVenda;

        public FrmVenda(Database db)
        {
            InitializeComponent();
            _db = db;
            _itensVenda = new List<ItemVenda>();
            txtValorUnitario.KeyPress += Helper.ApenasValorNumerico;
            txtQuantidade.KeyPress += Helper.ApenasDigitosNumericos;
            txtCodigoBarras.KeyPress += Helper.ApenasDigitosNumericos;
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            if (txtCodigoBarras.Text == string.Empty)
            {
                MessageBox.Show("Informe o código de barras!");
                return;
            }

            long codigoBarra = long.Parse(lblCodigo.Text);

            var item = new ItemVenda
            {
                MercadoriaId = Int32.Parse(lblCodigo.Text),
                Quantidade = Int32.Parse(txtQuantidade.Text),
                SubTotal = Decimal.Parse(txtValorUnitario.Text) * Int32.Parse(txtQuantidade.Text),
                Descricao = Helper.FormataDigitoS(txtCodigoBarras.Text, 20) + " | " + Helper.FormataDigitoS(txtDescricao.Text, 50) + " | " + Helper.FormataDigitoS(txtQuantidade.Text, 3) + " X " + txtValorUnitario.Text
            };

            _itensVenda.Add(item);
            AtualizarListaItens();
            LimpaCampos();

        }

        private void AtualizarListaItens()
        {
            lstItensVenda.DataSource = null;
            lstItensVenda.DataSource = _itensVenda;
            lstItensVenda.DisplayMember = "Descricao";

            decimal totalVenda = _itensVenda.Sum(i => i.SubTotal);
            lblTotal.Text = totalVenda.ToString("N2");
        }

        private void btnCancelarItem_Click(object sender, System.EventArgs e)
        {
            if (lstItensVenda.SelectedIndex >= 0)
            {
                _itensVenda.RemoveAt(lstItensVenda.SelectedIndex);
                AtualizarListaItens();
            }
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            string codigoBarras = txtCodigoBarras.Text;
            if (codigoBarras.Length > 0)
            {
                if (e.KeyChar == (char)Keys.Return)
                {
                    Mercadoria mercadoria;

                    using (var conn = _db.GetConnection())
                    {
                        mercadoria = conn.QuerySingleOrDefault<Mercadoria>(@"SELECT *  
                                                                             FROM Mercadoria with(nolock) 
                                                                             WHERE CodigoBarras = @CodigoBarras", new { CodigoBarras = codigoBarras });
                    }

                    if (mercadoria != null)
                    {
                        lblCodigo.Text = mercadoria.Id.ToString();
                        txtQuantidade.Text = "1";
                        txtValorUnitario.Text = mercadoria.Preco.ToString();
                        txtDescricao.Text = mercadoria.Descricao;
                        lblSubTotal.Text = (mercadoria.Preco * Int32.Parse(txtQuantidade.Text)).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Produto não encontrado!");
                    }
                }
            }
        }

        private void btnFinalizarVenda_Click(object sender, System.EventArgs e)
        {
            decimal totalVenda = _itensVenda.Sum(i => i.SubTotal);

            using (var conn = _db.GetConnection())
            {
                var vendaId = conn.QuerySingle<int>("INSERT INTO Venda (DataVenda, Total) OUTPUT INSERTED.Id VALUES (GETDATE(), @Total)", new { Total = totalVenda });

                foreach (var item in _itensVenda)
                {
                    conn.Execute("INSERT INTO ItemVenda (VendaId, MercadoriaId, Quantidade, Subtotal) VALUES (@VendaId, @MercadoriaId, @Quantidade, @Subtotal)",
                                 new { VendaId = vendaId, item.MercadoriaId, item.Quantidade, item.SubTotal });
                }
            }

            MessageBox.Show("Venda finalizada com sucesso!");
            _itensVenda.Clear();
            AtualizarListaItens();
        }

        private void LimpaCampos()
        {
            lblCodigo.Text = string.Empty;
            txtCodigoBarras.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtValorUnitario.Text = string.Empty;
            lblSubTotal.Text = string.Empty;
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                lblSubTotal.Text = (decimal.Parse(txtValorUnitario.Text) * Int32.Parse(txtQuantidade.Text)).ToString();
            }
        }

        private void txtValorUnitario_TextChanged(object sender, EventArgs e)
        {
            if (txtValorUnitario.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                lblSubTotal.Text = (decimal.Parse(txtValorUnitario.Text) * Int32.Parse(txtQuantidade.Text)).ToString();
            }
        }
    }
}
