namespace DepartmentUIApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeptCodeTextBox = new System.Windows.Forms.TextBox();
            this.DeptNaneTextBox = new System.Windows.Forms.TextBox();
            this.RegNoTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.EmaillTextBox = new System.Windows.Forms.TextBox();
            this.DeptSaveButton = new System.Windows.Forms.Button();
            this.StudentSaveButton = new System.Windows.Forms.Button();
            this.ShowDetailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DeptCode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DeptName";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "RegNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Emaill";
            // 
            // DeptCodeTextBox
            // 
            this.DeptCodeTextBox.Location = new System.Drawing.Point(97, 13);
            this.DeptCodeTextBox.Name = "DeptCodeTextBox";
            this.DeptCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeptCodeTextBox.TabIndex = 5;
            // 
            // DeptNaneTextBox
            // 
            this.DeptNaneTextBox.Location = new System.Drawing.Point(97, 45);
            this.DeptNaneTextBox.Name = "DeptNaneTextBox";
            this.DeptNaneTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeptNaneTextBox.TabIndex = 6;
            this.DeptNaneTextBox.TextChanged += new System.EventHandler(this.DeptNaneTextBox_TextChanged);
            // 
            // RegNoTextBox
            // 
            this.RegNoTextBox.Location = new System.Drawing.Point(97, 100);
            this.RegNoTextBox.Name = "RegNoTextBox";
            this.RegNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.RegNoTextBox.TabIndex = 7;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(97, 134);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // EmaillTextBox
            // 
            this.EmaillTextBox.Location = new System.Drawing.Point(97, 165);
            this.EmaillTextBox.Name = "EmaillTextBox";
            this.EmaillTextBox.Size = new System.Drawing.Size(100, 20);
            this.EmaillTextBox.TabIndex = 9;
            // 
            // DeptSaveButton
            // 
            this.DeptSaveButton.Location = new System.Drawing.Point(197, 71);
            this.DeptSaveButton.Name = "DeptSaveButton";
            this.DeptSaveButton.Size = new System.Drawing.Size(75, 23);
            this.DeptSaveButton.TabIndex = 10;
            this.DeptSaveButton.Text = "Save";
            this.DeptSaveButton.UseVisualStyleBackColor = true;
            this.DeptSaveButton.Click += new System.EventHandler(this.DeptSaveButton_Click);
            // 
            // StudentSaveButton
            // 
            this.StudentSaveButton.Location = new System.Drawing.Point(203, 165);
            this.StudentSaveButton.Name = "StudentSaveButton";
            this.StudentSaveButton.Size = new System.Drawing.Size(75, 23);
            this.StudentSaveButton.TabIndex = 11;
            this.StudentSaveButton.Text = "Save";
            this.StudentSaveButton.UseVisualStyleBackColor = true;
            this.StudentSaveButton.Click += new System.EventHandler(this.StudentSaveButton_Click);
            // 
            // ShowDetailsButton
            // 
            this.ShowDetailsButton.Location = new System.Drawing.Point(120, 217);
            this.ShowDetailsButton.Name = "ShowDetailsButton";
            this.ShowDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowDetailsButton.TabIndex = 12;
            this.ShowDetailsButton.Text = "Show";
            this.ShowDetailsButton.UseVisualStyleBackColor = true;
            this.ShowDetailsButton.Click += new System.EventHandler(this.ShowDetailsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ShowDetailsButton);
            this.Controls.Add(this.StudentSaveButton);
            this.Controls.Add(this.DeptSaveButton);
            this.Controls.Add(this.EmaillTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.RegNoTextBox);
            this.Controls.Add(this.DeptNaneTextBox);
            this.Controls.Add(this.DeptCodeTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DeptCodeTextBox;
        private System.Windows.Forms.TextBox DeptNaneTextBox;
        private System.Windows.Forms.TextBox RegNoTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox EmaillTextBox;
        private System.Windows.Forms.Button DeptSaveButton;
        private System.Windows.Forms.Button StudentSaveButton;
        private System.Windows.Forms.Button ShowDetailsButton;
    }
}

