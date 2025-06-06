﻿
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            ConstellationColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            groupBox3 = new GroupBox();
            groupBox9 = new GroupBox();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            groupBox8 = new GroupBox();
            comboBox1 = new ComboBox();
            starBindingSource2 = new BindingSource(components);
            checkBox1 = new CheckBox();
            groupBox5 = new GroupBox();
            label1 = new Label();
            textBoxLatitude = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            groupBox4 = new GroupBox();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            ApplyAdvancedFilterButton = new Button();
            button4 = new Button();
            tabSearchByStar = new TabPage();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            starBindingSource = new BindingSource(components);
            button7 = new Button();
            button6 = new Button();
            groupBox7 = new GroupBox();
            listBox1 = new ListBox();
            groupBox6 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            EditBaseToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
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
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)starBindingSource2).BeginInit();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabSearchByStar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
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
            tabMain.Click += tabMain_Click;
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
            groupBox1.Font = new Font("Segoe UI", 9F);
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
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ApparentMagnitudeColumn, DistanceLightYearsColumn, RightAscensionColumn, DeclinationColumn, ConstellationColumn, DescriptionColumn });
            dataGridView1.DataSource = starBindingSource1;
            dataGridView1.Location = new Point(6, 18);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(1037, 455);
            dataGridView1.TabIndex = 2;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColumnName.DefaultCellStyle = dataGridViewCellStyle2;
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 64;
            // 
            // ApparentMagnitudeColumn
            // 
            ApparentMagnitudeColumn.DataPropertyName = "ApparentMagnitude";
            ApparentMagnitudeColumn.HeaderText = "ApparentMagnitude";
            ApparentMagnitudeColumn.Name = "ApparentMagnitudeColumn";
            ApparentMagnitudeColumn.ReadOnly = true;
            ApparentMagnitudeColumn.Width = 139;
            // 
            // DistanceLightYearsColumn
            // 
            DistanceLightYearsColumn.DataPropertyName = "Distance";
            DistanceLightYearsColumn.HeaderText = "DistanceLightYears";
            DistanceLightYearsColumn.Name = "DistanceLightYearsColumn";
            DistanceLightYearsColumn.ReadOnly = true;
            DistanceLightYearsColumn.Width = 131;
            // 
            // RightAscensionColumn
            // 
            RightAscensionColumn.DataPropertyName = "RightAscension";
            RightAscensionColumn.HeaderText = "RightAscension";
            RightAscensionColumn.Name = "RightAscensionColumn";
            RightAscensionColumn.ReadOnly = true;
            RightAscensionColumn.Width = 114;
            // 
            // DeclinationColumn
            // 
            DeclinationColumn.DataPropertyName = "Declination";
            DeclinationColumn.HeaderText = "Declination";
            DeclinationColumn.Name = "DeclinationColumn";
            DeclinationColumn.ReadOnly = true;
            DeclinationColumn.Width = 92;
            // 
            // ConstellationColumn
            // 
            ConstellationColumn.DataPropertyName = "Constellation";
            ConstellationColumn.HeaderText = "Constellation";
            ConstellationColumn.Name = "ConstellationColumn";
            ConstellationColumn.ReadOnly = true;
            ConstellationColumn.Width = 102;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.DataPropertyName = "Description";
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.ReadOnly = true;
            DescriptionColumn.Width = 92;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox9);
            groupBox3.Controls.Add(groupBox8);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(ApplyAdvancedFilterButton);
            groupBox3.Controls.Add(button4);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(386, 489);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Фільтри";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(buttonDelete);
            groupBox9.Controls.Add(buttonEdit);
            groupBox9.Controls.Add(buttonAdd);
            groupBox9.Location = new Point(6, 344);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(141, 129);
            groupBox9.TabIndex = 20;
            groupBox9.TabStop = false;
            groupBox9.Text = "Швидке редагування";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(6, 22);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(111, 29);
            buttonDelete.TabIndex = 19;
            buttonDelete.Text = "Видалити зірку";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(6, 92);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(111, 29);
            buttonEdit.TabIndex = 17;
            buttonEdit.Text = "Редагувати рядок";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(6, 57);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 29);
            buttonAdd.TabIndex = 18;
            buttonAdd.Text = "Додати зірку";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(comboBox1);
            groupBox8.Controls.Add(checkBox1);
            groupBox8.Location = new Point(198, 218);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(182, 56);
            groupBox8.TabIndex = 17;
            groupBox8.TabStop = false;
            groupBox8.Text = "Вибір сузір'я";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = starBindingSource2;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 22);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(131, 23);
            comboBox1.TabIndex = 15;
            // 
            // starBindingSource2
            // 
            starBindingSource2.DataSource = typeof(Astrolabe.models.Star);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(151, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 16;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(textBoxLatitude);
            groupBox5.Controls.Add(dateTimePicker1);
            groupBox5.Controls.Add(label5);
            groupBox5.Location = new Point(198, 120);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(182, 95);
            groupBox5.TabIndex = 14;
            groupBox5.TabStop = false;
            groupBox5.Text = "Видимість зірок";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 7;
            label1.Text = "Координати на небосхилі";
            toolTip1.SetToolTip(label1, "AOPJWDOAPDM");
            // 
            // textBoxLatitude
            // 
            textBoxLatitude.Location = new Point(6, 37);
            textBoxLatitude.Name = "textBoxLatitude";
            textBoxLatitude.Size = new Size(169, 23);
            textBoxLatitude.TabIndex = 6;
            toolTip1.SetToolTip(textBoxLatitude, "POKMPOS");
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(39, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(136, 23);
            dateTimePicker1.TabIndex = 11;
            dateTimePicker1.Value = new DateTime(2025, 6, 3, 0, 33, 29, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 69);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "date:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(button3);
            groupBox4.Controls.Add(button2);
            groupBox4.Controls.Add(button1);
            groupBox4.Location = new Point(6, 120);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(176, 167);
            groupBox4.TabIndex = 13;
            groupBox4.TabStop = false;
            groupBox4.Text = "Сортування";
            // 
            // button5
            // 
            button5.Location = new Point(6, 125);
            button5.Name = "button5";
            button5.Size = new Size(164, 29);
            button5.TabIndex = 7;
            button5.Text = "За відстанню";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 90);
            button3.Name = "button3";
            button3.Size = new Size(164, 29);
            button3.TabIndex = 6;
            button3.Text = "За сузірям";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(6, 55);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 5;
            button2.Text = "За назвою";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 22);
            button1.Name = "button1";
            button1.Size = new Size(164, 29);
            button1.TabIndex = 4;
            button1.Text = "За яксравістю";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 18);
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
            button4.Location = new Point(331, 18);
            button4.Name = "button4";
            button4.Size = new Size(49, 29);
            button4.TabIndex = 3;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabSearchByStar
            // 
            tabSearchByStar.Controls.Add(splitContainer2);
            tabSearchByStar.Location = new Point(4, 24);
            tabSearchByStar.Name = "tabSearchByStar";
            tabSearchByStar.Padding = new Padding(3);
            tabSearchByStar.Size = new Size(1463, 498);
            tabSearchByStar.TabIndex = 1;
            tabSearchByStar.Text = "Сузір’я";
            tabSearchByStar.UseVisualStyleBackColor = true;
            tabSearchByStar.Click += tabSearchByStar_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button7);
            splitContainer2.Panel2.Controls.Add(button6);
            splitContainer2.Panel2.Controls.Add(groupBox7);
            splitContainer2.Panel2.Controls.Add(groupBox6);
            splitContainer2.Size = new Size(1463, 498);
            splitContainer2.SplitterDistance = 1063;
            splitContainer2.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView2);
            groupBox2.Font = new Font("Segoe UI", 9F);
            groupBox2.Location = new Point(0, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1060, 496);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Зірки сузір'їв";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.DataSource = starBindingSource;
            dataGridView2.Location = new Point(8, 20);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.Size = new Size(1046, 466);
            dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "ApparentMagnitude";
            dataGridViewTextBoxColumn2.HeaderText = "ApparentMagnitude";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Distance";
            dataGridViewTextBoxColumn3.HeaderText = "DistanceLightYears";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "RightAscension";
            dataGridViewTextBoxColumn4.HeaderText = "RightAscension";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Declination";
            dataGridViewTextBoxColumn5.HeaderText = "Declination";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "Description";
            dataGridViewTextBoxColumn6.HeaderText = "Description";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            dataGridViewTextBoxColumn6.Width = 150;
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Astrolabe.models.Star);
            // 
            // button7
            // 
            button7.Location = new Point(337, 428);
            button7.Name = "button7";
            button7.Size = new Size(51, 29);
            button7.TabIndex = 18;
            button7.Text = "Reset";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(252, 463);
            button6.Name = "button6";
            button6.Size = new Size(136, 29);
            button6.TabIndex = 17;
            button6.Text = "Пошук";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(listBox1);
            groupBox7.Location = new Point(3, 6);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(387, 193);
            groupBox7.TabIndex = 16;
            groupBox7.TabStop = false;
            groupBox7.Text = "Назви сузір'їв";
            // 
            // listBox1
            // 
            listBox1.DataSource = starBindingSource2;
            listBox1.Font = new Font("Segoe UI", 9F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(6, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(375, 169);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label2);
            groupBox6.Controls.Add(textBox1);
            groupBox6.Controls.Add(dateTimePicker2);
            groupBox6.Controls.Add(label3);
            groupBox6.Location = new Point(208, 205);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(182, 95);
            groupBox6.TabIndex = 15;
            groupBox6.TabStop = false;
            groupBox6.Text = "Видимість сузір'їв";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 19);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 7;
            label2.Text = "Координати на небосхилі";
            toolTip1.SetToolTip(label2, "AOPJWDOAPDM");
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(169, 23);
            textBox1.TabIndex = 6;
            toolTip1.SetToolTip(textBox1, "POKMPOS");
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(39, 63);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(136, 23);
            dateTimePicker2.TabIndex = 11;
            dateTimePicker2.Value = new DateTime(2025, 6, 3, 0, 33, 29, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 69);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 12;
            label3.Text = "date:";
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
            fIleToolStripMenuItem.Size = new Size(48, 20);
            fIleToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(163, 22);
            openToolStripMenuItem.Text = "Відкрити файл...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(163, 22);
            saveAsToolStripMenuItem.Text = "Зберегти як...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EditBaseToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(79, 20);
            editToolStripMenuItem.Text = "Редагувати";
            // 
            // EditBaseToolStripMenuItem
            // 
            EditBaseToolStripMenuItem.Name = "EditBaseToolStripMenuItem";
            EditBaseToolStripMenuItem.Size = new Size(170, 22);
            EditBaseToolStripMenuItem.Text = "Редагувати базу...";
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
            groupBox9.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)starBindingSource2).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            tabSearchByStar.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
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
        private Button ApplyAdvancedFilterButton;
        private GroupBox groupBox2;
        private ListBox listBox1;
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
        private RichTextBox richTextBox1;
        private Button button4;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox textBoxLatitude;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private SplitContainer splitContainer2;
        private ToolTip toolTip1;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Button button2;
        private Button button5;
        private Button button3;
        private GroupBox groupBox6;
        private Label label2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private GroupBox groupBox7;
        private Button button6;
        private Button button7;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ApparentMagnitudeColumn;
        private DataGridViewTextBoxColumn DistanceLightYearsColumn;
        private DataGridViewTextBoxColumn RightAscensionColumn;
        private DataGridViewTextBoxColumn DeclinationColumn;
        private DataGridViewTextBoxColumn ConstellationColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
        private ComboBox comboBox1;
        private GroupBox groupBox8;
        private CheckBox checkBox1;
        private Button buttonEdit;
        private Button buttonAdd;
        private GroupBox groupBox9;
        private Button buttonDelete;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}