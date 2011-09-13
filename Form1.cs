using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace epanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gLoadExit();
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            gSaveExit(); gSaveSettingsExit();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            this.AcceptButton = button1;
            if (checkBox3.Checked == true)
            {
                webbrowser = "firefox";
            }
        }       
        #region Save/Load
        private void gSaveExit()
        {
            using (StreamWriter sw = new StreamWriter("eData.pnl"))
            //try not neccessary only used to catch exceptions
                try
                {
                    foreach (string LItem in listBox1.Items)
                    {
                        sw.WriteLine(LItem);
                    }
                }
                finally
                {	//fig 1
                    sw.Close();
                }
        }
        private void gSaveSettingsExit()
        {
                try
                {
                    string path;
                    Font font1 = listBox1.Font;
                    TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                    string fontString = converter.ConvertToString(font1);
                    path = checkBox1.Checked.ToString() + ";" + checkBox3.Checked.ToString() + ";" + fontString;
                    using (StreamWriter sw = new StreamWriter("eSettings.pnl"))
                    sw.Write(path);
                }
                catch { }
        }
        private void gLoadExit()
        {
            try
            {
                StreamReader sr = new StreamReader("eData.pnl");
                string line;
                while ((line = sr.ReadLine()) != null)
                    listBox1.Items.Add(line);
                sr.Close();

                try
                {
                    Boolean Loadcbx1, Loadcbx3;
                    string settings, font;
                    using (StreamReader file = new StreamReader("eSettings.pnl"))
                        while ((settings = file.ReadLine()) != null)
                        {
                            string[] Split = settings.Split(new Char[] { ';' });

                            Loadcbx1 = Convert.ToBoolean(Split[0]);
                            Loadcbx3 = Convert.ToBoolean(Split[1]);
                            font = Convert.ToString(Split[2]);

                            checkBox1.Checked = Loadcbx1;
                            checkBox3.Checked = Loadcbx3;
                            TypeConverter converter = TypeDescriptor.GetConverter(typeof(Font));
                            Font fontResult = (Font)converter.ConvertFromString(font);
                            listBox1.Font = fontResult;
                        }
                }
                catch { }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Settings not found...Creating a new one.", "NOTICE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void gSave()
        {
            string File;
            DialogResult result;
            result = dlgSave.ShowDialog();
            File = dlgSave.FileName;
            if (result == DialogResult.OK)
            {
                //Stream @ this level to work with (fig.1); b4 try statement
                using (StreamWriter sw = new StreamWriter(File))
                    try
                    {
                        foreach (string LItem in listBox1.Items)
                        {
                            sw.WriteLine(LItem);
                        }
                    }
                    finally
                    {	//fig 1
                        sw.Close();
                    }
            }

        }
        private void gLoad()
        {
            string File;
            DialogResult result;
            result = dlgOpen.ShowDialog();
            File = dlgOpen.FileName;
            if (result == DialogResult.OK)
            {
                try
                {
                    StreamReader sr = new StreamReader(File);
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        listBox1.Items.Add(line);
                    sr.Close();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("There was an error opening the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void button3_Click(object sender, System.EventArgs e)
        { gSave(); }
        private void menuItemSave_Click(object sender, System.EventArgs e)
        { gSave(); }
        private void menuItemLoad_Click(object sender, System.EventArgs e)
        { gLoad(); }
        private void button2_Click(object sender, System.EventArgs e)
        { gLoad(); }
        private void lnkImport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {gLoad();
        }
        private void lnkExport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {gSave();
        }
        #endregion
        #region PowerFunc
        #region GO
        string webbrowser = "iexplore"; //used for form1_load
        private void gGo()
        {//GO
            if (!((comboBox1.Text == "")))
            {
                try
                {
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = comboBox1.Text;
                    //Read Arguments
                    proc.StartInfo.Arguments = txtArg.Text;
                    proc.Start();
                    //Add to autocomplete
                    comboBox1.Items.Add(comboBox1.Text);
                }
                catch (Exception)
                {
                    //redirect to internet search
                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.EnableRaisingEvents = false;
                    proc.StartInfo.FileName = webbrowser;
                    proc.StartInfo.Arguments = "http://www.google.com/search?hl=en&q=" + comboBox1.Text;
                    proc.Start();
                    comboBox1.Items.Add(comboBox1.Text);
                }
            }
        }
        private void lnkSubmit_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        { gGo(); }
        private void mnuGO_Click(object sender, System.EventArgs e)
        { gGo(); }
        #endregion
        #region TopMost
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {//TopMost
            if (checkBox1.Checked == false)
            { TopMost = false; }
            else
            { TopMost = true; }
        }
        private void mnuOnTop_Click(object sender, System.EventArgs e)
        {
            if (!(TopMost == true))
            {
                TopMost = true;
                mnuOnTop.Checked = true;
            }
            else
            {
                TopMost = false;
                mnuOnTop.Checked = false;
            }
        }
        #endregion
        #region CollectionActions
        private void button1_Click(object sender, System.EventArgs e)
        {//add 2 collection
            if (!((textBox1.Text == "")))
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }
        private void lnkPurge_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {//Purge Collection
            string message = "Are you sure you want to clear your collections list now?";
            string caption = "Wipe All Collections?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(this, message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                listBox1.Items.Clear();
            }
        }
        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {//Clear Autocomplete
            if (checkBox2.Checked == true)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
                MessageBox.Show("Done");
                checkBox2.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                webbrowser = "firefox";
            }
            else
            {
                webbrowser = "iexplore";
            }
        }
        private void menuItemRemove_Click(object sender, System.EventArgs e)
        {
            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {//Writing whatever is in the listbox1 to combobox1; Dynamic changes
            //if statement added to save from crash; Note: !=not
            if (!((listBox1.SelectedItem == null)))
            {
                comboBox1.Text = listBox1.SelectedItem.ToString();
            }
        }
        private void lnkFont_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult result;
            result = dlgFont.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Font = dlgFont.Font;
            }
        }
        #endregion
        #region Trackbar
        private void trackBar1_Scroll(object sender, System.EventArgs e)
        { Opacity = (double)trackBar1.Value / 100.0; }
        #endregion
        #region Tray
        private void RestoreTray(object sender, System.EventArgs e)
        {
            notifyIcon1.Visible = false;
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void mnuTray_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;
        }
        private void lnkTray_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            WindowState = FormWindowState.Minimized;
            Hide();
            notifyIcon1.Visible = true;
        }
        #endregion
        #region Help
        private void menuItem2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://forgotthesite.googlepages.com/epanel");
        }
        #endregion
        #endregion
    }
}