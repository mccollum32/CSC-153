
namespace CarClass
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
            this.accBtn = new System.Windows.Forms.Button();
            this.brkBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.carBox = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // accBtn
            // 
            this.accBtn.Location = new System.Drawing.Point(12, 117);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(113, 51);
            this.accBtn.TabIndex = 0;
            this.accBtn.Text = "Accelerate";
            this.accBtn.UseVisualStyleBackColor = true;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // brkBtn
            // 
            this.brkBtn.Location = new System.Drawing.Point(131, 117);
            this.brkBtn.Name = "brkBtn";
            this.brkBtn.Size = new System.Drawing.Size(112, 50);
            this.brkBtn.TabIndex = 1;
            this.brkBtn.Text = "Brake";
            this.brkBtn.UseVisualStyleBackColor = true;
            this.brkBtn.Click += new System.EventHandler(this.brkBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(249, 119);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(112, 49);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // carBox
            // 
            this.carBox.Location = new System.Drawing.Point(13, 71);
            this.carBox.Name = "carBox";
            this.carBox.ReadOnly = true;
            this.carBox.Size = new System.Drawing.Size(465, 26);
            this.carBox.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(367, 121);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(111, 47);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Exit";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 222);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.carBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.brkBtn);
            this.Controls.Add(this.accBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accBtn;
        private System.Windows.Forms.Button brkBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox carBox;
        private System.Windows.Forms.Button closeBtn;
    }
}

