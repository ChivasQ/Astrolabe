namespace Astrolabe.Forms
{
    partial class EditConstellationForm
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
            buttonSave = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(131, 15);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(180, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(131, 44);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(180, 54);
            textBoxDescription.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(232, 104);
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
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Назва";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 44);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Опис";
            label4.Click += label4_Click;
            // 
            // EditConstellationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 146);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(buttonSave);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "EditConstellationForm";
            Text = "Редагувати зірку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Button buttonSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label2;
        private Label label4;
    }
}