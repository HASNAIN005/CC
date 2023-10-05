namespace LAB6_HASNAIN005
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
            calculateFirstSetButton = new Button();
            grammarInputTextBox = new TextBox();
            firstSetsTextBox = new TextBox();
            SuspendLayout();
            // 
            // calculateFirstSetButton
            // 
            calculateFirstSetButton.Location = new Point(318, 204);
            calculateFirstSetButton.Name = "calculateFirstSetButton";
            calculateFirstSetButton.Size = new Size(165, 40);
            calculateFirstSetButton.TabIndex = 0;
            calculateFirstSetButton.Text = "calculateFirstSet";
            calculateFirstSetButton.UseVisualStyleBackColor = true;
            calculateFirstSetButton.Click += calculateFirstSetButton_Click;
            // 
            // grammarInputTextBox
            // 
            grammarInputTextBox.Location = new Point(131, 27);
            grammarInputTextBox.Multiline = true;
            grammarInputTextBox.Name = "grammarInputTextBox";
            grammarInputTextBox.Size = new Size(553, 146);
            grammarInputTextBox.TabIndex = 1;
            // 
            // firstSetsTextBox
            // 
            firstSetsTextBox.Location = new Point(131, 277);
            firstSetsTextBox.Multiline = true;
            firstSetsTextBox.Name = "firstSetsTextBox";
            firstSetsTextBox.Size = new Size(553, 140);
            firstSetsTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(firstSetsTextBox);
            Controls.Add(grammarInputTextBox);
            Controls.Add(calculateFirstSetButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateFirstSetButton;
        private TextBox grammarInputTextBox;
        private TextBox firstSetsTextBox;
    }
}