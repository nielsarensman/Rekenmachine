using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Rekenmachine : Form
    {
        public Rekenmachine()
        {
            InitializeComponent();
        }
        
        public string Berekenen(int som1, char som2, int som3)
        {
            som2 = Vertalen(som2);
            int uit = 0;
            string uits = "";
            switch (som2)
            {
                default:
                    uits = "Unsupported or wrong Operator";
                    break;
                case '+':
                    uit = som1 + som3;
                    uits = Convert.ToString(uit);
                    break;
                case '-':
                    uit = som1 - som3;
                    uits = Convert.ToString(uit);
                    break;
                case '*':
                    uit = som1 * som3;
                    uits = Convert.ToString(uit);
                    break;
                case '/':
                    uit = som1 / som3;
                    uits = Convert.ToString(uit);
                    break;
                case '=':
                    if (som1 == som3)
                    {
                        uits = "Waar";
                    }
                    else
                    {
                        uits = "Niet waar";
                    }
                    break;
                case '!':
                    if (som1 != som3)
                    {
                        uits = "Waar";
                    }
                    else
                    {
                        uits = "Niet waar";
                    }
                    break;
                case '<':
                    if (som1 < som3)
                    {
                        uits = "Waar";
                    }
                    else
                    {
                        uits = "Niet waar";
                    }
                    break;
                case '>':
                    if (som1 > som3)
                    {
                        uits = "Waar";
                    }
                    else
                    {
                        uits = "Niet waar";
                    }
                    break;

            }
            

            return uits;
        }

        public char Vertalen(char raw)
        {
            switch (raw)
            {
                case 'x':
                    raw = '*';
                    break;
                case 'X':
                    raw = '*';
                    break;
                case ':':
                    raw = '/';
                    break;
                case ';':
                    raw = '/';
                    break;
                default:
                    
                    break;
            }

            return raw;
        }
        
        private void Reken_Click(object sender, EventArgs e)
        {
            if ((Rekensom1.Text != "") && (Rekensom2.Text != "") && (Rekensom3.Text != ""))
            {
                try
                {
                    Uitwerking.Text = Berekenen(Convert.ToInt32(Rekensom1.Text), Convert.ToChar(Rekensom2.Text), Convert.ToInt32(Rekensom3.Text));
                }
                catch(Exception ex)
                {

                    Uitwerking.Text = "Syntax Error";
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Uitwerking.Text = "";
            }
        }
    }
}
