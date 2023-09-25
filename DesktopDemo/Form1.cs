using DesktopDemo.Helpers;
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

namespace DesktopDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] driveInfos = DriveInfo.GetDrives();
            foreach(var driveInfo in driveInfos )
            {
                comboBox1.Items.Add(driveInfo.Name);
            }
            comboBox1.SelectedIndex= 0;
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Form1_Move(object sender, EventArgs e)
        {

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var drive = comboBox1.SelectedItem;
            DirectoriesHelper directoriesHelper=new DirectoriesHelper();
            var directories = directoriesHelper.GetDirectories(drive.ToString());
            foreach (var d in directories)
            {
                listBox1.Items.Add(d.Name);
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
