using System.Windows.Forms;
using System.Drawing;
using System;

namespace _20150625_Uppercase {

    /**
    *   this part includes all parts that have to do with the "view" (MainWindow): 
    *                               - the designer for the window (MainWindow)
    *                               - special tabs (Up_Tab)
    **/

    partial class MainWindow {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.javaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl_openFiles = new Up_TabControl();
            this.ut_welcome = new _20150625_Uppercase.Up_Tab();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl_openFiles.SuspendLayout();
            this.SuspendLayout();

            //here
            test1 = new Up_Tab();
            test1.SuspendLayout();

            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 34);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(284, 384);
            this.treeView1.TabIndex = 5;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem1,
            this.cToolStripMenuItem,
            this.javaToolStripMenuItem,
            this.plainTextToolStripMenuItem});
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 20);
            this.toolStripDropDownButton1.Text = "Language";
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.cToolStripMenuItem1.Text = "C";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cToolStripMenuItem.Text = "C#";
            // 
            // javaToolStripMenuItem
            // 
            this.javaToolStripMenuItem.Name = "javaToolStripMenuItem";
            this.javaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.javaToolStripMenuItem.Text = "Java";
            // 
            // plainTextToolStripMenuItem
            // 
            this.plainTextToolStripMenuItem.Checked = true;
            this.plainTextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plainTextToolStripMenuItem.Name = "plainTextToolStripMenuItem";
            this.plainTextToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.plainTextToolStripMenuItem.Text = "Plain Text";
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.Size = new System.Drawing.Size(1255, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl_openFiles
            // 
            this.tabControl_openFiles.Controls.Add(this.ut_welcome);
            this.tabControl_openFiles.Controls.Add(this.test1);
            this.tabControl_openFiles.Location = new System.Drawing.Point(298, 34);
            this.tabControl_openFiles.Name = "tabControl_openFiles";
            this.tabControl_openFiles.SelectedIndex = 0;
            this.tabControl_openFiles.Size = new System.Drawing.Size(945, 384);
            this.tabControl_openFiles.TabIndex = 3;
            this.tabControl_openFiles.TabStop = false;
            // 
            // ut_welcome
            // 
            this.ut_welcome.Location = new System.Drawing.Point(4, 22);
            this.ut_welcome.Name = "ut_welcome";
            this.ut_welcome.Padding = new System.Windows.Forms.Padding(3);
            this.ut_welcome.Size = new System.Drawing.Size(937, 358);
            this.ut_welcome.TabIndex = 0;
            this.ut_welcome.Text = "Welcome";
            this.ut_welcome.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 519);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tabControl_openFiles);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainWindow";
            this.Text = "Uppercase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl_openFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Up_TabControl tabControl_openFiles;
        private Up_Tab ut_welcome;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem projectToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private TreeView treeView1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem cToolStripMenuItem1;
        private ToolStripMenuItem cToolStripMenuItem;
        private ToolStripMenuItem javaToolStripMenuItem;
        private ToolStripMenuItem plainTextToolStripMenuItem;
        private StatusStrip statusStrip1;

        private Up_Tab test1;

    }


    /**
    *
    * the custom tab that automatically is added a RichTextBox and has special properties to be set when creating the object
    *
    **/
    public class Up_Tab : TabPage {

        //here the file is edited
        private RichTextBox tf_file;

        //defines the path to the file from the projects origin
        private string path;

        //defines the coding language and the language pack that needs to be loaded (not yet implemented)
        private string language;
        //private LanguagePack languagePack;

        public Up_Tab(string path) {
            if (path.Equals("Welcome")) {
                WelcomeTab();
                return;
            }
            //load the file into the new textfield
            tf_file = new RichTextBox();
            tf_file.LoadFile(path);

            this.path = path;
            string file = path.ToLower();
            if (file.EndsWith(".cs")) {
                language = "C#";
            }else if (file.EndsWith(".c")) {
                language = "C";
            }else if (file.EndsWith(".java")) {
                language = "Java";
            }else {
                language = "Plain text";
            }
            //languagePack = new LanguagePack(language);

            InitialiseCommons();
        }

        public Up_Tab() {
            tf_file = new RichTextBox();
            language = "Plain text";
            path = "New file";

            InitialiseCommons();
        }

        //used to initialise the Weclome tab
        private void WelcomeTab() {
            tf_file = new RichTextBox();
            tf_file.Text = "Wecome to Uppercase. A special editor created for coders. Have fun and enjoy!";
            language = "Plain text";
            path = "Welcome";
            InitialiseCommons();
        }

        private void InitialiseCommons() {

            //other settings for the tab
            this.Name = path;
            this.Padding = new Padding(3);
            this.Size = new Size(937, 358);
            this.Text = path;
            this.UseVisualStyleBackColor = true;

            //initialise the tf
            this.tf_file.AcceptsTab = true;
            this.tf_file.Dock = DockStyle.Fill;
            this.tf_file.Location = new Point(3, 3);
            this.tf_file.Name = "inputText";
            //this.tf_file.Size = new Size(931, 352);
            this.tf_file.WordWrap = false;

            this.Controls.Add(tf_file);
        }

    }

    /**
    *
    * the custom TabControl so we can hav a ContextMenu that meets our needs
    *
    **/
    public class Up_TabControl : TabControl {

        //right-click menu
        private ContextMenuStrip CMS;

        //to save the position we initially clicked
        private Point clickLocation;

        public Up_TabControl() {
            this.CMS = new ContextMenuStrip();
            this.CMS.Items.Add("Save", null/*might be replaced with a pic*/, new System.EventHandler(Item_Clicked));
            this.CMS.Items.Add("Close", null/*might be replaced with a pic*/, new System.EventHandler(Item_Clicked));
        }

        private void Item_Clicked(object sender, EventArgs e) {
            if (sender.ToString().Equals("Save")) {
                //...saving
            }else if(sender.ToString().Equals("Close")) {

                for (Int16 i = 0; i < this.TabCount; i++) {
                    Rectangle rect = this.GetTabRect(i);

                    if (rect.Contains(this.PointToClient(clickLocation))) {
                        this.TabPages.RemoveAt(i);
                    }
                }

            }
        }

        protected override void OnMouseClick(MouseEventArgs e) {
            base.OnMouseClick(e);

            if (e.Button == MouseButtons.Right) {
                clickLocation = Cursor.Position;
                CMS.Show(Cursor.Position);
            }

        }

    }

}

