using System.Windows.Forms;

namespace _20150625_Uppercase {
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
            this.treeView_files = new TreeView();
            this.tabControl_openFiles = new TabControl();
            this.tabPage_1stFile = new TabPage();
            this.richTextBox = new RichTextBox();
            this.tabPage1 = new TabPage();
            this.tabPage2 = new TabPage();
            this.tabPage3 = new TabPage();
            this.tabPage4 = new TabPage();
            this.tabControl_openFiles.SuspendLayout();
            this.tabPage_1stFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_files
            // 
            this.treeView_files.Location = new System.Drawing.Point(12, 12);
            this.treeView_files.Name = "treeView_files";
            this.treeView_files.Size = new System.Drawing.Size(280, 384);
            this.treeView_files.TabIndex = 1;
            // 
            // tabControl_openFiles
            // 
            this.tabControl_openFiles.Controls.Add(this.tabPage_1stFile);
            this.tabControl_openFiles.Controls.Add(this.tabPage1);
            this.tabControl_openFiles.Controls.Add(this.tabPage2);
            this.tabControl_openFiles.Controls.Add(this.tabPage3);
            this.tabControl_openFiles.Controls.Add(this.tabPage4);
            this.tabControl_openFiles.TabStop = false; // here
            this.tabControl_openFiles.Location = new System.Drawing.Point(298, 12);
            this.tabControl_openFiles.Name = "tabControl_openFiles";
            this.tabControl_openFiles.SelectedIndex = 0;
            this.tabControl_openFiles.Size = new System.Drawing.Size(945, 384);
            this.tabControl_openFiles.TabIndex = 3;
            // 
            // tabPage_1stFile
            // 
            this.tabPage_1stFile.Controls.Add(this.richTextBox);
            this.tabPage_1stFile.Location = new System.Drawing.Point(4, 22);
            this.tabPage_1stFile.Name = "tabPage_1stFile";
            this.tabPage_1stFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_1stFile.Size = new System.Drawing.Size(937, 358);
            this.tabPage_1stFile.TabIndex = 0;
            this.tabPage_1stFile.Text = "Getting started";
            this.tabPage_1stFile.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(931, 352);
            this.richTextBox.Text = "Hello and welcome to Uppercase. A special editor just for coders. Have fun!";
            this.richTextBox.WordWrap = false;
            this.richTextBox.AcceptsTab = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 358);
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 358);
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(937, 358);
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(937, 358);
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 519);
            this.Controls.Add(this.tabControl_openFiles);
            this.Controls.Add(this.treeView_files);
            this.Name = "MainWindow";
            this.Text = "Uppercase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_openFiles.ResumeLayout(false);
            this.tabPage_1stFile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView_files;
        private TabControl tabControl_openFiles;
        private TabPage tabPage_1stFile;
        private RichTextBox richTextBox;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}

