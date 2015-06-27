using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20150625_Uppercase {
    public partial class MainWindow : Form {

        public MainWindow() {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(700, 500);

        }

        //add button
        private void button11_Click(object sender, EventArgs e) {
            tabControl_openFiles.Controls.Add(new Up_Tab()); //add a new tab
            tabControl_openFiles.SelectedIndex = tabControl_openFiles.Controls.Count - 1; //focus the added tab
        }

        //delete button
        private void button12_Click(object sender, EventArgs e) {
            tabControl_openFiles.Controls.RemoveAt(tabControl_openFiles.SelectedIndex);
        }

        //home button
        private void button1_Click(object sender, EventArgs e) {
            tabControl_openFiles.Controls.Add(new Up_Tab("Home")); //add the home tab
            tabControl_openFiles.SelectedIndex = tabControl_openFiles.Controls.Count - 1; //focus the added tab
        }

    }
}
