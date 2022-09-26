namespace PizzaShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label7.Text + " " + label8.Text + " " + label9.Text + " " + label10.Text + " " + label11.Text);     
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = checkBox1.Text;   
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Text = checkBox2.Text;   
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label9.Text = checkBox3.Text; 
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label10.Text = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label11.Text = checkBox5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }
    }
}