using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartApkManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
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

        private void BtnAddApk_Click(object sender, EventArgs e)
        {
            SqlConnection DbConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\smart8\Documents\GitHub\SmartApkManager\SmartApkManager\Database1.mdf;Integrated Security=True"); 
            APK apk = new APK(@"C:\Users\smart8\Desktop\app\com.android.chrome-2\base.apk");
            using (DbConnection)
            {
                DbConnection.Open();
                SqlCommand InsertApk = new SqlCommand("ProcInsertApk", DbConnection);
                InsertApk.CommandType = CommandType.StoredProcedure;
                //@packageName = 'test' , @ApplicationLabel = 'test', @versionCode = 'test',
                //@filePath = 'test', @versionName = 'test', @icon =null;
                InsertApk.Parameters.Add(new SqlParameter("@packageName", apk.details.packageName));
                InsertApk.Parameters.Add(new SqlParameter("@ApplicationLabel", apk.details.applicationLabel));
                InsertApk.Parameters.Add(new SqlParameter("@versionCode", apk.details.versionCode));
                InsertApk.Parameters.Add(new SqlParameter("@filePath", apk.details.filePath));
                InsertApk.Parameters.Add(new SqlParameter("@versionName", apk.details.versionName));
                InsertApk.Parameters.Add(new SqlParameter("@icon", apk.details.icon));
                SqlDataReader reader = InsertApk.ExecuteReader();
                reader.Read();
                MessageBox.Show(reader[0].ToString());
            }
        }

    }
}
