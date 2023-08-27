using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DesktopIcons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RemoteListView.LVItem[] lvl = RemoteListView.GetListView(   "Progman", "Program Manager", // Program Window Caption and Class
                                                                        "SysListView32", "FolderView"); // ListView Caption and Class
            foreach (RemoteListView.LVItem item in lvl)
                listBox1.Items.Add(item.Name + " @ " + item.Location.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the working rectangle from the Screen class
            // using the PrimaryScreen and the WorkingArea properties.
            System.Drawing.Rectangle workingRectangle =
                Screen.PrimaryScreen.WorkingArea;
            Screen[] myScreens = Screen.AllScreens;

            // Set the size of the form slightly less than size of 
            // working rectangle.
            this.Size = new System.Drawing.Size(
                workingRectangle.Width - 10, workingRectangle.Height - 10);

            // Set the location so the entire form is visible.
            this.Location = new System.Drawing.Point(5, 5);
        }
    }
}
