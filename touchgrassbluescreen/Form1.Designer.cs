namespace touchgrassbluescreen
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
            this.components = new System.ComponentModel.Container();
            this.sadface = new System.Windows.Forms.Label();
            this.outsidetext = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.Label();
            this.moreinfo = new System.Windows.Forms.Label();
            this.call = new System.Windows.Forms.Label();
            this.stopcode = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sadface
            // 
            this.sadface.AutoSize = true;
            this.sadface.BackColor = System.Drawing.Color.Transparent;
            this.sadface.Font = new System.Drawing.Font("Segoe UI", 159F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sadface.ForeColor = System.Drawing.Color.White;
            this.sadface.Location = new System.Drawing.Point(153, 113);
            this.sadface.Name = "sadface";
            this.sadface.Size = new System.Drawing.Size(228, 281);
            this.sadface.TabIndex = 0;
            this.sadface.Text = ":(";
            // 
            // outsidetext
            // 
            this.outsidetext.AutoSize = true;
            this.outsidetext.BackColor = System.Drawing.Color.Transparent;
            this.outsidetext.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outsidetext.ForeColor = System.Drawing.Color.White;
            this.outsidetext.Location = new System.Drawing.Point(198, 394);
            this.outsidetext.Name = "outsidetext";
            this.outsidetext.Size = new System.Drawing.Size(979, 156);
            this.outsidetext.TabIndex = 1;
            this.outsidetext.Text = "You\'ve been on your PC for too long and you need a\r\nlife. We\'re collecting some i" +
    "nfo to find the nearest patch\r\nof grass; we\'ll restart for you";
            // 
            // complete
            // 
            this.complete.AutoSize = true;
            this.complete.BackColor = System.Drawing.Color.Transparent;
            this.complete.Font = new System.Drawing.Font("Segoe UI", 29F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.complete.ForeColor = System.Drawing.Color.White;
            this.complete.Location = new System.Drawing.Point(199, 603);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(246, 52);
            this.complete.TabIndex = 2;
            this.complete.Text = "0% complete";
            // 
            // moreinfo
            // 
            this.moreinfo.AutoSize = true;
            this.moreinfo.BackColor = System.Drawing.Color.Transparent;
            this.moreinfo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moreinfo.ForeColor = System.Drawing.Color.Transparent;
            this.moreinfo.Location = new System.Drawing.Point(333, 703);
            this.moreinfo.Name = "moreinfo";
            this.moreinfo.Size = new System.Drawing.Size(527, 30);
            this.moreinfo.TabIndex = 3;
            this.moreinfo.Text = "For more information about life, look out the window";
            // 
            // call
            // 
            this.call.AutoSize = true;
            this.call.BackColor = System.Drawing.Color.Transparent;
            this.call.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.call.ForeColor = System.Drawing.Color.White;
            this.call.Location = new System.Drawing.Point(338, 763);
            this.call.Name = "call";
            this.call.Size = new System.Drawing.Size(337, 21);
            this.call.TabIndex = 4;
            this.call.Text = "If you call a support person, give them this info:";
            // 
            // stopcode
            // 
            this.stopcode.AutoSize = true;
            this.stopcode.BackColor = System.Drawing.Color.Transparent;
            this.stopcode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopcode.ForeColor = System.Drawing.Color.White;
            this.stopcode.Location = new System.Drawing.Point(338, 797);
            this.stopcode.Name = "stopcode";
            this.stopcode.Size = new System.Drawing.Size(118, 21);
            this.stopcode.TabIndex = 5;
            this.stopcode.Text = "Stop code: RNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::touchgrassbluescreen.Properties.Resources.QR2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(207, 703);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 115);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1363;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(147)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stopcode);
            this.Controls.Add(this.call);
            this.Controls.Add(this.moreinfo);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.outsidetext);
            this.Controls.Add(this.sadface);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label sadface;
        private Label outsidetext;
        private Label complete;
        private Label moreinfo;
        private Label call;
        private Label stopcode;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}