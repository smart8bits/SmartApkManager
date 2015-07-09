using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartApkManager
{
    public partial class ApkHolder : UserControl
    {
        public ApkHolder()
        {
            InitializeComponent();
        }
        public bool selected = false;
        private APK P_apk;
        public APK APK
        {
            set
            {
                if (value != null)
                {
                    try
                    {
                        if (value.details.HiResIcon != null)
                            PicBxIcon.Image = Image.FromStream(new MemoryStream(value.details.HiResIcon));
                        else if (value.details.icon != null)
                            PicBxIcon.Image = Image.FromStream(new MemoryStream(value.details.icon));
                    }
                    catch
                    {
                        //MessageBox.Show(value.details.applicationLabel);
                    }
                    LblPackageName.Text = value.details.applicationLabel;
                    LblVersionName.Text = value.details.versionName;
                    P_apk = value;
                }
                else
                {
                    PicBxIcon.Image = Properties.Resources.android_Logo;
                    LblPackageName.Text = "";
                    LblVersionName.Text = "";
                }
            }
            get
            {
                return P_apk;
            }
        }
        

        private void ApkHolder_Resize(object sender, EventArgs e)
        {
            int PicBxIconSize = Math.Min((int)(0.7 * this.Height), this.Height);
            PicBxIcon.Size = new Size(PicBxIconSize, PicBxIconSize);
        }

        private void PicBxIcon_Click(object sender, EventArgs e)
        {
            ApkHolder_Click(this, null);
        }

        private void LblPackageName_Click(object sender, EventArgs e)
        {
            ApkHolder_Click(this, null);
        }

        private void LblVersionName_Click(object sender, EventArgs e)
        {
            ApkHolder_Click(this, null);
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            ApkHolder_Click(this, null);
        }
    
        private void ApkHolder_Click(object sender, EventArgs e)
        {
            if(!selected)
            {
                selected = true;
                this.BackColor = Color.SkyBlue;
                PicBxIcon.BackColor = Color.SkyBlue;
                this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                selected = false;
                this.BackColor = this.Parent.BackColor;
                PicBxIcon.BackColor = this.Parent.BackColor;
                this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
    }
}
