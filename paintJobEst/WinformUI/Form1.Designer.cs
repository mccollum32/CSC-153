
namespace WinformUI
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
            this.sqWall = new System.Windows.Forms.TextBox();
            this.ppGal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.paintGall = new System.Windows.Forms.TextBox();
            this.laborHours = new System.Windows.Forms.TextBox();
            this.paintCost = new System.Windows.Forms.TextBox();
            this.laborCharge = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sqWall
            // 
            this.sqWall.Location = new System.Drawing.Point(113, 54);
            this.sqWall.Margin = new System.Windows.Forms.Padding(2);
            this.sqWall.Name = "sqWall";
            this.sqWall.Size = new System.Drawing.Size(165, 20);
            this.sqWall.TabIndex = 0;
            // 
            // ppGal
            // 
            this.ppGal.Location = new System.Drawing.Point(377, 54);
            this.ppGal.Margin = new System.Windows.Forms.Padding(2);
            this.ppGal.Name = "ppGal";
            this.ppGal.Size = new System.Drawing.Size(165, 20);
            this.ppGal.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sq. Feet Wallspace:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price per gallon:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(158, 271);
            this.enterButton.Margin = new System.Windows.Forms.Padding(2);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(84, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gallons of paint:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hours of labor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cost of paint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Labor charges:";
            // 
            // paintGall
            // 
            this.paintGall.Location = new System.Drawing.Point(210, 97);
            this.paintGall.Margin = new System.Windows.Forms.Padding(2);
            this.paintGall.Name = "paintGall";
            this.paintGall.ReadOnly = true;
            this.paintGall.Size = new System.Drawing.Size(68, 20);
            this.paintGall.TabIndex = 9;
            // 
            // laborHours
            // 
            this.laborHours.Location = new System.Drawing.Point(377, 101);
            this.laborHours.Margin = new System.Windows.Forms.Padding(2);
            this.laborHours.Name = "laborHours";
            this.laborHours.ReadOnly = true;
            this.laborHours.Size = new System.Drawing.Size(68, 20);
            this.laborHours.TabIndex = 10;
            // 
            // paintCost
            // 
            this.paintCost.Location = new System.Drawing.Point(210, 152);
            this.paintCost.Margin = new System.Windows.Forms.Padding(2);
            this.paintCost.Name = "paintCost";
            this.paintCost.ReadOnly = true;
            this.paintCost.Size = new System.Drawing.Size(68, 20);
            this.paintCost.TabIndex = 11;
            // 
            // laborCharge
            // 
            this.laborCharge.Location = new System.Drawing.Point(377, 156);
            this.laborCharge.Margin = new System.Windows.Forms.Padding(2);
            this.laborCharge.Name = "laborCharge";
            this.laborCharge.ReadOnly = true;
            this.laborCharge.Size = new System.Drawing.Size(68, 20);
            this.laborCharge.TabIndex = 12;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(328, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 13;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total";
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(192, 211);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(179, 20);
            this.totalBox.TabIndex = 15;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(247, 271);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 347);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.laborCharge);
            this.Controls.Add(this.paintCost);
            this.Controls.Add(this.laborHours);
            this.Controls.Add(this.paintGall);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ppGal);
            this.Controls.Add(this.sqWall);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sqWall;
        private System.Windows.Forms.TextBox ppGal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox paintGall;
        private System.Windows.Forms.TextBox laborHours;
        private System.Windows.Forms.TextBox paintCost;
        private System.Windows.Forms.TextBox laborCharge;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Button clearBtn;
    }
}

