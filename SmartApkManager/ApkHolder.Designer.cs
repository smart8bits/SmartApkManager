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
            this.LblPackageName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicBxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBxIcon
            // 
            this.PicBxIcon.BackColor = System.Drawing.Color.White;
            this.PicBxIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // LblPackageName
            // 
            this.LblPackageName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LblPackageName.Location = new System.Drawing.Point(0, 103);
            this.LblPackageName.Name = "LblPackageName";
            this.LblPackageName.Size = new System.Drawing.Size(100, 47);
            this.LblPackageName.TabIndex = 1;
            this.LblPackageName.Text = "label1";
            // 
            // ApkHolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPackageName);
            this.Controls.Add(this.PicBxIcon);
            this.Name = "ApkHolder";
            this.Size = new System.Drawing.Size(100, 150);
            this.Resize += new System.EventHandler(this.ApkHolder_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.PicBxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBxIcon;
        private System.Windows.Forms.Label LblPackageName;
    }
}
