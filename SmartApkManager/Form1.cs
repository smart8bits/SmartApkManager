using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartApkManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            apkHolder1.APK = new APK(@"C:\Users\smart8\Desktop\app\com.android.chrome-2\base.apk");
        }

        private void apkHolder1_Click(object sender, EventArgs e)
        {
            button1.Text = "done!";
        }
    }
}
