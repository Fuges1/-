namespace Приложение_с_задачей
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel = new Panel();
            button4 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            button5 = new Button();
            label3 = new Label();
            button2 = new Button();
            label4 = new Label();
            panel2 = new Panel();
            button6 = new Button();
            button3 = new Button();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(223, 145);
            dataGridView1.TabIndex = 0;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 102);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(87, 120);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(38, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "да";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(150, 120);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(44, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "нет";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // panel
            // 
            panel.Controls.Add(button4);
            panel.Controls.Add(label2);
            panel.Location = new Point(3, 2);
            panel.Name = "panel";
            panel.Size = new Size(308, 232);
            panel.TabIndex = 5;
            panel.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(118, 118);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Спасибо";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 101);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 232);
            panel1.TabIndex = 6;
            panel1.Visible = false;
            // 
            // button5
            // 
            button5.Location = new Point(14, 133);
            button5.Name = "button5";
            button5.Size = new Size(107, 23);
            button5.TabIndex = 3;
            button5.Text = "Отмена";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Name = "label3";
            label3.Size = new Size(286, 15);
            label3.TabIndex = 0;
            label3.Text = "Вы точно хотите выбрать этот вариант ответа: \"да\"";
            // 
            // button2
            // 
            button2.Location = new Point(193, 133);
            button2.Name = "button2";
            button2.Size = new Size(107, 23);
            button2.TabIndex = 2;
            button2.Text = "Принять";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 115);
            label4.Name = "label4";
            label4.Size = new Size(292, 15);
            label4.TabIndex = 1;
            label4.Text = "Вы точно хотите выбрать этот вариант ответа: \"нет\"";
            // 
            // panel2
            // 
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(6, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(308, 232);
            panel2.TabIndex = 7;
            panel2.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(14, 133);
            button6.Name = "button6";
            button6.Size = new Size(107, 23);
            button6.TabIndex = 4;
            button6.Text = "Отмена";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button3
            // 
            button3.Location = new Point(193, 133);
            button3.Name = "button3";
            button3.Size = new Size(107, 23);
            button3.TabIndex = 1;
            button3.Text = "Принять";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 91);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 8;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(65, 55);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 9;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 12);
            label6.Name = "label6";
            label6.Size = new Size(231, 40);
            label6.TabIndex = 10;
            label6.Text = "Нажмите \"ОК\" чтобы вычилить \r\n    процентное соотношение  ";
            label6.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(90, 151);
            button7.Name = "button7";
            button7.Size = new Size(138, 23);
            button7.TabIndex = 4;
            button7.Text = "Заново";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 240);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(panel);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Опрос";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel;
        private Label label2;
        public DataGridView dataGridView1;
        private Panel panel1;
        private Label label3;
        private Button button2;
        private Label label4;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        public Label label1;
        public Label label5;
        public Label label6;
        public Button button1;
        public Button button7;
    }
}