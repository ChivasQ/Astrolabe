
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            starBindingSource1 = new BindingSource(components);
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            tabControl2 = new TabControl();
            tabDefaultSearch = new TabPage();
            textBox4 = new TextBox();
            textBoxLatitude = new TextBox();
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
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ApparentMagnitudeColumn = new DataGridViewTextBoxColumn();
            DistanceLightYearsColumn = new DataGridViewTextBoxColumn();
            RightAscensionColumn = new DataGridViewTextBoxColumn();
            DeclinationColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
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
            tabPage4 = new TabPage();
            button9 = new Button();
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            EditBaseToolStripMenuItem = new ToolStripMenuItem();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            tabControl2.SuspendLayout();
            tabDefaultSearch.SuspendLayout();
            tabAdvancedSearch.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabSearchByStar.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            tabPage4.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // starBindingSource1
            // 
            starBindingSource1.DataSource = typeof(Astrolabe.models.Star);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabMain);
            tabControl1.Controls.Add(tabSearchByStar);
            tabControl1.Controls.Add(tabSearchByConstellation);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(980, 416);
            tabControl1.TabIndex = 4;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabControl2);
            tabMain.Controls.Add(groupBox1);
            tabMain.Location = new Point(4, 24);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(972, 388);
            tabMain.TabIndex = 0;
            tabMain.Text = "Головна";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabDefaultSearch);
            tabControl2.Controls.Add(tabAdvancedSearch);
            tabControl2.Location = new Point(6, 213);
            tabControl2.Multiline = true;
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(963, 170);
            tabControl2.TabIndex = 3;
            // 
            // tabDefaultSearch
            // 
            tabDefaultSearch.Controls.Add(button10);
            tabDefaultSearch.Controls.Add(textBox4);
            tabDefaultSearch.Controls.Add(textBoxLatitude);
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
            tabDefaultSearch.Size = new Size(955, 142);
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
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(589, 78);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(62, 23);
            textBoxLatitude.TabIndex = 8;
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
            button1.Location = new Point(587, 107);
            button1.Name = "button1";
            button1.Size = new Size(155, 29);
            button1.TabIndex = 0;
            button1.Text = "Пошук";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // tabAdvancedSearch
            // 
            tabAdvancedSearch.Controls.Add(textBox5);
            tabAdvancedSearch.Controls.Add(button4);
            tabAdvancedSearch.Location = new Point(4, 24);
            tabAdvancedSearch.Name = "tabAdvancedSearch";
            tabAdvancedSearch.Padding = new Padding(3);
            tabAdvancedSearch.Size = new Size(955, 142);
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
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(960, 201);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "База зірок";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(239, 98);
            label4.Name = "label4";
            label4.Size = new Size(517, 45);
            label4.TabIndex = 6;
            label4.Text = "Відкрийте файл для перегляду";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ApparentMagnitudeColumn, DistanceLightYearsColumn, RightAscensionColumn, DeclinationColumn, DescriptionColumn });
            dataGridView1.DataSource = starBindingSource1;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(6, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Size = new Size(948, 177);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 150;
            // 
            // ApparentMagnitudeColumn
            // 
            ApparentMagnitudeColumn.DataPropertyName = "ApparentMagnitude";
            ApparentMagnitudeColumn.HeaderText = "ApparentMagnitude";
            ApparentMagnitudeColumn.Name = "ApparentMagnitudeColumn";
            ApparentMagnitudeColumn.Width = 200;
            // 
            // DistanceLightYearsColumn
            // 
            DistanceLightYearsColumn.DataPropertyName = "DistanceLightYears";
            DistanceLightYearsColumn.HeaderText = "DistanceLightYears";
            DistanceLightYearsColumn.Name = "DistanceLightYearsColumn";
            DistanceLightYearsColumn.Width = 200;
            // 
            // RightAscensionColumn
            // 
            RightAscensionColumn.DataPropertyName = "RightAscension";
            RightAscensionColumn.HeaderText = "RightAscension";
            RightAscensionColumn.Name = "RightAscensionColumn";
            // 
            // DeclinationColumn
            // 
            DeclinationColumn.DataPropertyName = "Declination";
            DeclinationColumn.HeaderText = "Declination";
            DeclinationColumn.Name = "DeclinationColumn";
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.DataPropertyName = "Description";
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.Width = 150;
            // 
            // tabSearchByStar
            // 
            tabSearchByStar.Controls.Add(tabControl3);
            tabSearchByStar.Controls.Add(groupBox2);
            tabSearchByStar.Location = new Point(4, 24);
            tabSearchByStar.Name = "tabSearchByStar";
            tabSearchByStar.Padding = new Padding(3);
            tabSearchByStar.Size = new Size(972, 388);
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
            tabSearchByConstellation.Size = new Size(972, 388);
            tabSearchByConstellation.TabIndex = 2;
            tabSearchByConstellation.Text = "Пошук сузір'їв";
            tabSearchByConstellation.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(972, 388);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Спостереження";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button9);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(972, 388);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "інше";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(36, 24);
            button9.Name = "button9";
            button9.Size = new Size(119, 34);
            button9.TabIndex = 0;
            button9.Text = "редактор бази";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(992, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveAsToolStripMenuItem });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(37, 20);
            fIleToolStripMenuItem.Text = "FIle";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(121, 22);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(121, 22);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EditBaseToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // EditBaseToolStripMenuItem
            // 
            EditBaseToolStripMenuItem.Name = "EditBaseToolStripMenuItem";
            EditBaseToolStripMenuItem.Size = new Size(161, 22);
            EditBaseToolStripMenuItem.Text = "Редагувати базу";
            EditBaseToolStripMenuItem.Click += EditBaseToolStripMenuItem_Click;
            // 
            // button10
            // 
            button10.Location = new Point(922, 115);
            button10.Name = "button10";
            button10.Size = new Size(27, 21);
            button10.TabIndex = 10;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 446);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Астролябія";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).EndInit();
            tabControl1.ResumeLayout(false);
            tabMain.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabDefaultSearch.ResumeLayout(false);
            tabDefaultSearch.PerformLayout();
            tabAdvancedSearch.ResumeLayout(false);
            tabAdvancedSearch.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabSearchByStar.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private BindingSource starBindingSource1;
        private TabControl tabControl1;
        private TabPage tabMain;
        private TabPage tabSearchByStar;
        private GroupBox groupBox1;
        private TabPage tabSearchByConstellation;
        private TabPage tabPage1;
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
        private TextBox textBoxLatitude;
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
        private TabPage tabPage4;
        private Button button9;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private DataGridView dataGridView1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem EditBaseToolStripMenuItem;
        private Label label4;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ApparentMagnitudeColumn;
        private DataGridViewTextBoxColumn DistanceLightYearsColumn;
        private DataGridViewTextBoxColumn RightAscensionColumn;
        private DataGridViewTextBoxColumn DeclinationColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private Button button10;
    }
}