namespace POSV1
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.label1 = new System.Windows.Forms.Label();
            this.xLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.xExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 264);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "This Program was designed and coded by Rowdy Solution\'s Group aka Russell Patrick" +
                "";
            // 
            // xLogoPictureBox
            // 
            this.xLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("xLogoPictureBox.Image")));
            this.xLogoPictureBox.Location = new System.Drawing.Point(22, 19);
            this.xLogoPictureBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.xLogoPictureBox.Name = "xLogoPictureBox";
            this.xLogoPictureBox.Size = new System.Drawing.Size(301, 202);
            this.xLogoPictureBox.TabIndex = 1;
            this.xLogoPictureBox.TabStop = false;
            // 
            // xExitButton
            // 
            this.xExitButton.Location = new System.Drawing.Point(200, 339);
            this.xExitButton.Name = "xExitButton";
            this.xExitButton.Size = new System.Drawing.Size(92, 28);
            this.xExitButton.TabIndex = 2;
            this.xExitButton.Text = "Ok";
            this.xExitButton.UseVisualStyleBackColor = true;
            this.xExitButton.Click += new System.EventHandler(this.xExitButton_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 394);
            this.ControlBox = false;
            this.Controls.Add(this.xExitButton);
            this.Controls.Add(this.xLogoPictureBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.xLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox xLogoPictureBox;
        private System.Windows.Forms.Button xExitButton;
    }
}