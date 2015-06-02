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
        private APK P_apk;
        public APK APK
        {
            set
            {
                if (value != null)
                {
                    PicBxIcon.Image = Image.FromStream(new MemoryStream(value.details.HiResIcon));
                    LblPackageName.Text = string.Format("{0} {1}", value.details.applicationLable, value.details.versionName);
                }
                else
                {
                    PicBxIcon.Image = Properties.Resources.android_Logo;
                    LblPackageName.Text = "";
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
            
        }
    }
}
