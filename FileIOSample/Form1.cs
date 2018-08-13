using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {
            lstSchedule.Items.Add(txtClass.Text);
            txtClass.Clear();
            txtClass.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // SaveScheduleBasic();
            SaveSchedule();
            MessageBox.Show("Data was saved");
        }
        private void SaveSchedule()
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Data File |*.data:";
            save.RestoreDirectory = true;
            if(save.ShowDialog() == DialogResult.OK)
            {
                string path = save.FileName;
                if (path == string.Empty)
                    return;
                StringBuilder courseList = GetCoursesFromListBox();
                File.WriteAllText(path, courseList.ToString());
            }
        }
        private void SaveScheduleBasic()
        {
            StringBuilder data = GetCoursesFromListBox();
            string folder = GetMyDocumentsPath();
            //string path = @"c:\test.txt";
            string path = folder + "\\test.data";
            File.WriteAllText(path, data.ToString());
        }

        private StringBuilder GetCoursesFromListBox()
        {
            StringBuilder data = new StringBuilder();
            for (int i = 0; i < lstSchedule.Items.Count; i++)
            {
                data.AppendLine(lstSchedule.Items[i].ToString());
            }

            return data;
        }

        private void btnLoadSchedule_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = GetMyDocumentsPath();
            
            fileDialog.Filter = "Data File |*.data";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                // read the file
                List<string> courses = File.ReadLines(fileDialog.FileName).ToList();
                lstSchedule.Items.Clear();
                foreach (string course in courses)
                {
                    lstSchedule.Items.Add(course);
                }
                
            }
        }

        private string GetMyDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
