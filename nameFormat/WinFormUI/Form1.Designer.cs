
namespace WinFormUI
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
            this.firstName = new System.Windows.Forms.TextBox();
            this.outPut = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.nameTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.midName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "First Name:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(242, 95);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(274, 26);
            this.firstName.TabIndex = 1;
            // 
            // outPut
            // 
            this.outPut.Location = new System.Drawing.Point(186, 288);
            this.outPut.Name = "outPut";
            this.outPut.Size = new System.Drawing.Size(121, 30);
            this.outPut.TabIndex = 5;
            this.outPut.Text = "Show Output";
            this.outPut.UseVisualStyleBackColor = true;
            this.outPut.Click += new System.EventHandler(this.outPut_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(395, 288);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 30);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearName
            // 
            this.clearName.Location = new System.Drawing.Point(314, 288);
            this.clearName.Name = "clearName";
            this.clearName.Size = new System.Drawing.Size(75, 29);
            this.clearName.TabIndex = 6;
            this.clearName.Text = "Clear";
            this.clearName.UseVisualStyleBackColor = true;
            this.clearName.Click += new System.EventHandler(this.clearName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(242, 221);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(274, 26);
            this.lastName.TabIndex = 3;
            // 
            // nameTitle
            // 
            this.nameTitle.Location = new System.Drawing.Point(242, 45);
            this.nameTitle.Name = "nameTitle";
            this.nameTitle.Size = new System.Drawing.Size(121, 26);
            this.nameTitle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Preferred Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(131, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Middle Name:";
            // 
            // midName
            // 
            this.midName.Location = new System.Drawing.Point(242, 150);
            this.midName.Name = "midName";
            this.midName.Size = new System.Drawing.Size(274, 26);
            this.midName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 383);
            this.Controls.Add(this.midName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTitle);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearName);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outPut);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Name Formatter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Button outPut;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox nameTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox midName;
    }
}

