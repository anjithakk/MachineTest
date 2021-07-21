namespace MachineTest
{
    partial class frmPics
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
            this.pnlimg = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlimg
            // 
            this.pnlimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlimg.Location = new System.Drawing.Point(206, 53);
            this.pnlimg.Name = "pnlimg";
            this.pnlimg.Size = new System.Drawing.Size(753, 616);
            this.pnlimg.TabIndex = 0;
            // 
            // frmPics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1263, 744);
            this.Controls.Add(this.pnlimg);
            this.Name = "frmPics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Pic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlimg;
    }
}

