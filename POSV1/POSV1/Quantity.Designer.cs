namespace POSV1
{
    partial class Quantity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quantity));
            this.xNumListBox = new System.Windows.Forms.ListBox();
            this.xOkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xNumListBox
            // 
            this.xNumListBox.FormattingEnabled = true;
            this.xNumListBox.Location = new System.Drawing.Point(72, 65);
            this.xNumListBox.Name = "xNumListBox";
            this.xNumListBox.Size = new System.Drawing.Size(163, 108);
            this.xNumListBox.TabIndex = 0;
            // 
            // xOkButton
            // 
            this.xOkButton.Location = new System.Drawing.Point(177, 238);
            this.xOkButton.Name = "xOkButton";
            this.xOkButton.Size = new System.Drawing.Size(75, 23);
            this.xOkButton.TabIndex = 1;
            this.xOkButton.Text = "Ok";
            this.xOkButton.UseVisualStyleBackColor = true;
            this.xOkButton.Click += new System.EventHandler(this.xOkButton_Click);
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 286);
            this.ControlBox = false;
            this.Controls.Add(this.xOkButton);
            this.Controls.Add(this.xNumListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Quantity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quantity";
            this.Load += new System.EventHandler(this.Quantity_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox xNumListBox;
        private System.Windows.Forms.Button xOkButton;
    }
}