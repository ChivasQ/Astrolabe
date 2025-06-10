namespace Astrolabe.Forms
{
    partial class EditStarForm
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
            textBoxName = new TextBox();
            textBoxDescription = new TextBox();
            textBoxMagnitude = new TextBox();
            buttonSave = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxRA = new TextBox();
            label6 = new Label();
            textBoxDec = new TextBox();
            label7 = new Label();
            textBoxDistance = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(131, 38);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(180, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(131, 212);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(180, 54);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxMagnitude
            // 
            textBoxMagnitude.Location = new Point(131, 67);
            textBoxMagnitude.Name = "textBoxMagnitude";
            textBoxMagnitude.Size = new Size(180, 23);
            textBoxMagnitude.TabIndex = 2;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(232, 345);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(79, 32);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Назва";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Яскравість";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 212);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Опис";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 99);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 9;
            label5.Text = "Пряме сходження ";
            // 
            // textBoxRA
            // 
            textBoxRA.Location = new Point(131, 96);
            textBoxRA.Name = "textBoxRA";
            textBoxRA.Size = new Size(180, 23);
            textBoxRA.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 128);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 11;
            label6.Text = "Схилення";
            // 
            // textBoxDec
            // 
            textBoxDec.Location = new Point(131, 125);
            textBoxDec.Name = "textBoxDec";
            textBoxDec.Size = new Size(180, 23);
            textBoxDec.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 157);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 13;
            label7.Text = "Відстань";
            // 
            // textBoxDistance
            // 
            textBoxDistance.Location = new Point(131, 154);
            textBoxDistance.Name = "textBoxDistance";
            textBoxDistance.Size = new Size(180, 23);
            textBoxDistance.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 186);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 15;
            label1.Text = "Сузір'я";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.DisplayMember = "Name";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 183);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 23);
            comboBox1.TabIndex = 16;
            comboBox1.ValueMember = "Name";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // EditStarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 389);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(textBoxDistance);
            Controls.Add(label6);
            Controls.Add(textBoxDec);
            Controls.Add(label5);
            Controls.Add(textBoxRA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(textBoxMagnitude);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "EditStarForm";
            Text = "Редагувати зірку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxMagnitude;
        private Button buttonSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxRA;
        private Label label6;
        private TextBox textBoxDec;
        private Label label7;
        private TextBox textBoxDistance;
        private Label label1;
        private ComboBox comboBox1;
    }
}