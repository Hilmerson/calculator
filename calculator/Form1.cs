namespace calculator
{
    public partial class Form1 : Form
    {
        string mathOperator = "";
        decimal number1;
        decimal number2;
        decimal result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEquals(object sender, EventArgs e)
        {
            number2 = Convert.ToDecimal(textBox1.Text);

            switch (mathOperator)
            {
                case "+":
                    result = number1 + number2;
                    lblResult.Text = result.ToString();
                    break;
                case "-":
                    result = number1 - number2;
                    lblResult.Text = result.ToString();
                    break;
                case "*":
                    result = number1 * number2;
                    lblResult.Text = result.ToString();
                    break;
                case "/":
                    result = number1 / number2;
                    lblResult.Text = result.ToString();
                    break;
                default:
                    lblResult.Text = "Invalid input";
                    break;
            }
        }

        private void btnOperatorHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            number1 = Convert.ToDecimal(textBox1.Text);
            mathOperator = button.Text;
            textBox1.Clear();
        }

        private void btnNumberHandler(object sender, EventArgs e)
        {
            Button btnNumber = (Button)sender;
            if (btnNumber.Tag != ".")
                textBox1.Text += btnNumber.Tag;
            else if (textBox1.Text.Length > 0 && !textBox1.Text.Contains("."))
            {
                textBox1.Text += btnNumber.Tag;
            }
        }

        private void btnClear(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
