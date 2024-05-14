namespace calculator4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string opration = "";
        bool iso = false;
        double res = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button12.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                {
                    textBox1.Text = textBox1.Text + button14.Text;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button16.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Clear(); }
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {

            opration = button18.Text;
            res = double.Parse(textBox1.Text);
            iso = true;
            if (iso == true)
            {
                textBox1.Clear();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            opration = button17.Text;
            res = double.Parse(textBox1.Text);
            iso = true;
            if (iso == true)
            {
                textBox1.Clear();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            opration = button15.Text;
            res = double.Parse(textBox1.Text);
            iso = true;
            if (iso == true)
            {
                textBox1.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            opration = button9.Text;
            res = double.Parse(textBox1.Text);
            iso = true;
            if (iso == true)
            {
                textBox1.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            opration = button5.Text;
            res = double.Parse(textBox1.Text);
            iso = true;
            if (iso == true)
            {
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (opration)
            {
                case "+":

                    textBox1.Text = (res + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (res - double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (res / double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (res * double.Parse(textBox1.Text)).ToString();
                    break;
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }
    }
}
