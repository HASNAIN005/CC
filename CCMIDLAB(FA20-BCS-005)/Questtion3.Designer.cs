namespace CCMIDLAB_FA20_BCS_005_
{
    partial class Questtion3
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
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            registrationNumberTextBox = new TextBox();
            generateButton = new Button();
            passwordLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(177, 33);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(125, 27);
            firstNameTextBox.TabIndex = 0;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(504, 37);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(125, 27);
            lastNameTextBox.TabIndex = 1;
            // 
            // registrationNumberTextBox
            // 
            registrationNumberTextBox.Location = new Point(175, 93);
            registrationNumberTextBox.Name = "registrationNumberTextBox";
            registrationNumberTextBox.Size = new Size(125, 27);
            registrationNumberTextBox.TabIndex = 2;
            // 
            // generateButton
            // 
            generateButton.Location = new Point(175, 174);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(94, 29);
            generateButton.TabIndex = 3;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(154, 276);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(184, 41);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-6, 93);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 5;
            label1.Text = "Registration_No :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(353, 33);
            label2.Name = "label2";
            label2.Size = new Size(125, 28);
            label2.TabIndex = 6;
            label2.Text = "Last_Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 32);
            label3.Name = "label3";
            label3.Size = new Size(128, 28);
            label3.TabIndex = 7;
            label3.Text = "First_Name :";
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Questtion3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordLabel);
            Controls.Add(generateButton);
            Controls.Add(registrationNumberTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Name = "Questtion3";
            Text = "Questtion3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox registrationNumberTextBox;
        private Button generateButton;
        private Label passwordLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}