namespace ConditionTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double someMoney;
            someMoney = Double.Parse(textBox1.Text);
            if (someMoney > 100.00)
            {
                MessageBox.Show("You have lots of Money!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double someMoney;
            someMoney = Double.Parse(textBox1.Text);
            if (someMoney > 100.00)
            {
                MessageBox.Show("You have lots of Money!");
            }
            else
            {
                MessageBox.Show("You need more money....");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10)

                MessageBox.Show("Great news!");
            x = 100;
            MessageBox.Show("You've won $" + x);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10)
            {

                MessageBox.Show("Great news!");
                x = 100;
                MessageBox.Show("You've won $" + x);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x;
            x = Int16.Parse(textBox1.Text);
            if (x > 10)
            {

                MessageBox.Show("Great news!");
                x = 100;
                MessageBox.Show("You've won $" + x);
            }
            else
            {
                x = 0;
                MessageBox.Show("Bad luck. Your payout is $" + x);
            }
        }
    }
}