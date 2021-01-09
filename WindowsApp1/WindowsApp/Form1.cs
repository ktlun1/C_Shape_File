using System;
using System.IO;
using System.Windows.Forms;

namespace FileIO
{
    public partial class File : Form
    {
        string fileName;
        string filePath;
        public File()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Open File";
            fdlg.InitialDirectory = @"C:\";
            fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            fdlg.FilterIndex = 0;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                fileName = fdlg.FileName;
                filePath = Path.GetDirectoryName(fdlg.FileName);
                textBoxMain.Text = System.IO.File.ReadAllText(fdlg.FileName);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog fdlg = new SaveFileDialog();
            fdlg.Title = "Save File";
            fdlg.InitialDirectory = filePath;
            fdlg.Filter = "All files（*.*）|*.*|All files(*.*)|*.* ";
            fdlg.FilterIndex = 0;
            fdlg.RestoreDirectory = true;
            fdlg.FileName = Path.GetFileName(fileName);
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(fdlg.FileName, textBoxMain.Text);               
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
