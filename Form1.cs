namespace Artem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double GetValueA()
        {
            return double.Parse(textBox1.Text);
        }

        public double GetValueB()
        {
            return double.Parse(textBox2.Text);
        }

        public void DisplayResult(double result)
        {
            label2.Text = result.ToString();
        }
        public double Add(double a, double b)
        {
            double c = a + b;
            DisplayResult(c);
            return c;
        }
        public double Sub(double a, double b)
        {
            double c = a - b;
            DisplayResult(c);
            return c;
        }
        public double Div(double a, double b)
        {

            if (b == 0)
            {
                throw new ArgumentException("На ноль делить нельзя");
            }
            double c = a / b;
            DisplayResult(c);
            return c;
        }
        public double Mul(double a, double b)
        {

            double c = a * b;
            DisplayResult(c);
            return c;
        }
        public double Log(double a)
        {
            double c = Math.Log(a);
            DisplayResult(c);
            return c;
        }
        public double Sin(double a)
        {
            double c = Math.Sin(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Cos(double a)
        {
            double c = Math.Cos(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Tg(double a)
        {
            double c = Math.Tan(a * (Math.PI / 180.0));
            DisplayResult(c);
            return c;
        }
        public double Exp(double a)
        {
            double c = Math.Exp(a);
            DisplayResult(c);
            return c;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Add(a, b);
            DisplayResult(c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Sub(a, b);
            DisplayResult(c);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Mul(a, b);
            DisplayResult(c);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Div(a, b);
            DisplayResult(c);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Log(a);
            DisplayResult(c);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Sin(a);
            DisplayResult(c);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Cos(a);
            DisplayResult(c);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Tg(a);
            DisplayResult(c);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Exp(a);
            DisplayResult(c);
        }
    }
}
