namespace Astrolabe.forms
{
    partial class DataEditorForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            buttonAdd = new Button();
            textBox3 = new TextBox();
            button3 = new Button();
            listBox1 = new ListBox();
            starBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            buttonDelete = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(688, 583);
            splitContainer1.SplitterDistance = 362;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonAdd);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(347, 559);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(315, 489);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(26, 25);
            buttonAdd.TabIndex = 7;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 523);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(240, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(252, 520);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
            button3.TabIndex = 1;
            button3.Text = "Фільтрувати";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.DataSource = starBindingSource;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 22);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(335, 469);
            listBox1.TabIndex = 0;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Astrolabe.models.Star);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(buttonDelete);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(3, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(307, 559);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("DataContext", starBindingSource, "Name", true));
            textBox4.DataBindings.Add(new Binding("Text", starBindingSource, "ApparentMagnitude", true));
            textBox4.Location = new Point(155, 109);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(121, 23);
            textBox4.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 112);
            label3.Name = "label3";
            label3.Size = new Size(149, 15);
            label3.TabIndex = 6;
            label3.Text = "Видима зоряна величина:";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("DataContext", starBindingSource, "Name", true));
            textBox2.DataBindings.Add(new Binding("Text", starBindingSource, "Description", true));
            textBox2.Location = new Point(85, 195);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(191, 73);
            textBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 198);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Опис зірки:";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("DataContext", starBindingSource, "Name", true));
            textBox1.DataBindings.Add(new Binding("Text", starBindingSource, "Name", true));
            textBox1.Location = new Point(155, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(219, 523);
            button2.Name = "button2";
            button2.Size = new Size(82, 28);
            button2.TabIndex = 2;
            button2.Text = "Зберегти";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 523);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(82, 28);
            buttonDelete.TabIndex = 1;
            buttonDelete.Text = "Видалити";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 83);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 0;
            label1.Text = "Назва зірки:";
            // 
            // DataEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 583);
            Controls.Add(splitContainer1);
            Name = "DataEditorForm";
            Text = "DataEditorForm";
            Load += DataEditorForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Button button2;
        private Button buttonDelete;
        private TextBox textBox2;
        private Label label2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private BindingSource starBindingSource;
        private Button buttonAdd;
    }
}