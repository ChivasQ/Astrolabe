
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
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            tabControl2 = new TabControl();
            tabDefaultSearch = new TabPage();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            tabAdvancedSearch = new TabPage();
            textBox5 = new TextBox();
            button4 = new Button();
            groupBox1 = new GroupBox();
            tabSearchByStar = new TabPage();
            tabControl3 = new TabControl();
            tabPage2 = new TabPage();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            tabPage3 = new TabPage();
            textBox10 = new TextBox();
            button8 = new Button();
            groupBox2 = new GroupBox();
            listBox1 = new ListBox();
            tabSearchByConstellation = new TabPage();
            tabPage1 = new TabPage();
            helpProvider1 = new HelpProvider();
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            tabControl2.SuspendLayout();
            tabDefaultSearch.SuspendLayout();
            tabAdvancedSearch.SuspendLayout();
            groupBox1.SuspendLayout();
            tabSearchByStar.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // resultList
            // 
            resultList.AccessibleName = "resultList";
            resultList.DataSource = starBindingSource1;
            resultList.DisplayMember = "Name";
            resultList.FormattingEnabled = true;
            resultList.ItemHeight = 19;
            resultList.Location = new Point(6, 22);
            resultList.Name = "resultList";
            resultList.Size = new Size(744, 175);
            resultList.TabIndex = 1;
            resultList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // starBindingSource1
            // 
            starBindingSource1.DataSource = typeof(Astrolabe.Astrolabe.models.Star);
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Astrolabe.Astrolabe.models.Star);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(tabSearchByStar);
            tabControl1.Controls.Add(tabSearchByConstellation);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 426);
            tabControl1.TabIndex = 4;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabControl2);
            tabMain.Controls.Add(groupBox1);
            tabMain.Location = new Point(4, 24);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(768, 398);
            tabMain.TabIndex = 0;
            tabMain.Text = "Головна";
            tabMain.UseVisualStyleBackColor = true;
            tabMain.Click += tabPage1_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabDefaultSearch);
            tabControl2.Controls.Add(tabAdvancedSearch);
            tabControl2.Location = new Point(6, 213);
            tabControl2.Multiline = true;
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(756, 179);
            tabControl2.TabIndex = 3;
            // 
            // tabDefaultSearch
            // 
            tabDefaultSearch.Controls.Add(textBox4);
            tabDefaultSearch.Controls.Add(textBox3);
            tabDefaultSearch.Controls.Add(label3);
            tabDefaultSearch.Controls.Add(label2);
            tabDefaultSearch.Controls.Add(textBox2);
            tabDefaultSearch.Controls.Add(textBox1);
            tabDefaultSearch.Controls.Add(label1);
            tabDefaultSearch.Controls.Add(button3);
            tabDefaultSearch.Controls.Add(button2);
            tabDefaultSearch.Controls.Add(button1);
            tabDefaultSearch.Location = new Point(4, 24);
            tabDefaultSearch.Name = "tabDefaultSearch";
            tabDefaultSearch.Padding = new Padding(3);
            tabDefaultSearch.Size = new Size(748, 151);
            tabDefaultSearch.TabIndex = 0;
            tabDefaultSearch.Text = "Звичайний пошук";
            tabDefaultSearch.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(657, 78);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(589, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(657, 60);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "довгота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(585, 60);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 6;
            label2.Text = "широта";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(680, 34);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(45, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(589, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(585, 12);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 3;
            label1.Text = "Вибір часу і місця:";
            label1.Click += label1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(394, 36);
            button3.Name = "button3";
            button3.Size = new Size(155, 24);
            button3.TabIndex = 2;
            button3.Text = "Фільтр видимі";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(394, 6);
            button2.Name = "button2";
            button2.Size = new Size(155, 24);
            button2.TabIndex = 1;
            button2.Text = "Фільтр наяскравіші";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(587, 116);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 0;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            // 
            // tabAdvancedSearch
            // 
            tabAdvancedSearch.Controls.Add(textBox5);
            tabAdvancedSearch.Controls.Add(button4);
            tabAdvancedSearch.Location = new Point(4, 24);
            tabAdvancedSearch.Name = "tabAdvancedSearch";
            tabAdvancedSearch.Padding = new Padding(3);
            tabAdvancedSearch.Size = new Size(748, 151);
            tabAdvancedSearch.TabIndex = 1;
            tabAdvancedSearch.Text = "Просунутий пошук";
            tabAdvancedSearch.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(6, 6);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(736, 104);
            textBox5.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(587, 116);
            button4.Name = "button4";
            button4.Size = new Size(155, 29);
            button4.TabIndex = 1;
            button4.Text = "Пошук";
            button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(resultList);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(756, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "База зірок";
            // 
            // tabSearchByStar
            // 
            tabSearchByStar.Controls.Add(tabControl3);
            tabSearchByStar.Controls.Add(groupBox2);
            tabSearchByStar.Location = new Point(4, 24);
            tabSearchByStar.Name = "tabSearchByStar";
            tabSearchByStar.Padding = new Padding(3);
            tabSearchByStar.Size = new Size(768, 398);
            tabSearchByStar.TabIndex = 1;
            tabSearchByStar.Text = "Пошук зірок";
            tabSearchByStar.UseVisualStyleBackColor = true;
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage2);
            tabControl3.Controls.Add(tabPage3);
            tabControl3.Location = new Point(6, 213);
            tabControl3.Multiline = true;
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(756, 179);
            tabControl3.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(748, 151);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Звичайний пошук";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(394, 36);
            button5.Name = "button5";
            button5.Size = new Size(155, 24);
            button5.TabIndex = 2;
            button5.Text = "Фільтр видимі";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(394, 6);
            button6.Name = "button6";
            button6.Size = new Size(155, 24);
            button6.TabIndex = 1;
            button6.Text = "Фільтр наяскравіші";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(587, 116);
            button7.Name = "button7";
            button7.Size = new Size(155, 29);
            button7.TabIndex = 0;
            button7.Text = "Пошук";
            button7.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(textBox10);
            tabPage3.Controls.Add(button8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(748, 151);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Просунутий пошук";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(6, 6);
            textBox10.Multiline = true;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(736, 104);
            textBox10.TabIndex = 2;
            textBox10.TextChanged += textBox10_TextChanged_1;
            // 
            // button8
            // 
            button8.Location = new Point(587, 116);
            button8.Name = "button8";
            button8.Size = new Size(155, 29);
            button8.TabIndex = 1;
            button8.Text = "Пошук";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBox1);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(756, 201);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пошук за зірками";
            // 
            // listBox1
            // 
            listBox1.DataSource = starBindingSource1;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 19;
            listBox1.Location = new Point(6, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(744, 175);
            listBox1.TabIndex = 0;
            // 
            // tabSearchByConstellation
            // 
            tabSearchByConstellation.Location = new Point(4, 24);
            tabSearchByConstellation.Name = "tabSearchByConstellation";
            tabSearchByConstellation.Size = new Size(768, 398);
            tabSearchByConstellation.TabIndex = 2;
            tabSearchByConstellation.Text = "Пошук сузір'їв";
            tabSearchByConstellation.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Спостереження";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Астролябія";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabDefaultSearch.ResumeLayout(false);
            tabDefaultSearch.PerformLayout();
            tabAdvancedSearch.ResumeLayout(false);
            tabAdvancedSearch.PerformLayout();
            groupBox1.ResumeLayout(false);
            tabSearchByStar.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private ListBox resultList;
        private BindingSource starBindingSource;
        private BindingSource starBindingSource1;
        private TabControl tabControl1;
        private TabPage tabMain;
        private TabPage tabSearchByStar;
        private GroupBox groupBox1;
        private TabPage tabSearchByConstellation;
        private TabPage tabPage1;
        private HelpProvider helpProvider1;
        private TabControl tabControl2;
        private TabPage tabDefaultSearch;
        private TabPage tabAdvancedSearch;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox5;
        private Button button4;
        private GroupBox groupBox2;
        private TabControl tabControl3;
        private TabPage tabPage2;
        private Button button5;
        private Button button6;
        private Button button7;
        private TabPage tabPage3;
        private TextBox textBox10;
        private Button button8;
        private ListBox listBox1;
    }
}
