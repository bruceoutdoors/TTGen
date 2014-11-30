namespace TTGen
{
    partial class AboutDialog
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
            if (disposing && (components != null)) {
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
            this.AboutTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AboutTxt
            // 
            this.AboutTxt.AutoSize = true;
            this.AboutTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTxt.Location = new System.Drawing.Point(0, 0);
            this.AboutTxt.Margin = new System.Windows.Forms.Padding(10);
            this.AboutTxt.Name = "AboutTxt";
            this.AboutTxt.Padding = new System.Windows.Forms.Padding(15);
            this.AboutTxt.Size = new System.Drawing.Size(232, 46);
            this.AboutTxt.TabIndex = 0;
            this.AboutTxt.Text = "About text (set programmicatally)";
            // 
            // AboutDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.AboutTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AboutDialog";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AboutTxt;
    }
}