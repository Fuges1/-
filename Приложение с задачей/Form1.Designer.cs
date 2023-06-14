namespace Приложение_с_задачей
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(219, 18);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(235, 124);
            listBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 18);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(183, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 76);
            button1.Name = "button1";
            button1.Size = new Size(183, 27);
            button1.TabIndex = 3;
            button1.Text = "ОК";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(11, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(443, 139);
            panel1.TabIndex = 4;
            panel1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(3, 113);
            button2.Name = "button2";
            button2.Size = new Size(437, 23);
            button2.TabIndex = 1;
            button2.Text = "ОК";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, -1);
            label1.Name = "label1";
            label1.Size = new Size(400, 111);
            label1.TabIndex = 0;
            label1.Text = "Ошибка: \r\nУчастников не может быть: \"0\"\r\nВведите другое число =)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 149);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Данные для опроса";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        public NumericUpDown numericUpDown1;
        public ListBox listBox1;
        public ComboBox comboBox1;
        private Panel panel1;
        public Button button2;
        public Label label1;
    }
}