namespace LAB7_HASNAIN005
{
    partial class Form1
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
            CalculateButton = new Button();
            InputTextBox = new TextBox();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(244, 185);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(195, 51);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "CalculateButton";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(200, 28);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(289, 98);
            InputTextBox.TabIndex = 1;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ResultLabel.Location = new Point(287, 285);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(104, 41);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultLabel);
            Controls.Add(InputTextBox);
            Controls.Add(CalculateButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private TextBox InputTextBox;
        private Label ResultLabel;
    }
}