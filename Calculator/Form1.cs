using System.Linq.Expressions;

namespace Calculator
{
    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> mathFuction = new List<string>();
        double result = 0;

        private void SavePiece(string pieceOfFunction)
        {
            //New shit
            string[] temporary = textBoxFormula.Text.Split(new Char[] { '+', '-' });


            textBoxFormula.Text = textBoxFormula.Text + pieceOfFunction;
            mathFuction.Add(pieceOfFunction);
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            string one = "1";
            SavePiece(one);
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            string two = "2";
            SavePiece(two);
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            string three = "3";
            SavePiece(three);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string four = "4";
            SavePiece(four);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string five = "5";
            SavePiece(five);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string six = "6";
            SavePiece(six);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string plus = "+";
            SavePiece(plus);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string eight = "8";
            SavePiece(eight);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string nine = "9";
            SavePiece(nine);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            string minus = "-";
            SavePiece(minus);
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            string plus = "+";
            SavePiece(plus);
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            //Easy easy way. Only two numbers allowed.
            String[] pieces = textBoxFormula.Text.Split(' ');

            switch (pieces[2])
            {
                case "+":
                    result = Int32.Parse(pieces[1]) + Int32.Parse(pieces[3]);
                    textBoxResult.Text = result.ToString();
                    textBoxFormula.Text = "";
                    break;
                case "-":
                    result = Int32.Parse(pieces[1]) - Int32.Parse(pieces[3]);
                    textBoxResult.Text = result.ToString();
                    textBoxFormula.Text = "";
                    break;
                case "*":
                    result = Int32.Parse(pieces[1]) * Int32.Parse(pieces[3]);
                    textBoxResult.Text = result.ToString();
                    textBoxFormula.Text = "";
                    break;
                case "/":
                    result = Int32.Parse(pieces[1]) / Int32.Parse(pieces[3]);
                    textBoxResult.Text = result.ToString();
                    textBoxFormula.Text = "";
                    break;
                default:
                    MessageBox.Show("Forkert inut");
                    break;
            }
        }
    }
}
