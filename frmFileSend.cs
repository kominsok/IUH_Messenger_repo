using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUH_Messenger
{
    public partial class frmFileSend : Form
    {
        public frmFileSend()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int fileCnt = lstAddedFile.Items.Count;

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.DefaultExt = "exe";
            //ofd.Filter = "EXE files|*.exe";
            ofd.InitialDirectory = Properties.Settings.Default.StartFolder;
            ofd.Title = "파일 선택";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (lstAddedFile.FindItemWithText(file) == null)
                    {
                        Icon icon = Icon.ExtractAssociatedIcon(file);
                        imageList.Images.Add(icon);

                        lstAddedFile.Items.Add(file, fileCnt);
                        fileCnt++;
                    }
                }
            }
        }
    }
}
