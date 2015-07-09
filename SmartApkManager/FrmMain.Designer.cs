namespace SmartApkManager
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddToDb = new System.Windows.Forms.Button();
            this.DirBrs = new System.Windows.Forms.FolderBrowserDialog();
            this.FlwLyoExplorer = new System.Windows.Forms.FlowLayoutPanel();
            this.TxBxPath = new System.Windows.Forms.TextBox();
            this.BtnBrowseApkDir = new System.Windows.Forms.Button();
            this.ChkBxRecurcive = new System.Windows.Forms.CheckBox();
            this.createNewBankToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewBankToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fILEToolStripMenuItem.Text = "&FILE";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.toolsToolStripMenuItem.Text = "&TOOLS";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.optionsToolStripMenuItem.Text = "Change WorkSpace";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // BtnAddToDb
            // 
            this.BtnAddToDb.Location = new System.Drawing.Point(555, 57);
            this.BtnAddToDb.Name = "BtnAddToDb";
            this.BtnAddToDb.Size = new System.Drawing.Size(100, 23);
            this.BtnAddToDb.TabIndex = 4;
            this.BtnAddToDb.Text = "Add To DataBase";
            this.BtnAddToDb.UseVisualStyleBackColor = true;
            this.BtnAddToDb.Click += new System.EventHandler(this.BtnAddToDb_Click);
            // 
            // FlwLyoExplorer
            // 
            this.FlwLyoExplorer.AutoScroll = true;
            this.FlwLyoExplorer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.FlwLyoExplorer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlwLyoExplorer.Location = new System.Drawing.Point(0, 57);
            this.FlwLyoExplorer.Name = "FlwLyoExplorer";
            this.FlwLyoExplorer.Size = new System.Drawing.Size(549, 407);
            this.FlwLyoExplorer.TabIndex = 5;
            // 
            // TxBxPath
            // 
            this.TxBxPath.Location = new System.Drawing.Point(0, 31);
            this.TxBxPath.Name = "TxBxPath";
            this.TxBxPath.Size = new System.Drawing.Size(549, 20);
            this.TxBxPath.TabIndex = 6;
            // 
            // BtnBrowseApkDir
            // 
            this.BtnBrowseApkDir.Location = new System.Drawing.Point(555, 31);
            this.BtnBrowseApkDir.Name = "BtnBrowseApkDir";
            this.BtnBrowseApkDir.Size = new System.Drawing.Size(27, 20);
            this.BtnBrowseApkDir.TabIndex = 7;
            this.BtnBrowseApkDir.Text = "...";
            this.BtnBrowseApkDir.UseVisualStyleBackColor = true;
            this.BtnBrowseApkDir.Click += new System.EventHandler(this.BtnBrowseApkDir_Click);
            // 
            // ChkBxRecurcive
            // 
            this.ChkBxRecurcive.AutoSize = true;
            this.ChkBxRecurcive.Location = new System.Drawing.Point(588, 34);
            this.ChkBxRecurcive.Name = "ChkBxRecurcive";
            this.ChkBxRecurcive.Size = new System.Drawing.Size(75, 17);
            this.ChkBxRecurcive.TabIndex = 8;
            this.ChkBxRecurcive.Text = "Recurcive";
            this.ChkBxRecurcive.UseVisualStyleBackColor = true;
            // 
            // createNewBankToolStripMenuItem
            // 
            this.createNewBankToolStripMenuItem.Name = "createNewBankToolStripMenuItem";
            this.createNewBankToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.createNewBankToolStripMenuItem.Text = "&Create new bank";
            this.createNewBankToolStripMenuItem.Click += new System.EventHandler(this.createNewBankToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(555, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Store";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 464);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAddToDb);
            this.Controls.Add(this.ChkBxRecurcive);
            this.Controls.Add(this.BtnBrowseApkDir);
            this.Controls.Add(this.TxBxPath);
            this.Controls.Add(this.FlwLyoExplorer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Smart APK Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.Button BtnAddToDb;
        private System.Windows.Forms.FolderBrowserDialog DirBrs;
        private System.Windows.Forms.FlowLayoutPanel FlwLyoExplorer;
        private System.Windows.Forms.TextBox TxBxPath;
        private System.Windows.Forms.Button BtnBrowseApkDir;
        private System.Windows.Forms.CheckBox ChkBxRecurcive;
        private System.Windows.Forms.ToolStripMenuItem createNewBankToolStripMenuItem;
        private System.Windows.Forms.Button button1;

    }
}

