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
using System.IO;

namespace SmartApkManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
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

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOptions = new FrmOptions();
            frmOptions.ShowDialog(this);
        }

        private void BtnBrowseApkDir_Click(object sender, EventArgs e)
        {
            DirBrs.ShowDialog();
            if (Directory.Exists(DirBrs.SelectedPath))
            {
                TxBxPath.Text = DirBrs.SelectedPath;
                string[] FilesInDir;
                if (ChkBxRecurcive.Checked)
                {
                    FilesInDir = Directory.GetFiles(DirBrs.SelectedPath, "*.apk", SearchOption.AllDirectories);
                }
                else
                {
                    FilesInDir = Directory.GetFiles(DirBrs.SelectedPath, "*.apk", SearchOption.TopDirectoryOnly);
                }

                FlwLyoExplorer.Controls.Clear();
                foreach (string FileName in FilesInDir)
                {
                    ApkHolder apkHolder = new ApkHolder();
                    apkHolder.APK = new APK(FileName);
                    FlwLyoExplorer.Controls.Add(apkHolder);
                }
            }
        }

        private void BtnAddToDb_Click(object sender, EventArgs e)
        {
            foreach (ApkHolder apkHolder in FlwLyoExplorer.Controls)
            {
                SqlConnection DbConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\smart8\Documents\GitHub\SmartApkManager\SmartApkManager\Database1.mdf;Integrated Security=True");
                APK apk = apkHolder.APK;
                using (DbConnection)
                {
                    DbConnection.Open();
                    SqlCommand InsertApk = new SqlCommand("ProcInsertApk", DbConnection);
                    InsertApk.CommandType = CommandType.StoredProcedure;
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
}
