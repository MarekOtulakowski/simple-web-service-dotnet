using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_WebService_CSharp
{
    public partial class F_Glowna : Form
    {
        MyWebService.WebServiceSoapClient mws;

        public F_Glowna()
        {
            InitializeComponent();
            mws = new MyWebService.WebServiceSoapClient();
            CB_operacja.Items.Add("+");
            CB_operacja.Items.Add("-");
            CB_operacja.Items.Add("*");
            CB_operacja.Items.Add("/");
            CB_operacja.SelectedIndex = 0;
        }

        private void B_wylicz_Click(object sender, EventArgs e)
        {
            try
            {
                if (WalidacjaDanychXiY())
                {
                    if (CB_operacja.SelectedItem.ToString() == "+")
                    {
                        TB_wynik.Text = (mws.Dodaj(int.Parse(TB_x.Text), int.Parse(TB_y.Text))).ToString();
                    }
                    else if (CB_operacja.SelectedItem.ToString() == "-")
                    {
                        TB_wynik.Text = (mws.Odejmij(int.Parse(TB_x.Text), int.Parse(TB_y.Text))).ToString();
                    }
                    else if (CB_operacja.SelectedItem.ToString() == "*")
                    {
                        TB_wynik.Text = (mws.Pomnoz(int.Parse(TB_x.Text), int.Parse(TB_y.Text))).ToString();
                    }
                    else if (CB_operacja.SelectedItem.ToString() == "/")
                    {
                        TB_wynik.Text = (mws.Podziel(int.Parse(TB_x.Text), int.Parse(TB_y.Text))).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                TB_bledy.Text = "Błąd działania funkcji:\n" + ex.Message;
            }
            
        }

        private bool WalidacjaDanychXiY()
        {
            TB_bledy.Text = String.Empty;
            if (string.IsNullOrEmpty(TB_x.Text))
            {
                TB_bledy.Text = "Wartość pierwszego pola jest niewypełniona, uzupełnij dane";
            }
            if (string.IsNullOrEmpty(TB_y.Text))
            {
                TB_bledy.Text = "Wartość drugiego pola jest niewypełniona, uzupełnij dane";
            }
            try
            {
                int x = int.Parse(string.Format("{0}", TB_x.Text));
                int y = int.Parse(string.Format("{0}", TB_y.Text));
            }
            catch
            {
                TB_bledy.Text = "Wynik walizacji negatywny!, to nie są poprawne wartości Int";
            }
            if (TB_bledy.Text != String.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
