
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            starBindingSource1 = new BindingSource(components);
            tabControl1 = new TabControl();
            tabMain = new TabPage();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ApparentMagnitudeColumn = new DataGridViewTextBoxColumn();
            DistanceLightYearsColumn = new DataGridViewTextBoxColumn();
            RightAscensionColumn = new DataGridViewTextBoxColumn();
            DeclinationColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            textBoxLongitude = new TextBox();
            label1 = new Label();
            textBoxLatitude = new TextBox();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            ApplyAdvancedFilterButton = new Button();
            button4 = new Button();
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
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            starBindingSource = new BindingSource(components);
            listBox1 = new ListBox();
            starBindingSource2 = new BindingSource(components);
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
            ((System.ComponentModel.ISupportInitialize)starBindingSource1).BeginInit();
            tabControl1.SuspendLayout();
            tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            tabSearchByStar.SuspendLayout();
            tabControl3.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource2).BeginInit();
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
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1471, 526);
            tabControl1.TabIndex = 4;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(splitContainer1);
            tabMain.Location = new Point(4, 24);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Padding(3);
            tabMain.Size = new Size(1463, 498);
            tabMain.TabIndex = 0;
            tabMain.Text = "Головна";
            tabMain.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox3);
            splitContainer1.Size = new Size(1463, 498);
            splitContainer1.SplitterDistance = 1063;
            splitContainer1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1057, 489);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "База зірок";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.ForeColor = SystemColors.AppWorkspace;
            label4.Location = new Point(265, 210);
            label4.Name = "label4";
            label4.Size = new Size(517, 90);
            label4.TabIndex = 6;
            label4.Text = "Відкрийте файл для перегляду\r\nабо заповніть нову у редакторі\r\n";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Control;
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
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.ShowEditingIcon = false;
            dataGridView1.Size = new Size(1037, 455);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 150;
            // 
            // ApparentMagnitudeColumn
            // 
            ApparentMagnitudeColumn.DataPropertyName = "ApparentMagnitude";
            ApparentMagnitudeColumn.HeaderText = "ApparentMagnitude";
            ApparentMagnitudeColumn.Name = "ApparentMagnitudeColumn";
            ApparentMagnitudeColumn.ReadOnly = true;
            ApparentMagnitudeColumn.Width = 150;
            // 
            // DistanceLightYearsColumn
            // 
            DistanceLightYearsColumn.DataPropertyName = "DistanceLightYears";
            DistanceLightYearsColumn.HeaderText = "DistanceLightYears";
            DistanceLightYearsColumn.Name = "DistanceLightYearsColumn";
            DistanceLightYearsColumn.ReadOnly = true;
            DistanceLightYearsColumn.Width = 150;
            // 
            // RightAscensionColumn
            // 
            RightAscensionColumn.DataPropertyName = "RightAscension";
            RightAscensionColumn.HeaderText = "RightAscension";
            RightAscensionColumn.Name = "RightAscensionColumn";
            RightAscensionColumn.ReadOnly = true;
            // 
            // DeclinationColumn
            // 
            DeclinationColumn.DataPropertyName = "Declination";
            DeclinationColumn.HeaderText = "Declination";
            DeclinationColumn.Name = "DeclinationColumn";
            DeclinationColumn.ReadOnly = true;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.DataPropertyName = "Description";
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            DescriptionColumn.Width = 364;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBoxLongitude);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(textBoxLatitude);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(ApplyAdvancedFilterButton);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(3, 7);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 485);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 229);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(244, 223);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2025, 6, 3, 0, 33, 29, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 192);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "lon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(211, 163);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 9;
            label2.Text = "lat:";
            // 
            // textBoxLongitude
            // 
            textBoxLongitude.Location = new Point(244, 189);
            textBoxLongitude.Name = "textBoxLongitude";
            textBoxLongitude.Size = new Size(136, 23);
            textBoxLongitude.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 142);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 7;
            label1.Text = "Координати на небосхилі";
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(244, 160);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(136, 23);
            textBoxLatitude.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(6, 257);
            button2.Name = "button2";
            button2.Size = new Size(136, 29);
            button2.TabIndex = 5;
            button2.Text = "Видимі зірки";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(6, 222);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 4;
            button1.Text = "Найяскравіші зірки";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(319, 29);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // ApplyAdvancedFilterButton
            // 
            ApplyAdvancedFilterButton.Location = new Point(244, 440);
            ApplyAdvancedFilterButton.Name = "ApplyAdvancedFilterButton";
            ApplyAdvancedFilterButton.Size = new Size(136, 29);
            ApplyAdvancedFilterButton.TabIndex = 1;
            ApplyAdvancedFilterButton.Text = "Пошук";
            ApplyAdvancedFilterButton.UseVisualStyleBackColor = true;
            ApplyAdvancedFilterButton.Click += buttonApplyAdvancedFilter_Click;
            // 
            // button4
            // 
            button4.Location = new Point(331, 22);
            button4.Name = "button4";
            button4.Size = new Size(49, 29);
            button4.TabIndex = 3;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabSearchByStar
            // 
            tabSearchByStar.Controls.Add(tabControl3);
            tabSearchByStar.Controls.Add(groupBox2);
            tabSearchByStar.Location = new Point(4, 24);
            tabSearchByStar.Name = "tabSearchByStar";
            tabSearchByStar.Padding = new Padding(3);
            tabSearchByStar.Size = new Size(1463, 498);
            tabSearchByStar.TabIndex = 1;
            tabSearchByStar.Text = "Сузір’я";
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
            tabControl3.Size = new Size(963, 170);
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
            tabPage2.Size = new Size(955, 142);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Звичайний пошук";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(506, 36);
            button5.Name = "button5";
            button5.Size = new Size(155, 24);
            button5.TabIndex = 2;
            button5.Text = "Фільтр видимі";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(506, 6);
            button6.Name = "button6";
            button6.Size = new Size(155, 24);
            button6.TabIndex = 1;
            button6.Text = "Фільтр наяскравіші";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(794, 107);
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
            tabPage3.Size = new Size(955, 142);
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
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(6, 6);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(963, 201);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Пошук за сузір'ями";
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.DataSource = starBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.Location = new Point(323, 17);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.Size = new Size(634, 175);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ApparentMagnitude";
            dataGridViewTextBoxColumn2.HeaderText = "ApparentMagnitude";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "DistanceLightYears";
            dataGridViewTextBoxColumn3.HeaderText = "DistanceLightYears";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "RightAscension";
            dataGridViewTextBoxColumn4.HeaderText = "RightAscension";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Declination";
            dataGridViewTextBoxColumn5.HeaderText = "Declination";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            dataGridViewTextBoxColumn6.HeaderText = "Description";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Astrolabe.models.Star);
            // 
            // listBox1
            // 
            listBox1.DataSource = starBindingSource2;
            listBox1.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 14;
            listBox1.Location = new Point(6, 20);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(311, 172);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // starBindingSource2
            // 
            starBindingSource2.DataSource = typeof(Astrolabe.models.Star);
            // 
            // tabSearchByConstellation
            // 
            tabSearchByConstellation.Location = new Point(4, 24);
            tabSearchByConstellation.Name = "tabSearchByConstellation";
            tabSearchByConstellation.Size = new Size(1463, 498);
            tabSearchByConstellation.TabIndex = 2;
            tabSearchByConstellation.Text = "Пошук сузір'їв";
            tabSearchByConstellation.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(1463, 498);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "Спостереження";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button9);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1463, 498);
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
            menuStrip1.Size = new Size(1471, 24);
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 554);
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
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            tabSearchByStar.ResumeLayout(false);
            tabControl3.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource2).EndInit();
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
        private Button ApplyAdvancedFilterButton;
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
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn constellationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apparentMagnitudeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn distanceLightYearsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rightAscensionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn declinationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource starBindingSource;
        private BindingSource starBindingSource2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private RichTextBox richTextBox1;
        private Button button4;
        private SplitContainer splitContainer1;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ApparentMagnitudeColumn;
        private DataGridViewTextBoxColumn DistanceLightYearsColumn;
        private DataGridViewTextBoxColumn RightAscensionColumn;
        private DataGridViewTextBoxColumn DeclinationColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private GroupBox groupBox3;
        private Button button2;
        private Button button1;
        private TextBox textBoxLatitude;
        private Label label3;
        private Label label2;
        private TextBox textBoxLongitude;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
    }
}