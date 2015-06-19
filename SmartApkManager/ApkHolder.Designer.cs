namespace SmartApkManager
{
    partial class ApkHolder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBxIcon = new System.Windows.Forms.PictureBox();
            this.LblVersionName = new System.Windows.Forms.Label();
            this.LblPackageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxIcon
            // 
            this.PicBxIcon.BackColor = System.Drawing.Color.White;
            this.PicBxIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicBxIcon.Image = global::SmartApkManager.Properties.Resources.android_Logo;
            this.PicBxIcon.Location = new System.Drawing.Point(0, 0);
            this.PicBxIcon.Name = "PicBxIcon";
            this.PicBxIcon.Size = new System.Drawing.Size(100, 100);
            this.PicBxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBxIcon.TabIndex = 0;
            this.PicBxIcon.TabStop = false;
            this.PicBxIcon.Click += new System.EventHandler(this.PicBxIcon_Click);
            // 
            // LblVersionName
            // 
            this.LblVersionName.AutoEllipsis = true;
            this.LblVersionName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblVersionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblVersionName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblVersionName.Location = new System.Drawing.Point(0, 113);
            this.LblVersionName.Name = "LblVersionName";
            this.LblVersionName.Size = new System.Drawing.Size(100, 16);
            this.LblVersionName.TabIndex = 1;
            this.LblVersionName.Text = "label";
            this.LblVersionName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblPackageName
            // 
            this.LblPackageName.AutoEllipsis = true;
            this.LblPackageName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPackageName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LblPackageName.Location = new System.Drawing.Point(0, 100);
            this.LblPackageName.Name = "LblPackageName";
            this.LblPackageName.Size = new System.Drawing.Size(100, 13);
            this.LblPackageName.TabIndex = 2;
            this.LblPackageName.Text = "label";
            this.LblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ApkHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPackageName);
            this.Controls.Add(this.LblVersionName);
            this.Controls.Add(this.PicBxIcon);
            this.Name = "ApkHolder";
            this.Size = new System.Drawing.Size(100, 129);
            this.Resize += new System.EventHandler(this.ApkHolder_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxIcon;
        private System.Windows.Forms.Label LblVersionName;
        private System.Windows.Forms.Label LblPackageName;
    }
}
