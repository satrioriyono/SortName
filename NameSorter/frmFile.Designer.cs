namespace NameSorter
{
    partial class frmFile
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
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.lst = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unsorted File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtFileName.Location = new System.Drawing.Point(41, 40);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(271, 20);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // cmdFind
            // 
            this.cmdFind.Location = new System.Drawing.Point(318, 38);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(75, 23);
            this.cmdFind.TabIndex = 2;
            this.cmdFind.Text = "...";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(318, 359);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmdClose.Size = new System.Drawing.Size(75, 23);
            this.cmdClose.TabIndex = 4;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // lst
            // 
            this.lst.FormattingEnabled = true;
            this.lst.Location = new System.Drawing.Point(41, 81);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(271, 251);
            this.lst.TabIndex = 5;
            // 
            // frmFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 394);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdFind);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort File Content";
            this.Load += new System.EventHandler(this.frmFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ListBox lst;
    }
}

