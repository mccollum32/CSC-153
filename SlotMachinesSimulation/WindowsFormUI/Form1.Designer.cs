
namespace SlotMachines
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.amountEnt = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.amntEntBox = new System.Windows.Forms.TextBox();
            this.imagelist1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(269, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(525, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 250);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // amountEnt
            // 
            this.amountEnt.AutoSize = true;
            this.amountEnt.Location = new System.Drawing.Point(241, 288);
            this.amountEnt.Name = "amountEnt";
            this.amountEnt.Size = new System.Drawing.Size(143, 20);
            this.amountEnt.TabIndex = 3;
            this.amountEnt.Text = "Amount Entered: $";
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(269, 338);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(102, 48);
            this.enterBtn.TabIndex = 4;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(400, 339);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(102, 47);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // amntEntBox
            // 
            this.amntEntBox.Location = new System.Drawing.Point(403, 282);
            this.amntEntBox.Name = "amntEntBox";
            this.amntEntBox.Size = new System.Drawing.Size(102, 26);
            this.amntEntBox.TabIndex = 6;
            this.amntEntBox.TextChanged += new System.EventHandler(this.amntEntBox_TextChanged);
            // 
            // imagelist1
            // 
            this.imagelist1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist1.ImageStream")));
            this.imagelist1.TransparentColor = System.Drawing.Color.Transparent;
            this.imagelist1.Images.SetKeyName(0, "Apple.bmp");
            this.imagelist1.Images.SetKeyName(1, "Banana.bmp");
            this.imagelist1.Images.SetKeyName(2, "Cherries.bmp");
            this.imagelist1.Images.SetKeyName(3, "Grapes.bmp");
            this.imagelist1.Images.SetKeyName(4, "Lemon.bmp");
            this.imagelist1.Images.SetKeyName(5, "Lime.bmp");
            this.imagelist1.Images.SetKeyName(6, "Orange.bmp");
            this.imagelist1.Images.SetKeyName(7, "Pear.bmp");
            this.imagelist1.Images.SetKeyName(8, "Strawberry.bmp");
            this.imagelist1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 423);
            this.Controls.Add(this.amntEntBox);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.amountEnt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label amountEnt;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox amntEntBox;
        private System.Windows.Forms.ImageList imagelist1;
    }
}

