namespace MidtermNS2._1
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.walkBtn = new System.Windows.Forms.Button();
            this.jumpBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.walkimg = new System.Windows.Forms.PictureBox();
            this.jumpimg = new System.Windows.Forms.PictureBox();
            this.repeatBox = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.walkimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpimg)).BeginInit();
            this.SuspendLayout();
            // 
            // walkBtn
            // 
            this.walkBtn.Location = new System.Drawing.Point(73, 257);
            this.walkBtn.Name = "walkBtn";
            this.walkBtn.Size = new System.Drawing.Size(75, 23);
            this.walkBtn.TabIndex = 0;
            this.walkBtn.Text = "Walk";
            this.walkBtn.UseVisualStyleBackColor = true;
            this.walkBtn.Click += new System.EventHandler(this.walkBtn_Click);
            // 
            // jumpBtn
            // 
            this.jumpBtn.Location = new System.Drawing.Point(180, 257);
            this.jumpBtn.Name = "jumpBtn";
            this.jumpBtn.Size = new System.Drawing.Size(75, 23);
            this.jumpBtn.TabIndex = 1;
            this.jumpBtn.Text = "Jump";
            this.jumpBtn.UseVisualStyleBackColor = true;
            this.jumpBtn.Click += new System.EventHandler(this.jumpBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(326, 88);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.Location = new System.Drawing.Point(326, 153);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(75, 23);
            this.hideBtn.TabIndex = 3;
            this.hideBtn.Text = "Hide";
            this.hideBtn.UseVisualStyleBackColor = true;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // walkimg
            // 
            this.walkimg.Image = ((System.Drawing.Image)(resources.GetObject("walkimg.Image")));
            this.walkimg.Location = new System.Drawing.Point(21, 12);
            this.walkimg.Name = "walkimg";
            this.walkimg.Size = new System.Drawing.Size(287, 239);
            this.walkimg.TabIndex = 5;
            this.walkimg.TabStop = false;
            // 
            // jumpimg
            // 
            this.jumpimg.Image = ((System.Drawing.Image)(resources.GetObject("jumpimg.Image")));
            this.jumpimg.Location = new System.Drawing.Point(21, 12);
            this.jumpimg.Name = "jumpimg";
            this.jumpimg.Size = new System.Drawing.Size(287, 239);
            this.jumpimg.TabIndex = 6;
            this.jumpimg.TabStop = false;
            // 
            // repeatBox
            // 
            this.repeatBox.AutoSize = true;
            this.repeatBox.Location = new System.Drawing.Point(141, 286);
            this.repeatBox.Name = "repeatBox";
            this.repeatBox.Size = new System.Drawing.Size(46, 17);
            this.repeatBox.TabIndex = 7;
            this.repeatBox.Text = "Run";
            this.repeatBox.UseVisualStyleBackColor = true;
            this.repeatBox.CheckedChanged += new System.EventHandler(this.repeatBox_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 321);
            this.Controls.Add(this.repeatBox);
            this.Controls.Add(this.jumpimg);
            this.Controls.Add(this.walkimg);
            this.Controls.Add(this.hideBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.jumpBtn);
            this.Controls.Add(this.walkBtn);
            this.Name = "mainWindow";
            this.Text = "Windows Form Methods";
            ((System.ComponentModel.ISupportInitialize)(this.walkimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jumpimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button walkBtn;
        private System.Windows.Forms.Button jumpBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.PictureBox walkimg;
        private System.Windows.Forms.PictureBox jumpimg;
        private System.Windows.Forms.CheckBox repeatBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

