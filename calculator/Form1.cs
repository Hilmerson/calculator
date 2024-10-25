namespace calculator
{
    public partial class Form1 : Form
    {
        string mathOperator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal number1 = Convert.ToDecimal(textBox1.Text);
            decimal number2 = Convert.ToDecimal(textBox2.Text);
            decimal result;

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
            mathOperator = button.Text;
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
    }
}
