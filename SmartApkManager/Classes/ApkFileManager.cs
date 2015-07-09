using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace SmartApkManager.Classes
{
    class ApkFileManager
    {
        public bool AddApkToWorkSpace(APK apk)
        {
            SqlConnection DbConnection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\smart8\Documents\GitHub\SmartApkManager\SmartApkManager\Database1.mdf;Integrated Security=True");
            DbConnection.Open();
            string newFilePath = string.Format("{0}\\{1} {2}.apk", Properties.Settings.Default.WorkSpace, apk.details.applicationLabel, apk.details.versionName);
            SqlCommand InsertApk = new SqlCommand("ProcInsertApk", DbConnection);
            InsertApk.CommandType = CommandType.StoredProcedure;
            InsertApk.Parameters.Add(new SqlParameter("@packageName", apk.details.packageName));
            InsertApk.Parameters.Add(new SqlParameter("@ApplicationLabel", apk.details.applicationLabel));
            InsertApk.Parameters.Add(new SqlParameter("@versionCode", apk.details.versionCode));
            InsertApk.Parameters.Add(new SqlParameter("@filePath", newFilePath));
            InsertApk.Parameters.Add(new SqlParameter("@versionName", apk.details.versionName));
            InsertApk.Parameters.Add(new SqlParameter("@icon", apk.details.icon));
            SqlDataReader reader = InsertApk.ExecuteReader();
            reader.Read();
            if ((int)reader[0] == 1)
            {
                File.Move(apk.details.filePath, newFilePath);
                apk.details.filePath = newFilePath;
                reader.Close();
                return true;
            }
            reader.Close();
            return false;
        }
    }
}
