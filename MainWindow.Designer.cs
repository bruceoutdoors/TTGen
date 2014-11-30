namespace TTGen
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.howArToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EqualityLbl = new System.Windows.Forms.Label();
            this.mainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TruthTableView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorMsgLbl = new System.Windows.Forms.Label();
            this.Input1 = new System.Windows.Forms.TextBox();
            this.Input2 = new System.Windows.Forms.TextBox();
            this.GenBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.mainLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howArToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // howArToolStripMenuItem
            // 
            this.howArToolStripMenuItem.Name = "howArToolStripMenuItem";
            this.howArToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.howArToolStripMenuItem.Text = "How Ar?";
            this.howArToolStripMenuItem.Click += new System.EventHandler(this.howArToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // EqualityLbl
            // 
            this.EqualityLbl.AutoSize = true;
            this.EqualityLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualityLbl.ForeColor = System.Drawing.Color.Green;
            this.EqualityLbl.Location = new System.Drawing.Point(3, 257);
            this.EqualityLbl.Name = "EqualityLbl";
            this.EqualityLbl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 5);
            this.EqualityLbl.Size = new System.Drawing.Size(378, 30);
            this.EqualityLbl.TabIndex = 7;
            this.EqualityLbl.Text = "Equality Label";
            this.EqualityLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // mainLayout
            // 
            this.mainLayout.ColumnCount = 1;
            this.mainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.Controls.Add(this.EqualityLbl, 0, 2);
            this.mainLayout.Controls.Add(this.TruthTableView, 0, 1);
            this.mainLayout.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.mainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayout.Location = new System.Drawing.Point(0, 24);
            this.mainLayout.Name = "mainLayout";
            this.mainLayout.RowCount = 3;
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.mainLayout.Size = new System.Drawing.Size(384, 287);
            this.mainLayout.TabIndex = 9;
            // 
            // TruthTableView
            // 
            this.TruthTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TruthTableView.FullRowSelect = true;
            this.TruthTableView.GridLines = true;
            this.TruthTableView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TruthTableView.HoverSelection = true;
            this.TruthTableView.Location = new System.Drawing.Point(10, 86);
            this.TruthTableView.Margin = new System.Windows.Forms.Padding(10, 6, 10, 3);
            this.TruthTableView.Name = "TruthTableView";
            this.TruthTableView.Size = new System.Drawing.Size(364, 168);
            this.TruthTableView.TabIndex = 9;
            this.TruthTableView.UseCompatibleStateImageBehavior = false;
            this.TruthTableView.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ErrorMsgLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Input1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Input2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.GenBtn, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(372, 74);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "#1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "#2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ErrorMsgLbl
            // 
            this.ErrorMsgLbl.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.ErrorMsgLbl, 3);
            this.ErrorMsgLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ErrorMsgLbl.ForeColor = System.Drawing.Color.Crimson;
            this.ErrorMsgLbl.Location = new System.Drawing.Point(3, 0);
            this.ErrorMsgLbl.Name = "ErrorMsgLbl";
            this.ErrorMsgLbl.Size = new System.Drawing.Size(99, 20);
            this.ErrorMsgLbl.TabIndex = 2;
            this.ErrorMsgLbl.Text = "Error Message Text";
            this.ErrorMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Input1
            // 
            this.Input1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input1.Location = new System.Drawing.Point(33, 23);
            this.Input1.Name = "Input1";
            this.Input1.Size = new System.Drawing.Size(251, 20);
            this.Input1.TabIndex = 4;
            this.Input1.TextChanged += new System.EventHandler(this.Input1_TextChanged);
            // 
            // Input2
            // 
            this.Input2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Input2.Enabled = false;
            this.Input2.Location = new System.Drawing.Point(33, 48);
            this.Input2.Name = "Input2";
            this.Input2.Size = new System.Drawing.Size(251, 20);
            this.Input2.TabIndex = 5;
            this.Input2.TextChanged += new System.EventHandler(this.Input2_TextChanged);
            // 
            // GenBtn
            // 
            this.GenBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenBtn.Location = new System.Drawing.Point(290, 23);
            this.GenBtn.Name = "GenBtn";
            this.tableLayoutPanel1.SetRowSpan(this.GenBtn, 2);
            this.GenBtn.Size = new System.Drawing.Size(79, 48);
            this.GenBtn.TabIndex = 6;
            this.GenBtn.Text = "Generate!";
            this.GenBtn.UseVisualStyleBackColor = true;
            this.GenBtn.Click += new System.EventHandler(this.GenBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 311);
            this.Controls.Add(this.mainLayout);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 350);
            this.Name = "MainWindow";
            this.Text = "Truth Table Generator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainLayout.ResumeLayout(false);
            this.mainLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem howArToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label EqualityLbl;
        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.ListView TruthTableView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorMsgLbl;
        private System.Windows.Forms.TextBox Input1;
        private System.Windows.Forms.TextBox Input2;
        private System.Windows.Forms.Button GenBtn;





    }
}

