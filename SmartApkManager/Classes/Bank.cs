using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.IO;


namespace SmartApkManager
{
    class Bank
    {
        string WorkSpaceFolder;
        SQLiteConnection DBConnection;

        public Bank(string WorkSpaceFolder)
        {
            this.WorkSpaceFolder = WorkSpaceFolder;
            if (!File.Exists(WorkSpaceFolder + "\\Bank.db"))
                MakeDB(WorkSpaceFolder + "\\Bank.db");
            else
            {
                try
                {
                    this.DBConnection = new SQLiteConnection(string.Format(@"Data Source={0}\Bank.db; Version=3;", WorkSpaceFolder));
                }
                catch
                {

                }
            }
        }
        public void MakeDB(string directoryAdress)
        {
            string DbFileName = directoryAdress + "Test.db";
            SQLiteConnection.CreateFile(DbFileName);

            DBConnection = new SQLiteConnection(string.Format("Data Source={0};Version=3;", DbFileName));
            DBConnection.Open();

            string TblApkCmd =    "CREATE TABLE TblApk ( " +
                            "Id               INTEGER           PRIMARY KEY ASC AUTOINCREMENT NOT NULL," +
                            "versionName      NVARCHAR NULL," +
                            "applicationLabel NVARCHAR NULL," +
                            "icon           BLOB        NULL" +
                            ");";
            SQLiteCommand createTable = new SQLiteCommand(TblApkCmd, DBConnection);
            createTable.ExecuteNonQuery();
            DBConnection.Close();
        }
        public void insertApk(APK apk, string DbFileName)
        {
            SQLiteCommand SelectApk = new SQLiteCommand("SELECT count(*) FROM TblApk WHERE applicationLabel = @applicationLabel AND versionName = @versionName", DBConnection);
            SelectApk.Parameters.Add(new SQLiteParameter("@versionName", apk.details.versionName));
            SelectApk.Parameters.Add(new SQLiteParameter("@applicationLabel", apk.details.applicationLabel));
            DBConnection.Open();
            int count = Convert.ToInt32(SelectApk.ExecuteScalar());
            if (count == 0)
            {
                SQLiteCommand InsertApk = new SQLiteCommand("INSERT INTO TblApk (versionName, applicationLabel, icon) VALUES(@versionName, @applicationLabel, @icon)", DBConnection);
                InsertApk.Parameters.Add(new SQLiteParameter("@versionName", apk.details.versionName));
                InsertApk.Parameters.Add(new SQLiteParameter("@applicationLabel", apk.details.applicationLabel));
                InsertApk.Parameters.Add(new SQLiteParameter("@icon", apk.details.HiResIcon));
                InsertApk.ExecuteNonQuery();
                DBConnection.Close();
            }
        }
    }
}
