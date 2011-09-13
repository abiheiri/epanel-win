namespace epanel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnkTray = new System.Windows.Forms.LinkLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenutxt = new System.Windows.Forms.ContextMenu();
            this.menuItemRemove = new System.Windows.Forms.MenuItem();
            this.mnuCollGO = new System.Windows.Forms.MenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lnkSubmit = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArg = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lnkPurge = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.mnuGO = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemLoad = new System.Windows.Forms.MenuItem();
            this.menuItemSave = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.mnuOnTop = new System.Windows.Forms.MenuItem();
            this.mnuTray = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lnkFont = new System.Windows.Forms.LinkLabel();
            this.lnkExport = new System.Windows.Forms.LinkLabel();
            this.lnkImport = new System.Windows.Forms.LinkLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkTray
            // 
            this.lnkTray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkTray.BackColor = System.Drawing.SystemColors.Control;
            this.lnkTray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkTray.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkTray.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkTray.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkTray.LinkColor = System.Drawing.Color.Black;
            this.lnkTray.Location = new System.Drawing.Point(8, 31);
            this.lnkTray.Name = "lnkTray";
            this.lnkTray.Size = new System.Drawing.Size(90, 23);
            this.lnkTray.TabIndex = 19;
            this.lnkTray.TabStop = true;
            this.lnkTray.Text = " Hide to Tray";
            this.lnkTray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkTray.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkTray_LinkClicked);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.Location = new System.Drawing.Point(8, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.ContextMenu = this.contextMenutxt;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(8, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(278, 160);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // contextMenutxt
            // 
            this.contextMenutxt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemRemove,
            this.mnuCollGO});
            // 
            // menuItemRemove
            // 
            this.menuItemRemove.Index = 0;
            this.menuItemRemove.Text = "Remove";
            this.menuItemRemove.Click += new System.EventHandler(this.menuItemRemove_Click);
            // 
            // mnuCollGO
            // 
            this.mnuCollGO.Index = 1;
            this.mnuCollGO.Text = "GO";
            this.mnuCollGO.Click += new System.EventHandler(this.mnuGO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 223);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(238, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "&Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkSubmit
            // 
            this.lnkSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSubmit.BackColor = System.Drawing.SystemColors.Control;
            this.lnkSubmit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSubmit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSubmit.Location = new System.Drawing.Point(253, 31);
            this.lnkSubmit.Name = "lnkSubmit";
            this.lnkSubmit.Size = new System.Drawing.Size(35, 23);
            this.lnkSubmit.TabIndex = 17;
            this.lnkSubmit.TabStop = true;
            this.lnkSubmit.Text = "Go";
            this.lnkSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkSubmit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSubmit_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtArg);
            this.groupBox3.Location = new System.Drawing.Point(16, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 91);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arguments";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "This is where you write arguments for a command you launch. ie. If you add \"shutd" +
                "own\" in the \"Main\" tab. then you add \"-i\" here";
            // 
            // txtArg
            // 
            this.txtArg.Location = new System.Drawing.Point(6, 19);
            this.txtArg.Name = "txtArg";
            this.txtArg.Size = new System.Drawing.Size(177, 20);
            this.txtArg.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "&Import";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lnkPurge
            // 
            this.lnkPurge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkPurge.Location = new System.Drawing.Point(235, 15);
            this.lnkPurge.Name = "lnkPurge";
            this.lnkPurge.Size = new System.Drawing.Size(51, 16);
            this.lnkPurge.TabIndex = 23;
            this.lnkPurge.TabStop = true;
            this.lnkPurge.Text = "Purge All";
            this.lnkPurge.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lnkPurge.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPurge_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(16, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 39);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "&Export";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(16, 157);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 18);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Clear AutoComplete";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(16, 174);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(270, 22);
            this.trackBar1.TabIndex = 25;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(16, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 35);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Keep this window on top";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuGO,
            this.menuItem3,
            this.menuItemLoad,
            this.menuItemSave,
            this.menuItem5,
            this.mnuOnTop,
            this.mnuTray,
            this.menuItem1,
            this.menuItem2});
            // 
            // mnuGO
            // 
            this.mnuGO.Index = 0;
            this.mnuGO.Text = "GO";
            this.mnuGO.Click += new System.EventHandler(this.mnuGO_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "-";
            // 
            // menuItemLoad
            // 
            this.menuItemLoad.Index = 2;
            this.menuItemLoad.Text = "Load Collection";
            this.menuItemLoad.Click += new System.EventHandler(this.menuItemLoad_Click);
            // 
            // menuItemSave
            // 
            this.menuItemSave.Index = 3;
            this.menuItemSave.Text = "Save Collection";
            this.menuItemSave.Click += new System.EventHandler(this.menuItemSave_Click);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 4;
            this.menuItem5.Text = "-";
            // 
            // mnuOnTop
            // 
            this.mnuOnTop.Index = 5;
            this.mnuOnTop.Text = "On Top";
            this.mnuOnTop.Click += new System.EventHandler(this.mnuOnTop_Click);
            // 
            // mnuTray
            // 
            this.mnuTray.Index = 6;
            this.mnuTray.Text = "Hide to tray";
            this.mnuTray.Click += new System.EventHandler(this.mnuTray_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 7;
            this.menuItem1.Text = "-";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 8;
            this.menuItem2.Text = "Help";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "€\'panel";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.RestoreTray);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(302, 284);
            this.tabControl1.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lnkFont);
            this.tabPage1.Controls.Add(this.lnkExport);
            this.tabPage1.Controls.Add(this.lnkImport);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.lnkSubmit);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.lnkTray);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(294, 258);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // lnkFont
            // 
            this.lnkFont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkFont.BackColor = System.Drawing.SystemColors.Control;
            this.lnkFont.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkFont.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkFont.LinkColor = System.Drawing.Color.Black;
            this.lnkFont.Location = new System.Drawing.Point(203, 31);
            this.lnkFont.Name = "lnkFont";
            this.lnkFont.Size = new System.Drawing.Size(44, 23);
            this.lnkFont.TabIndex = 22;
            this.lnkFont.TabStop = true;
            this.lnkFont.Text = "Font";
            this.lnkFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkFont.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFont_LinkClicked);
            // 
            // lnkExport
            // 
            this.lnkExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExport.BackColor = System.Drawing.SystemColors.Control;
            this.lnkExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkExport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkExport.LinkColor = System.Drawing.Color.Black;
            this.lnkExport.Location = new System.Drawing.Point(154, 31);
            this.lnkExport.Name = "lnkExport";
            this.lnkExport.Size = new System.Drawing.Size(44, 23);
            this.lnkExport.TabIndex = 21;
            this.lnkExport.TabStop = true;
            this.lnkExport.Text = "Export";
            this.lnkExport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkExport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExport_LinkClicked);
            // 
            // lnkImport
            // 
            this.lnkImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkImport.BackColor = System.Drawing.SystemColors.Control;
            this.lnkImport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lnkImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImport.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkImport.LinkColor = System.Drawing.Color.Black;
            this.lnkImport.Location = new System.Drawing.Point(104, 31);
            this.lnkImport.Name = "lnkImport";
            this.lnkImport.Size = new System.Drawing.Size(44, 23);
            this.lnkImport.TabIndex = 20;
            this.lnkImport.TabStop = true;
            this.lnkImport.Text = "Import";
            this.lnkImport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkImport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImport_LinkClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBox3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.lnkPurge);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.trackBar1);
            this.tabPage2.Controls.Add(this.checkBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(294, 258);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(117, 111);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(142, 38);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "Use Firefox for searches";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Right-click for more options";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 284);
            this.ContextMenu = this.contextMenu1;
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "€\'panel v3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkTray;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel lnkSubmit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtArg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel lnkPurge;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.MenuItem mnuGO;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemLoad;
        private System.Windows.Forms.MenuItem menuItemSave;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.MenuItem mnuOnTop;
        private System.Windows.Forms.MenuItem mnuTray;
        private System.Windows.Forms.ContextMenu contextMenutxt;
        private System.Windows.Forms.MenuItem menuItemRemove;
        private System.Windows.Forms.MenuItem mnuCollGO;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkFont;
        private System.Windows.Forms.LinkLabel lnkExport;
        private System.Windows.Forms.LinkLabel lnkImport;
        private System.Windows.Forms.FontDialog dlgFont;
    }
}

