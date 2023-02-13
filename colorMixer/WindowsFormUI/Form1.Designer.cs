
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
            this.mixBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.RadioButton();
            this.blueButton = new System.Windows.Forms.RadioButton();
            this.yellowButton = new System.Windows.Forms.RadioButton();
            this.redRadio = new System.Windows.Forms.RadioButton();
            this.blueRadio = new System.Windows.Forms.RadioButton();
            this.yellowRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mixBtn
            // 
            this.mixBtn.Location = new System.Drawing.Point(151, 337);
            this.mixBtn.Name = "mixBtn";
            this.mixBtn.Size = new System.Drawing.Size(135, 45);
            this.mixBtn.TabIndex = 0;
            this.mixBtn.Text = "Mix";
            this.mixBtn.UseVisualStyleBackColor = true;
            this.mixBtn.Click += new System.EventHandler(this.mixBtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // redButton
            // 
            this.redButton.AutoSize = true;
            this.redButton.Location = new System.Drawing.Point(6, 39);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(64, 24);
            this.redButton.TabIndex = 10;
            this.redButton.TabStop = true;
            this.redButton.Text = "Red";
            this.redButton.UseVisualStyleBackColor = true;
            // 
            // blueButton
            // 
            this.blueButton.AutoSize = true;
            this.blueButton.Location = new System.Drawing.Point(6, 85);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(66, 24);
            this.blueButton.TabIndex = 11;
            this.blueButton.TabStop = true;
            this.blueButton.Text = "Blue";
            this.blueButton.UseVisualStyleBackColor = true;
            // 
            // yellowButton
            // 
            this.yellowButton.AutoSize = true;
            this.yellowButton.Location = new System.Drawing.Point(6, 131);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(80, 24);
            this.yellowButton.TabIndex = 12;
            this.yellowButton.TabStop = true;
            this.yellowButton.Text = "Yellow";
            this.yellowButton.UseVisualStyleBackColor = true;
            // 
            // redRadio
            // 
            this.redRadio.AutoSize = true;
            this.redRadio.Location = new System.Drawing.Point(6, 39);
            this.redRadio.Name = "redRadio";
            this.redRadio.Size = new System.Drawing.Size(64, 24);
            this.redRadio.TabIndex = 13;
            this.redRadio.TabStop = true;
            this.redRadio.Text = "Red";
            this.redRadio.UseVisualStyleBackColor = true;
            // 
            // blueRadio
            // 
            this.blueRadio.AutoSize = true;
            this.blueRadio.Location = new System.Drawing.Point(6, 85);
            this.blueRadio.Name = "blueRadio";
            this.blueRadio.Size = new System.Drawing.Size(66, 24);
            this.blueRadio.TabIndex = 14;
            this.blueRadio.TabStop = true;
            this.blueRadio.Text = "Blue";
            this.blueRadio.UseVisualStyleBackColor = true;
            // 
            // yellowRadio
            // 
            this.yellowRadio.AutoSize = true;
            this.yellowRadio.Location = new System.Drawing.Point(6, 131);
            this.yellowRadio.Name = "yellowRadio";
            this.yellowRadio.Size = new System.Drawing.Size(80, 24);
            this.yellowRadio.TabIndex = 15;
            this.yellowRadio.TabStop = true;
            this.yellowRadio.Text = "Yellow";
            this.yellowRadio.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.redButton);
            this.groupBox1.Controls.Add(this.blueButton);
            this.groupBox1.Controls.Add(this.yellowButton);
            this.groupBox1.Location = new System.Drawing.Point(151, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 161);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.redRadio);
            this.groupBox2.Controls.Add(this.blueRadio);
            this.groupBox2.Controls.Add(this.yellowRadio);
            this.groupBox2.Location = new System.Drawing.Point(506, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 161);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Color 2";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(337, 338);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(122, 44);
            this.clearBtn.TabIndex = 18;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mixBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mixBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton redButton;
        private System.Windows.Forms.RadioButton blueButton;
        private System.Windows.Forms.RadioButton yellowButton;
        private System.Windows.Forms.RadioButton redRadio;
        private System.Windows.Forms.RadioButton blueRadio;
        private System.Windows.Forms.RadioButton yellowRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearBtn;
    }
}

