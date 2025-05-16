namespace Astrolabe.forms
{
    partial class AddStarForm
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
            buttonOK = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 66);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(88, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 186);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(125, 54);
            textBoxDescription.TabIndex = 1;
            // 
            // textBoxMagnitude
            // 
            textBoxMagnitude.Location = new Point(12, 95);
            textBoxMagnitude.Name = "textBoxMagnitude";
            textBoxMagnitude.Size = new Size(88, 23);
            textBoxMagnitude.TabIndex = 2;
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(12, 246);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(79, 32);
            buttonOK.TabIndex = 3;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // AddStarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 389);
            Controls.Add(buttonOK);
            Controls.Add(textBoxMagnitude);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxName);
            Name = "AddStarForm";
            Text = "AddStarForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private TextBox textBoxMagnitude;
        private Button buttonOK;
    }
}