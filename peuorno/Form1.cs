using static System.Net.Mime.MediaTypeNames;

namespace peuorno
{
    public partial class Form1 : Form
    {
        private double num1, num2;
        private string textnum;
        private string symbol;
        private bool isOperat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = sender.ToString().Replace("System.Windows.Forms.Button, Text: ", "");
            switch (text)
            {
                case "+":
                    num1 = double.Parse(textnum);
                    textnum += text;
                    symbol = text;
                    break;
                case "-":
                    num1 = double.Parse(textnum);
                    textnum += text;
                    symbol = text;
                    break;
                case "*":
                    num1 = double.Parse(textnum);
                    textnum += text;
                    symbol = text;
                    break;
                case "/":
                    num1 = double.Parse(textnum);
                    textnum += text;
                    symbol = text;
                    break;
                case "=":
                    Equal();
                    return;
                case "C":
                    num1 = 0;
                    num2 = 0;
                    symbol = "";
                    textAnswer.Text = "";
                    return;
                default:
                    textnum += text;
                    break;
            }
            textAnswer.Text = textnum;
            //textAnswer.Text = (double.Parse(textNum1.Text) + double.Parse(textNum2.Text)).ToString();
        }
        private void Equal()
        {
            int pos = textnum.IndexOf(symbol);
            num2 = double.Parse(textnum.Remove(0, pos + 1));
            switch (symbol)
            {
                case "+":
                    textAnswer.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    textAnswer.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    textAnswer.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    textAnswer.Text = (num1 / num2).ToString();
                    break;

            }
        }
    }
}
