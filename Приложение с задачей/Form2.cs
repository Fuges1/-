using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Приложение_с_задачей;

namespace Приложение_с_задачей
{
    public partial class Form2 : Form
    {
        private static int a = 0;
        private Form1 form1;
        private static double result = 0;
        private static double result1 = 0;
        public Form2(Form1 form1)
        {
            InitializeComponent();

            this.form1 = form1;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].HeaderText = "Фамилия участника";
            dataGridView1.Columns[1].HeaderText = "Читает?";
            dataGridView1.RowCount = Convert.ToInt32(form1.listBox1.Items.Count);
            int a = 0;
            int b = 0;
            int j = 0;
            for (int i = 0; form1.numericUpDown1.Value > i; i++)
            {
                if (a == form1.listBox1.Items.Count)
                {

                }
                else
                {
                    DataGridViewCell cell = dataGridView1.Rows[a].Cells[b];
                    cell.Value = form1.listBox1.Items[j];
                    a++;
                    j++;
                }

            }

            label1.Text = form1.listBox1.Items[Form2.a] + ", вы любите читать?";


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            int b = 1;
            if (a == form1.listBox1.Items.Count || a > form1.listBox1.Items.Count)
            {
                button1.Visible = true;
                label6.Visible = true;
                label1.Visible = false;
                dataGridView1.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }
            if (checkBox1.Checked)
            {


                if (a == form1.listBox1.Items.Count || a > form1.listBox1.Items.Count)
                {

                }
                else
                {

                    DataGridViewCell cell1 = dataGridView1.Rows[a].Cells[b];
                    cell1.Value = "да";
                    panel1.Visible = true;
                    a++;

                }






            }


        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int b = 1;
            if (a == form1.listBox1.Items.Count || a > form1.listBox1.Items.Count)
            {
                button1.Visible = true;
                label6.Visible = true;
                label1.Visible = false;
                dataGridView1.Visible = true;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
            }

            if (checkBox2.Checked)
            {

                if (a == form1.listBox1.Items.Count || a > form1.listBox1.Items.Count)
                {

                }
                else
                {
                    DataGridViewCell cell1 = dataGridView1.Rows[a].Cells[b];
                    cell1.Value = "нет";
                    panel2.Visible = true;
                    a++;


                }



            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Text = "Спасибо";
            panel1.Visible = false;
            panel.Visible = true;
            label2.Text = "       МОЛОДЕЦ!";
            checkBox1.Checked = false;
            if (Form2.a == form1.listBox1.Items.Count)
            {
                label1.Text = form1.listBox1.Items[form1.listBox1.Items.Count - 1] + ", вы любите читать?";
            }
            else
            {
                label1.Text = form1.listBox1.Items[Form2.a] + ", вы любите читать?";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Text = "ОК";
            label2.Text = "Надо, надо читать";
            panel2.Visible = false;
            panel.Visible = true;
            checkBox2.Checked = false;
            if (Form2.a == form1.listBox1.Items.Count)
            {
                label1.Text = form1.listBox1.Items[form1.listBox1.Items.Count - 1] + ", вы любите читать?";
            }
            else
            {
                label1.Text = form1.listBox1.Items[Form2.a] + ", вы любите читать?";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            a--;
            int b = 1;
            panel2.Visible = false;
            checkBox2.Checked = false;
            DataGridViewCell cell1 = dataGridView1.Rows[a].Cells[b];
            cell1.Value = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            a--;
            int b = 1;
            panel1.Visible = false;
            checkBox1.Checked = false;
            DataGridViewCell cell1 = dataGridView1.Rows[a].Cells[b];
            cell1.Value = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int l = form1.listBox1.Items.Count;
            int r = 100;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals("да"))
                    {
                        cell.Value = 1;
                        result1++;

                    }
                }
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Equals("нет"))
                    {
                        cell.Value = 0;
                        result++;

                    }
                }
            }

            result = result / l;
            result = result * r;
            result1 = result1 / l;
            result1 = result1 * r;
            label5.Text = result1 + "% cтудентов читают книги \n" + result + "% не читают книги";



            dataGridView1.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            label5.Visible = true;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            button7.Visible = true;


        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}