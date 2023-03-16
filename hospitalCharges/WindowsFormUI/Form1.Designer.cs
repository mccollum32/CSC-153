
namespace WindowsFormUI
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
            this.calcBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.daysText = new System.Windows.Forms.TextBox();
            this.medCharge = new System.Windows.Forms.TextBox();
            this.surgChar = new System.Windows.Forms.TextBox();
            this.labFee = new System.Windows.Forms.TextBox();
            this.rehabCha = new System.Windows.Forms.TextBox();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Days spent in Hospital:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Medication fees:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surgical fees:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lab fees:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Physical rehab fees:";
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(39, 400);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(167, 63);
            this.calcBtn.TabIndex = 5;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(257, 401);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(167, 62);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(39, 502);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(385, 61);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // daysText
            // 
            this.daysText.Location = new System.Drawing.Point(257, 24);
            this.daysText.Name = "daysText";
            this.daysText.Size = new System.Drawing.Size(167, 26);
            this.daysText.TabIndex = 8;
            // 
            // medCharge
            // 
            this.medCharge.Location = new System.Drawing.Point(257, 85);
            this.medCharge.Name = "medCharge";
            this.medCharge.Size = new System.Drawing.Size(167, 26);
            this.medCharge.TabIndex = 9;
            // 
            // surgChar
            // 
            this.surgChar.Location = new System.Drawing.Point(257, 141);
            this.surgChar.Name = "surgChar";
            this.surgChar.Size = new System.Drawing.Size(167, 26);
            this.surgChar.TabIndex = 10;
            // 
            // labFee
            // 
            this.labFee.Location = new System.Drawing.Point(257, 206);
            this.labFee.Name = "labFee";
            this.labFee.Size = new System.Drawing.Size(167, 26);
            this.labFee.TabIndex = 11;
            // 
            // rehabCha
            // 
            this.rehabCha.Location = new System.Drawing.Point(257, 276);
            this.rehabCha.Name = "rehabCha";
            this.rehabCha.Size = new System.Drawing.Size(167, 26);
            this.rehabCha.TabIndex = 12;
            // 
            // totalBox
            // 
            this.totalBox.Location = new System.Drawing.Point(257, 343);
            this.totalBox.Name = "totalBox";
            this.totalBox.ReadOnly = true;
            this.totalBox.Size = new System.Drawing.Size(167, 26);
            this.totalBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.rehabCha);
            this.Controls.Add(this.labFee);
            this.Controls.Add(this.surgChar);
            this.Controls.Add(this.medCharge);
            this.Controls.Add(this.daysText);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.TextBox daysText;
        private System.Windows.Forms.TextBox medCharge;
        private System.Windows.Forms.TextBox surgChar;
        private System.Windows.Forms.TextBox labFee;
        private System.Windows.Forms.TextBox rehabCha;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.Label label6;
    }
}

