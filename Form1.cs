using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rood__Boter_Kaas_en_Eieren
{
    public partial class Form1 : Form
    {

        bool Winnaar = false;
        public Form1()
        {
            InitializeComponent();
            scoreO.Text = "Score O: 0";
            scoreX.Text = "Score X: 0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelWinnaar.Visible = false;
        }
        private void AanDeBeurt()
        {
            if (labelWiensBeurt.Text == "O")
            {
                labelWiensBeurt.Text = "X";
            }
            else if (labelWiensBeurt.Text == "X")
            {
                labelWiensBeurt.Text = "O";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button1.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button2.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button3.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button4.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button5.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button6.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button7.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button8.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (Winnaar == false)
            {
                button9.Text = labelWiensBeurt.Text;
                AanDeBeurt();
                isThereAWinner();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            labelWiensBeurt.Text = "X";

            labelWinnaar.Visible = false;
            Winnaar = false;
        }
        private void isThereAWinner()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                XWinner();
            }
            else if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                XWinner();
            }
            else if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
            {
                XWinner();
            }
            else if (button7.Text == "X" && button4.Text == "X" && button1.Text == "X")
            {
                XWinner();
            }
            else if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                XWinner();
            }
            else if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                XWinner();
            }
            else if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                XWinner();
            }
            else if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                XWinner();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                OWinner();
            }
            else if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                OWinner();
            }
            else if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O")
            {
                OWinner();
            }
            else if (button7.Text == "O" && button4.Text == "O" && button1.Text == "O")
            {
                OWinner();
            }
            else if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                OWinner();
            }
            else if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                OWinner();
            }
            else if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                OWinner();
            }
            else if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                OWinner();
            }
        }
        private void XWinner()
        {
            labelWinnaar.Visible = true;
            labelWinnaar.Text = "X Winnaar";
            Winnaar = true;
            scoreX.Text = ("Score X: " + 1); 
        }
        private void OWinner()
        {
            labelWinnaar.Visible = true;
            labelWinnaar.Text = "O Winnaar";
            Winnaar = true;
            scoreO.Text = ("Score O: " + 1);
        }

        private void resetGame_Click(object sender, EventArgs e)
        {
            scoreO.Text = "Score O: 0";
            scoreX.Text = "Score X: 0";
        }
    }
}
