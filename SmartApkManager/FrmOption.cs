using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SmartApkManager
{
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
            TxBxWorkSpacePath.Text = Properties.Settings.Default.WorkSpace;
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            DirBrsWorkSpace.ShowDialog();
            TxBxWorkSpacePath.Text = DirBrsWorkSpace.SelectedPath;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            string pathText = TxBxWorkSpacePath.Text;
            if (Directory.Exists(pathText))
            {
                Properties.Settings.Default.WorkSpace = pathText;
                Properties.Settings.Default.Save();
                Form.ActiveForm.Close();
            }
            else
            {
                bool directoryNameIsValid = false;
                if (pathText.IndexOf('\\') > 0)
                {
                    string firstParent = pathText.Substring(0, pathText.IndexOf('\\'));
                    if (Directory.Exists(firstParent))
                    {
                        directoryNameIsValid = true;
                        char[] invChars = Path.GetInvalidPathChars();
                        foreach (char invChar in invChars)
                        {
                            if (pathText.IndexOf(invChar) > 0)
                            {
                                directoryNameIsValid = false;
                                break;
                            }
                        }
                    }
                }
                if (directoryNameIsValid)
                {
                    DialogResult result = MessageBox.Show("The directory that you choose for workspace is not exist \nDo you whant to make it?", "Make Workspace", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        Directory.CreateDirectory(pathText);
                        Properties.Settings.Default.WorkSpace = pathText;
                        Properties.Settings.Default.Save();
                        Form.ActiveForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Selected Path For WorkSpace Is Not Valid", "Invalid WorkSpace Path", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }
    }
}
