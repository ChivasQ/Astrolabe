namespace Astrolabe
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            resultList = new ListBox();
            starBindingSource1 = new BindingSource(components);
            starBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // resultList
            // 
            resultList.AccessibleName = "resultList";
            resultList.DataSource = starBindingSource1;
            resultList.DisplayMember = "Name";
            resultList.FormattingEnabled = true;
            resultList.ItemHeight = 15;
            resultList.Location = new Point(12, 12);
            resultList.Name = "resultList";
            resultList.Size = new Size(388, 424);
            resultList.TabIndex = 1;
            resultList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // starBindingSource1
            // 
            starBindingSource1.DataSource = typeof(Models.Star);
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Models.Star);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(119, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(415, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(6);
            groupBox1.Size = new Size(373, 106);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Пошук";
            // 
            // button1
            // 
            button1.Location = new Point(148, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Знайти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 1;
            label1.Text = "Пошук по назві";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(415, 134);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 302);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Зірка";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 73);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 4;
            label3.Text = "Опис";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Назва";
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("DataContext", starBindingSource1, "Description", true));
            textBox3.DataBindings.Add(new Binding("Text", starBindingSource1, "Description", true));
            textBox3.Location = new Point(52, 70);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 84);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("DataContext", starBindingSource1, "Name", true));
            textBox2.DataBindings.Add(new Binding("Text", starBindingSource1, "Name", true));
            textBox2.Location = new Point(51, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(resultList);
            Name = "MainForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox resultList;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
        private BindingSource starBindingSource;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox2;
        private BindingSource starBindingSource1;
    }
}
