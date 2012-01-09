namespace POSV1
{
    partial class Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Help));
            this.xHelpButton = new System.Windows.Forms.Button();
            this.xExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // xHelpButton
            // 
            this.xHelpButton.Location = new System.Drawing.Point(290, 366);
            this.xHelpButton.Name = "xHelpButton";
            this.xHelpButton.Size = new System.Drawing.Size(75, 23);
            this.xHelpButton.TabIndex = 0;
            this.xHelpButton.Text = "Help";
            this.xHelpButton.UseVisualStyleBackColor = true;
            this.xHelpButton.Click += new System.EventHandler(this.xHelpButton_Click);
            // 
            // xExitButton
            // 
            this.xExitButton.Location = new System.Drawing.Point(106, 366);
            this.xExitButton.Name = "xExitButton";
            this.xExitButton.Size = new System.Drawing.Size(75, 23);
            this.xExitButton.TabIndex = 1;
            this.xExitButton.Text = "Ok";
            this.xExitButton.UseVisualStyleBackColor = true;
            this.xExitButton.Click += new System.EventHandler(this.xExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 259);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 434);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.xExitButton);
            this.Controls.Add(this.xHelpButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Help";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xHelpButton;
        private System.Windows.Forms.Button xExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}