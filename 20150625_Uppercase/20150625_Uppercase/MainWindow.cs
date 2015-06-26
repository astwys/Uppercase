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

        private void btn_new_Click(object sender, EventArgs e) {
            tabControl_openFiles.Controls.Add(new Up_Tab());
        }

        private void btn_delete_Click(object sender, EventArgs e) {

        }

    }
}
