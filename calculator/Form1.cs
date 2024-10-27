namespace calculator
{
    public partial class Form1 : Form
    {
        string mathOperator = "";
        decimal number1;
        decimal number2;
        decimal result;
        bool operatorClicked = false;
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
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        lblResult.Text = "Cannot divide by 0.";
                    }
                    break;
                default:
                    lblResult.Text = "Invalid input";
                    break;
            }
            textBox1.Text = result.ToString();
            operatorClicked = true;
        }

        private void btnOperatorHandler(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = true;

            number1 = Convert.ToDecimal(textBox1.Text);
            mathOperator = button.Text;
        }

        private void btnNumberHandler(object sender, EventArgs e)
        {
            lblResult.Text = "";
            Button btnNumber = (Button)sender;
            if (operatorClicked)
            {
                textBox1.Clear();
            }

            if (btnNumber.Tag.ToString() != ".")
            {
                textBox1.Text += btnNumber.Tag;
            }
            else if (textBox1.Text.Length > 0 && !textBox1.Text.Contains("."))
            {
                textBox1.Text += btnNumber.Tag;
            }

            operatorClicked = false;
        }

        private void btnClear(object sender, EventArgs e)
        {
            textBox1.Clear();
            lblResult.Text = "";
            number1 = number2 = result = 0;
            operatorClicked = false;
            mathOperator = "";
        }
    }
}
