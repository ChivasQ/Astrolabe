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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            starBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            ColumnName = new DataGridViewTextBoxColumn();
            ApparentMagnitudeColumn = new DataGridViewTextBoxColumn();
            DistanceLightYearsColumn = new DataGridViewTextBoxColumn();
            RightAscensionColumn = new DataGridViewTextBoxColumn();
            DeclinationColumn = new DataGridViewTextBoxColumn();
            ConstellationColumn = new DataGridViewTextBoxColumn();
            DescriptionColumn = new DataGridViewTextBoxColumn();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)starBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // starBindingSource
            // 
            starBindingSource.DataSource = typeof(Astrolabe.models.Star);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnName, ApparentMagnitudeColumn, DistanceLightYearsColumn, RightAscensionColumn, DeclinationColumn, ConstellationColumn, DescriptionColumn });
            dataGridView1.DataSource = starBindingSource;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1418, 498);
            dataGridView1.TabIndex = 3;
            // 
            // ColumnName
            // 
            ColumnName.DataPropertyName = "Name";
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ColumnName.DefaultCellStyle = dataGridViewCellStyle3;
            ColumnName.HeaderText = "Name";
            ColumnName.Name = "ColumnName";
            ColumnName.Width = 64;
            // 
            // ApparentMagnitudeColumn
            // 
            ApparentMagnitudeColumn.DataPropertyName = "ApparentMagnitude";
            ApparentMagnitudeColumn.HeaderText = "ApparentMagnitude";
            ApparentMagnitudeColumn.Name = "ApparentMagnitudeColumn";
            ApparentMagnitudeColumn.Width = 139;
            // 
            // DistanceLightYearsColumn
            // 
            DistanceLightYearsColumn.DataPropertyName = "DistanceLightYears";
            DistanceLightYearsColumn.HeaderText = "DistanceLightYears";
            DistanceLightYearsColumn.Name = "DistanceLightYearsColumn";
            DistanceLightYearsColumn.Width = 131;
            // 
            // RightAscensionColumn
            // 
            RightAscensionColumn.DataPropertyName = "RightAscension";
            RightAscensionColumn.HeaderText = "RightAscension";
            RightAscensionColumn.Name = "RightAscensionColumn";
            RightAscensionColumn.Width = 114;
            // 
            // DeclinationColumn
            // 
            DeclinationColumn.DataPropertyName = "Declination";
            DeclinationColumn.HeaderText = "Declination";
            DeclinationColumn.Name = "DeclinationColumn";
            DeclinationColumn.Width = 92;
            // 
            // ConstellationColumn
            // 
            ConstellationColumn.DataPropertyName = "Constellation";
            ConstellationColumn.HeaderText = "Constellation";
            ConstellationColumn.Name = "ConstellationColumn";
            ConstellationColumn.Width = 102;
            // 
            // DescriptionColumn
            // 
            DescriptionColumn.DataPropertyName = "Description";
            DescriptionColumn.HeaderText = "Description";
            DescriptionColumn.Name = "DescriptionColumn";
            DescriptionColumn.Width = 92;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 516);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(372, 55);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(390, 516);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 5;
            button1.Text = "Apply";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(483, 537);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(51, 34);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // DataEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1442, 583);
            Controls.Add(buttonReset);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(dataGridView1);
            Name = "DataEditorForm";
            Text = "A";
            Load += DataEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)starBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource starBindingSource;
        private DataGridView dataGridView1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button buttonReset;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ApparentMagnitudeColumn;
        private DataGridViewTextBoxColumn DistanceLightYearsColumn;
        private DataGridViewTextBoxColumn RightAscensionColumn;
        private DataGridViewTextBoxColumn DeclinationColumn;
        private DataGridViewTextBoxColumn ConstellationColumn;
        private DataGridViewTextBoxColumn DescriptionColumn;
    }
}