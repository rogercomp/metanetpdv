using System;
using System.Linq;
using System.Windows.Forms;

namespace MetaNetPDV
{
    public static class Helper
    {

        public static bool FormAberto(string formName, Form parent)
        {
            foreach (var item in parent.MdiChildren)
            {
                if (item.Text == formName)
                {
                    item.BringToFront();
                    return true;
                }
                return false;
            }
            return false;
        }

        public static string FormataDecimal(decimal value, int digits)
        {
            return value
                .ToString(String.Format("+0.{0};-0.{0}", new string('0', digits - 2)))
                .Substring(0, digits + 1);
        }

        public static string FormataDigitoL(long value, int qtd)
        {
            int tam = value.ToString().Length;
            return value.ToString().PadRight((qtd), ' ');
        }

        public static string FormataDigitoS(string value, int qtd)
        {
            int tam = value.Length;
            return value.PadRight(qtd - tam, ' ');
        }

        public static void ApenasValorNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = (txt.Text.Contains(','));
                }
                else
                    e.Handled = true;
            }
        }

        public static void ApenasDigitosNumericos(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;         

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

    }
}
