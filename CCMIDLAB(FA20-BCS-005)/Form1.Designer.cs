namespace CCMIDLAB_FA20_BCS_005_
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
            InputTextBox = new TextBox();
            ParseButton = new Button();
            ResultLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(232, 40);
            InputTextBox.Multiline = true;
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(304, 107);
            InputTextBox.TabIndex = 0;
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(321, 197);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 1;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ResultLabel.Location = new Point(304, 280);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(124, 41);
            ResultLabel.TabIndex = 2;
            ResultLabel.Text = "RESULT";
            // 
            // button1
            // 
            button1.Location = new Point(285, 380);
            button1.Name = "button1";
            button1.Size = new Size(143, 33);
            button1.TabIndex = 3;
            button1.Text = "Question_03";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ResultLabel);
            Controls.Add(ParseButton);
            Controls.Add(InputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button ParseButton;
        private Label ResultLabel;
        private Button button1;
    }
}