namespace POSV1
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.xUnloadTimer = new System.Windows.Forms.Timer(this.components);
            this.xSplashPanel = new System.Windows.Forms.Panel();
            this.xAnimPictureBox = new System.Windows.Forms.PictureBox();
            this.xBkgndPanel = new System.Windows.Forms.Panel();
            this.xLoadTextLabel = new System.Windows.Forms.Label();
            this.xBkgndTitleLabel = new System.Windows.Forms.Panel();
            this.xLoadLabel = new System.Windows.Forms.Label();
            this.xTitleLabel = new System.Windows.Forms.Label();
            this.xLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.xAnimTimer = new System.Windows.Forms.Timer(this.components);
            this.xSplashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xAnimPictureBox)).BeginInit();
            this.xBkgndPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // xUnloadTimer
            // 
            this.xUnloadTimer.Interval = 10000;
            this.xUnloadTimer.Tick += new System.EventHandler(this.xUnloadTimer_Tick);
            // 
            // xSplashPanel
            // 
            this.xSplashPanel.Controls.Add(this.xAnimPictureBox);
            this.xSplashPanel.Controls.Add(this.xBkgndPanel);
            this.xSplashPanel.Controls.Add(this.xBkgndTitleLabel);
            this.xSplashPanel.Controls.Add(this.xLoadLabel);
            this.xSplashPanel.Controls.Add(this.xTitleLabel);
            this.xSplashPanel.Controls.Add(this.xLogoPictureBox);
            this.xSplashPanel.Location = new System.Drawing.Point(47, 88);
            this.xSplashPanel.Name = "xSplashPanel";
            this.xSplashPanel.Size = new System.Drawing.Size(799, 475);
            this.xSplashPanel.TabIndex = 0;
            this.xSplashPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.xSplashPanel_MouseDown);
            // 
            // xAnimPictureBox
            // 
            this.xAnimPictureBox.Image = global::POSV1.Properties.Resources.m_dancing;
            this.xAnimPictureBox.Location = new System.Drawing.Point(647, 355);
            this.xAnimPictureBox.Name = "xAnimPictureBox";
            this.xAnimPictureBox.Size = new System.Drawing.Size(100, 70);
            this.xAnimPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xAnimPictureBox.TabIndex = 1;
            this.xAnimPictureBox.TabStop = false;
            // 
            // xBkgndPanel
            // 
            this.xBkgndPanel.Controls.Add(this.xLoadTextLabel);
            this.xBkgndPanel.Location = new System.Drawing.Point(246, 355);
            this.xBkgndPanel.Name = "xBkgndPanel";
            this.xBkgndPanel.Size = new System.Drawing.Size(313, 56);
            this.xBkgndPanel.TabIndex = 7;
            // 
            // xLoadTextLabel
            // 
            this.xLoadTextLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLoadTextLabel.Location = new System.Drawing.Point(4, 4);
            this.xLoadTextLabel.Name = "xLoadTextLabel";
            this.xLoadTextLabel.Size = new System.Drawing.Size(306, 49);
            this.xLoadTextLabel.TabIndex = 0;
            this.xLoadTextLabel.Text = "Loading Useless Procedures";
            this.xLoadTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xBkgndTitleLabel
            // 
            this.xBkgndTitleLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.xBkgndTitleLabel.Location = new System.Drawing.Point(235, 329);
            this.xBkgndTitleLabel.Name = "xBkgndTitleLabel";
            this.xBkgndTitleLabel.Size = new System.Drawing.Size(334, 20);
            this.xBkgndTitleLabel.TabIndex = 6;
            // 
            // xLoadLabel
            // 
            this.xLoadLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xLoadLabel.Location = new System.Drawing.Point(233, 325);
            this.xLoadLabel.Name = "xLoadLabel";
            this.xLoadLabel.Size = new System.Drawing.Size(337, 100);
            this.xLoadLabel.TabIndex = 5;
            this.xLoadLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xTitleLabel
            // 
            this.xTitleLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xTitleLabel.Location = new System.Drawing.Point(367, 97);
            this.xTitleLabel.Name = "xTitleLabel";
            this.xTitleLabel.Size = new System.Drawing.Size(351, 139);
            this.xTitleLabel.TabIndex = 1;
            this.xTitleLabel.Text = "Molitude";
            // 
            // xLogoPictureBox
            // 
            this.xLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("xLogoPictureBox.Image")));
            this.xLogoPictureBox.Location = new System.Drawing.Point(32, 36);
            this.xLogoPictureBox.Name = "xLogoPictureBox";
            this.xLogoPictureBox.Size = new System.Drawing.Size(269, 200);
            this.xLogoPictureBox.TabIndex = 0;
            this.xLogoPictureBox.TabStop = false;
            // 
            // xAnimTimer
            // 
            this.xAnimTimer.Interval = 5000;
            this.xAnimTimer.Tick += new System.EventHandler(this.xAnimTimer_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 720);
            this.Controls.Add(this.xSplashPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplashScreen_MouseDown);
            this.xSplashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xAnimPictureBox)).EndInit();
            this.xBkgndPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer xUnloadTimer;
        private System.Windows.Forms.Panel xSplashPanel;
        private System.Windows.Forms.Panel xBkgndPanel;
        private System.Windows.Forms.Label xLoadTextLabel;
        private System.Windows.Forms.Panel xBkgndTitleLabel;
        private System.Windows.Forms.Label xLoadLabel;
        private System.Windows.Forms.Label xTitleLabel;
        private System.Windows.Forms.PictureBox xLogoPictureBox;
        private System.Windows.Forms.Timer xAnimTimer;
        private System.Windows.Forms.PictureBox xAnimPictureBox;
    }
}