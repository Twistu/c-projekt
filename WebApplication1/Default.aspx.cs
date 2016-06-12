using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox3.Text == "" ) {
                Label1.Text="Musisz wpisać tresc wiadomosci";
                return;}
            if (TextBox5.Text == "")
            {
                Label1.Text = "Musisz uzupełnic pola \"Podpis\"";
                Label2.Text = "▽";
                if (TextBox6.Text == "")
                {
                    Label1.Text = "Musisz uzupełnic pola \"Podpis\"";
                    Label3.Text = "▽";
                    return;
                }
                return;
            }
            if (TextBox6.Text == "")
            {
                Label1.Text = "Musisz uzupełnic pola \"Podpis\"";
                Label3.Text = "▽";
                return;
            }
            try
            {
                string naglowek1 = "Otrzymano wiadomosc od " + TextBox5.Text + " ( " + DateTime.Now.ToString() + " ) ";
                string naglowek2 = "Wyslano do " + TextBox6.Text;
                string tresc = TextBox3.Text.Trim().Replace("\n", "<br />");
                string wiadomosc1 = naglowek1 + "\n" + "->>>" + tresc + "\n";
                string wiadomosc2 = naglowek2 + "\n";
                TextBox7.Text += wiadomosc2;
                TextBox8.Text += wiadomosc1;
                TextBox3.Text = "";
            }
            catch (Exception ex) { }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox4.Text == "")
            {
                Label1.Text = "Musisz wpisać tresc wiadomosci";
                return;
            }
            else
            {
                Label1.Text = "";
            }
            if (TextBox5.Text == "")
            {
                Label1.Text = "Musisz uzupełnic pola \"Podpis\"";
                Label2.Text = "▽";
                if (TextBox6.Text == "")
                {
                    Label3.Text = "▽";
                    return;
                }
                return;

            }
            else
            {
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
            }
            if (TextBox6.Text == "")
            {
                Label1.Text = "Musisz uzupełnic pola \"Podpis\"";
                Label3.Text = "▽";
                return;
            }
            else {
                Label1.Text = "";
                Label2.Text = "";
                Label3.Text = "";
            }
            try
            {
                string naglowek1 = "Otrzymano wiadomosc od " + TextBox6.Text + " ( " + DateTime.Now.ToString() + " ) ";
                string naglowek2 = "Wyslano do " + TextBox5.Text;
                string tresc = TextBox4.Text.Trim().Replace("\n", "<br />");
                string nowyWpis = naglowek1 + "\n" + tresc;
                string wiadomosc1 = naglowek1 + "\n" + "->>>" + tresc + "\n";
                string wiadomosc2 = naglowek2 + "\n";
                TextBox7.Text += wiadomosc1;
                TextBox8.Text += wiadomosc2;
                TextBox4.Text = "";
            }
            catch (Exception ex) { }
        }
    }
}