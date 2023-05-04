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
            if(someMoney > 100.00) 
            {
                MessageBox.Show("You have lots of Money!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}