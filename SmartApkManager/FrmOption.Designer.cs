namespace SmartApkManager
{
    partial class FrmOptions
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
            this.LblWorkSpace = new System.Windows.Forms.Label();
            this.TxBxWorkSpacePath = new System.Windows.Forms.TextBox();
            this.BtnBrowse = new System.Windows.Forms.Button();
            this.GrpBxWorkSpace = new System.Windows.Forms.GroupBox();
            this.DirBrsWorkSpace = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnOk = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.GrpBxWorkSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblWorkSpace
            // 
            this.LblWorkSpace.AutoSize = true;
            this.LblWorkSpace.Location = new System.Drawing.Point(6, 21);
            this.LblWorkSpace.Name = "LblWorkSpace";
            this.LblWorkSpace.Size = new System.Drawing.Size(67, 13);
            this.LblWorkSpace.TabIndex = 0;
            this.LblWorkSpace.Text = "WorkSpace:";
            // 
            // TxBxWorkSpacePath
            // 
            this.TxBxWorkSpacePath.Location = new System.Drawing.Point(79, 18);
            this.TxBxWorkSpacePath.Name = "TxBxWorkSpacePath";
            this.TxBxWorkSpacePath.Size = new System.Drawing.Size(249, 20);
            this.TxBxWorkSpacePath.TabIndex = 1;
            // 
            // BtnBrowse
            // 
            this.BtnBrowse.Location = new System.Drawing.Point(334, 18);
            this.BtnBrowse.Name = "BtnBrowse";
            this.BtnBrowse.Size = new System.Drawing.Size(28, 20);
            this.BtnBrowse.TabIndex = 2;
            this.BtnBrowse.Text = "...";
            this.BtnBrowse.UseVisualStyleBackColor = true;
            this.BtnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // GrpBxWorkSpace
            // 
            this.GrpBxWorkSpace.Controls.Add(this.LblWorkSpace);
            this.GrpBxWorkSpace.Controls.Add(this.BtnBrowse);
            this.GrpBxWorkSpace.Controls.Add(this.TxBxWorkSpacePath);
            this.GrpBxWorkSpace.Location = new System.Drawing.Point(12, 28);
            this.GrpBxWorkSpace.Name = "GrpBxWorkSpace";
            this.GrpBxWorkSpace.Size = new System.Drawing.Size(368, 49);
            this.GrpBxWorkSpace.TabIndex = 3;
            this.GrpBxWorkSpace.TabStop = false;
            this.GrpBxWorkSpace.Text = "WorkSpace";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(224, 97);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "&Ok";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(305, 97);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "&Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 135);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.GrpBxWorkSpace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmOptions";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            this.GrpBxWorkSpace.ResumeLayout(false);
            this.GrpBxWorkSpace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblWorkSpace;
        private System.Windows.Forms.TextBox TxBxWorkSpacePath;
        private System.Windows.Forms.Button BtnBrowse;
        private System.Windows.Forms.GroupBox GrpBxWorkSpace;
        private System.Windows.Forms.FolderBrowserDialog DirBrsWorkSpace;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Button BtnCancel;
    }
}