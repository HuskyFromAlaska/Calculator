namespace Calculator
{
    public partial class Form1 : Form
    {
        public string procedure;
        public string currNum;
        public bool nextNum;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {

            //Число после действия
            if (nextNum)
            {
                nextNum = false;
                txtDisplay.Text = "0";
            }

            //Убираем знак 0 и , после начала операции.
            Button b = (Button)sender;
            if (txtDisplay.Text == "0" || txtDisplay.Text == ",")
                txtDisplay.Text = b.Text;

            else
                txtDisplay.Text = txtDisplay.Text + b.Text;
        }

        //Кнопка AC чистит дисплей после нажатия
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        //Запоминает первое число, после нажатия операции +-/* стирает и дает записать следующее число
        private void btnProced(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            procedure = b.Text;
            currNum = txtDisplay.Text;
            nextNum = true;

        }

        private void btnEql_Click(object sender, EventArgs e)
        {
            double currNum1, currNum2, result;
            result = 0;
            currNum1 = Convert.ToDouble(currNum);
            currNum2 = Convert.ToDouble(txtDisplay.Text);
            if (procedure == "+")
            {
                result = currNum1 + currNum2;
            }
            if (procedure == "-")
            {
                result = currNum1 - currNum2;
            }
            if (procedure == "×")
            {
                result = currNum1 * currNum2;
            }
            if (procedure == "÷")
            {
                result = currNum1 / currNum2;
            }
            procedure = "=";
            nextNum = true;
            txtDisplay.Text = result.ToString();
        }

        private void btnPerc_Click(object sender, EventArgs e)
        {
            double currNum1, currNum2, result;
            currNum1 = Convert.ToDouble(txtDisplay.Text);
            result = Curn;
            
        }
    }
}
