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
            if (mathFuction.Count() < 3)
            {
                textBoxFormula.Text = textBoxFormula.Text + " " + pieceOfFunction;
                mathFuction.Add(pieceOfFunction);
            }
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
            string minus = "+";
            SavePiece(minus);
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



            //Expression linqFormula = new Expression(textBoxFormula.Text);

            ///////////////////////////////
            //int iteration = 0;
            //string PreviousNumber = null;
            //string mathSymbol = null;
            //string nextNumber = null;
            //foreach (var item in mathFuction)
            //{

            //    switch (item)
            //    {
            //        case "+":
            //            if (iteration != 0)
            //            {
            //                mathSymbol = item.ToString();
            //            }
            //            break;
            //        case "-":
            //            if (iteration != 0)
            //            {
            //                mathSymbol = item.ToString();
            //            }
            //            break;
            //        default : //double
            //            nextNumber = item;

            //            if((mathFuction.Count() -1).Equals(iteration))
            //            {
            //                double PreviousAsInt = double.Parse(PreviousNumber);
            //                double currentAsInt = double.Parse(nextNumber);
            //                result = result + PreviousAsInt + currentAsInt;
            //                textBoxResult.Text = result.ToString();
            //            }
            //            PreviousNumber = item;
            //            break;
            //    }

            //    iteration = iteration +1;
            //}


        }
    }
}
