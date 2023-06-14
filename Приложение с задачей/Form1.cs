namespace Приложение_с_задачей
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            int g = Convert.ToInt32(numericUpDown1.Value);
            if (g == 0)
            {
                panel1.Visible = true;
            }
            else
            {

                if (listBox1.Items.Count == g)
                {
                    Form2 form2 = new Form2(this);
                    form2.Show();
                }
                else
                {

                    listBox1.Items.Add(comboBox1.Text);
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}