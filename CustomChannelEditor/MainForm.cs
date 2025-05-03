using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace CustomChannelEditor
{
    public partial class MainForm : Form
    {
        List<string> str_ref = new List<string>();
        private int lineCountM3U = 0;
        private int searchStart = 0;

        private int count = 0;
        // First, add this to the MainForm class to store and access the preferences
        private string defaultM3UPath = "";
        private string defaultXMLTVPath = "";
        public MainForm()
        {
            InitializeComponent();
            LoadPreferences(); // Load preferences when the form is created
                               // Add this to your InitializeComponent method or use the designer to add it to your menu
            //ToolStripMenuItem preferencesToolStripMenuItem = new ToolStripMenuItem();
            //preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            preferencesToolStripMenuItem.Text = "&Preferences...";
            preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);

            // Add this to an appropriate menu, e.g., Tools menu or File menu
            //menuStrip1.Add(preferencesToolStripMenuItem);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openM3UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;
            string[] lineSplit; // = new string(20);
           // int count = 0;
            int ii = 0;
            string dupString;
            //dgvChannelList.Rows.Clear();
            //dgvChannelList.Refresh();
            // Open M3U File and Parse to DataGridView
            openFileDialog1.DefaultExt = "m3u8";
            openFileDialog1.Title = "Browse M3U Files";
            openFileDialog1.Filter = "m3u files (*.m3u8)|*.m3u8";
            openFileDialog1.FileName = " ";
            openFileDialog1.Multiselect = true;
            openFileDialog1.InitialDirectory = defaultM3UPath; // Set the initial directory to the saved path
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in openFileDialog1.FileNames)
                {

                    // Open the selected file and parse
                    using (System.IO.StreamReader m3uFile = new System.IO.StreamReader(openFileDialog1.FileNames[ii++]))
                    {
                        while ((line = m3uFile.ReadLine()) != null)
                        {
                            //System.Console.WriteLine(line);
                            lineCountM3U++;
                            if (line.Contains("tvg-id") == true)
                            {
                                lineSplit = line.Split('"');
                                count++;
                                dupString = " ";
                                //if (ifStrExists(lineSplit[5]))
                                //{
                                //    //dupString = "Dup";
                                //}
                                dgvChannelList.Rows.Add(count.ToString(), lineSplit[7], lineSplit[5], dupString);


                                str_ref.Add(lineSplit[5]);
                            }

                        }
                        m3uFile.Close();
                        //System.Console.WriteLine("There were {0} lines.", lineCountM3U);
                    }

                }

            }

        }

        private bool ifStrExists(string temp)
        {

            for(int ii = 0; ii < str_ref.Count; ii++)
            {
                if(str_ref[ii].Substring(0,10).Equals(temp.Substring(0,10)))
                {
                    return true;
                }
            }

            return false;

        }

        private void openXMLTVXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String myChild;

            // Open M3U File and Parse to DataGridView
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Title = "Browse XMLTV.XML* Files";
            openFileDialog1.Filter = "xml* files (*.xml*)|*.xml*";
            openFileDialog1.FileName = "xmltv.xml";
            openFileDialog1.InitialDirectory = defaultXMLTVPath; // Set the initial directory to the saved path 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file and parse
                XmlDocument xmldoc = new XmlDocument();
                XmlNodeList xmlnode;

                xmldoc.Load(openFileDialog1.FileName);
                xmlnode = xmldoc.GetElementsByTagName("channel");
                for(int i = 0; i < xmlnode.Count - 1; i++)
                {
                    var myChildNodes = xmlnode[i].ChildNodes;
                    myChild = " ";
                    if (myChildNodes.Count == 7)
                    {
                        myChild = myChildNodes[1].InnerText + ", " + myChildNodes[5].InnerText;
                    }
                    if (myChildNodes.Count == 6)
                    {
                        myChild = myChildNodes[1].InnerText + ", " + myChildNodes[4].InnerText;
                    }
                    if (myChildNodes.Count == 5)
                    {
                        myChild = myChildNodes[1].InnerText + ", " + myChildNodes[3].InnerText;
                    }
                    if (myChildNodes.Count == 4)
                    {
                        myChild = myChildNodes[1].InnerText + ", " + myChildNodes[3].InnerText;
                    }
                    if (myChildNodes.Count == 3)
                    {
                        myChild = myChildNodes[1].InnerText + ", " + myChildNodes[2].InnerText;
                    }
                    if(myChildNodes.Count > 7)
                    {
                        myChild = myChildNodes[1].InnerText;
                    }
                    dgvEpgList.Rows.Add(i.ToString(), myChild, xmlnode[i].Attributes["id"].Value);
                    //FirstChild.Value, xmlnode[i].Attributes["id"].Value);


                }



            }
        }

        private void dgvEpgList_DoubleClick(object sender, EventArgs e)
        {
            // Copy EPG reference to the dgvChannelList

            int selRowEpg = dgvEpgList.CurrentCell.RowIndex;
            int selRowCh = dgvChannelList.CurrentCell.RowIndex;

            DataGridViewRow rowEpg = this.dgvEpgList.Rows[selRowEpg];
            DataGridViewRow rowCh = this.dgvChannelList.Rows[selRowCh];

            rowCh.Cells["ChannelEpg"].Value = rowEpg.Cells["EpgReference"].Value;



        }

        private void buildChannelListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Output Channel List
            int tRows = dgvChannelList.RowCount;
            string chEpg;
            string chComment;
            string chRef;
            DataGridViewRow rowCh;
            saveFileDialog1.FileName = "custom.channels.xml";
            saveFileDialog1.InitialDirectory = defaultXMLTVPath; // Set the initial directory to the saved path

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlTextWriter writer = new XmlTextWriter(saveFileDialog1.FileName, null);
                writer.WriteStartDocument(true);
                writer.Formatting = Formatting.Indented;
                writer.WriteStartElement("channels");
                for (int i = 0; i < tRows; i++)
                {
                    rowCh = this.dgvChannelList.Rows[i];
                    if (rowCh.Cells["ChannelEpg"].Value == null)
                    {
                        chEpg = "I000000";
                    }
                    else
                    {
                        chEpg = rowCh.Cells["ChannelEpg"].Value.ToString();
                        chComment = rowCh.Cells["ChannelName"].Value.ToString();
                        chRef = rowCh.Cells["ChannelReference"].Value.ToString();
                        createNode(chEpg, chRef, chComment, writer);
                    }
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Close();
            }
        }

        private  void createNode(string pID, string pName, string comment, XmlTextWriter writer)
        {
            writer.WriteComment(comment);
            writer.WriteStartElement("channel");
            writer.WriteAttributeString("id", pID);
            writer.WriteString(pName);
            writer.WriteString("https%3a//feldmanfamily.ws" );
            writer.WriteEndElement();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Search


        }

        private void tsFilter_Click(object sender, EventArgs e)
        {
            // Column to search EpgName
            string temp;
            string temp2;
            string tFilter;
            bool tEnd = false;
            searchStart = 0;
            tFilter = tsFilterText.Text.ToUpper();
            for (searchStart = 0; searchStart < dgvEpgList.RowCount && tEnd == false;searchStart++)
            {
                DataGridViewRow rowEpg = this.dgvEpgList.Rows[searchStart];


                if (rowEpg.Cells["EpgName"].Value == null)
                {
                    tEnd = true;
                }
                else
                {
                    temp = rowEpg.Cells["EpgName"].Value.ToString();
                    temp2 = temp.ToUpper();
                    if (temp2.Contains(tFilter))
                    {
                        rowEpg.Selected = true;
                        this.dgvEpgList.CurrentCell = rowEpg.Cells[0];
                        tEnd = true;
                    }
                }
            }


        }

        private void importCustomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rowT = 0;
            String sRef;
            String tRef;
            char[] charsToTrim = { 'h' };

            // Open M3U File and Parse to DataGridView
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Title = "Browse Custom Channels Files";
            openFileDialog1.Filter = "xml files (*.xml)|*.xml";
            openFileDialog1.FileName = "custom.channels.xml";
            openFileDialog1.InitialDirectory = defaultXMLTVPath; // Set the initial directory to the saved path 
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Open the selected file and parse
                XmlDocument xmldoc = new XmlDocument();
                XmlNodeList xmlnode;

                xmldoc.Load(openFileDialog1.FileName);
                xmlnode = xmldoc.GetElementsByTagName("channel");
                for (int i = 0; i < xmlnode.Count - 1; i++)
                {
                    // this.dgvChannelList.Rows.Add(i.ToString(), "Name",  xmlnode[i].ChildNodes.Item(0).FirstChild.Value, xmlnode[i].Attributes["id"].Value); ;
                    if (xmlnode[i].FirstChild != null)
                    {
                        sRef = xmlnode[i].FirstChild.Value.ToString();
                        tRef = sRef.Substring(0, sRef.LastIndexOf("h")+1);

                        //tRef = sRef.TrimEnd(charsToTrim);
                        //tRef = sRef.TrimE
                        // sRef.TrimEnd("https%3a//feldmanfamily.ws");
                        if (tRef.Length < 2)
                            tRef = sRef;
                        
                        rowT = findReference(tRef.Substring(0,tRef.Length-1));
                        if (rowT < 99999)
                            this.dgvChannelList.Rows[rowT].Cells["ChannelEpg"].Value = xmlnode[i].Attributes["id"].Value;
                    }
                }



            }
        }

        private int findReference(string search)
        {
            // Column to search EpgName
            string temp;
            bool tEnd = false;
            ;
            for (int i = 0; i < dgvChannelList.RowCount && tEnd == false; i++)
            {
                DataGridViewRow rowChan = this.dgvChannelList.Rows[i];


                if (rowChan.Cells["ChannelReference"].Value == null)
                {
                    tEnd = true;
                }
                else
                {
                    temp = rowChan.Cells["ChannelReference"].Value.ToString();
                    
                    if (temp.Contains(search))
                    {
                        //rowChan.Selected = true;
                        //this.dgvEpgList.CurrentCell = rowChan.Cells[0];
                        return i;
                        tEnd = true;
                    }
                }
            }
            return 99999;
        }

        private void tsbNext_Click(object sender, EventArgs e)
        {
            // Column to search EpgName
            string temp;
            string temp2;
            string tFilter;
            bool tEnd = false;

            tFilter = tsFilterText.Text.ToUpper();
            for (; searchStart < dgvEpgList.RowCount && tEnd == false; searchStart++)
            {
                DataGridViewRow rowEpg = this.dgvEpgList.Rows[searchStart];


                if (rowEpg.Cells["EpgName"].Value == null)
                {
                    tEnd = true;
                }
                else
                {
                    temp = rowEpg.Cells["EpgName"].Value.ToString();
                    temp2 = temp.ToUpper();
                    if (temp2.Contains(tFilter))
                    {
                        rowEpg.Selected = true;
                        this.dgvEpgList.CurrentCell = rowEpg.Cells[0];
                        tEnd = true;
                    }
                }
            }
            if (searchStart == dgvEpgList.RowCount) searchStart = 0;

        }

        private void tsFilterText_Enter(object sender, EventArgs e)
        {
            // Column to search EpgName
            string temp;
            string temp2;
            string tFilter;
            bool tEnd = false;
            searchStart = 0;
            tFilter = tsFilterText.Text.ToUpper();
            for (searchStart = 0; searchStart < dgvEpgList.RowCount && tEnd == false; searchStart++)
            {
                DataGridViewRow rowEpg = this.dgvEpgList.Rows[searchStart];


                if (rowEpg.Cells["EpgName"].Value == null)
                {
                    tEnd = true;
                }
                else
                {
                    temp = rowEpg.Cells["EpgName"].Value.ToString();
                    temp2 = temp.ToUpper();
                    if (temp2.Contains(tFilter))
                    {
                        rowEpg.Selected = true;
                        this.dgvEpgList.CurrentCell = rowEpg.Cells[0];
                        tEnd = true;
                    }
                }
            }

        }

        private void tsFilterText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string temp;
                string temp2;
                string tFilter;
                bool tEnd = false;
                searchStart = 0;
                tFilter = tsFilterText.Text.ToUpper();
                for (searchStart = 0; searchStart < dgvEpgList.RowCount && tEnd == false; searchStart++)
                {
                    DataGridViewRow rowEpg = this.dgvEpgList.Rows[searchStart];


                    if (rowEpg.Cells["EpgName"].Value == null)
                    {
                        tEnd = true;
                    }
                    else
                    {
                        temp = rowEpg.Cells["EpgName"].Value.ToString();
                        temp2 = temp.ToUpper();
                        if (temp2.Contains(tFilter))
                        {
                            rowEpg.Selected = true;
                            this.dgvEpgList.CurrentCell = rowEpg.Cells[0];
                            tEnd = true;
                        }
                    }
                }
            }
        }

        private void dgvChannelList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clearOrphanRefToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int clearedCount = 0;

            // Check each row in the channel list
            foreach (DataGridViewRow channelRow in dgvChannelList.Rows)
            {
                // Skip the new row at the end
                if (channelRow.IsNewRow)
                    continue;

                // Get the ChannelEpg value
                if (channelRow.Cells["ChannelEpg"].Value != null)
                {
                    string channelEpgValue = channelRow.Cells["ChannelEpg"].Value.ToString();
                    bool foundMatch = false;

                    // Look for a matching reference in the EPG list
                    foreach (DataGridViewRow epgRow in dgvEpgList.Rows)
                    {
                        if (epgRow.IsNewRow)
                            continue;

                        if (epgRow.Cells["EpgReference"].Value != null &&
                            epgRow.Cells["EpgReference"].Value.ToString() == channelEpgValue)
                        {
                            foundMatch = true;
                            break;
                        }
                    }

                    // If no matching reference was found, clear the ChannelEpg value
                    if (!foundMatch)
                    {
                        channelRow.Cells["ChannelEpg"].Value = null;
                        clearedCount++;
                    }
                }
            }

            // Show a message indicating how many references were cleared
            if (clearedCount > 0)
                MessageBox.Show($"Cleared {clearedCount} orphaned EPG references.", "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No orphaned EPG references found.", "Cleanup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Add a method to load preferences
        private void LoadPreferences()
        {
            // Load settings from application settings
            defaultM3UPath = Properties.Settings.Default.DefaultM3UPath ?? "";
            defaultXMLTVPath = Properties.Settings.Default.DefaultXMLTVPath ?? "";
        }

        // Add a method to save preferences
        private void SavePreferences()
        {
            Properties.Settings.Default.DefaultM3UPath = defaultM3UPath;
            Properties.Settings.Default.DefaultXMLTVPath = defaultXMLTVPath;
            Properties.Settings.Default.Save();
        }

        // Add a menu item handler for preferences
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create and show the preferences dialog
            using (PreferencesForm prefsForm = new PreferencesForm(defaultM3UPath, defaultXMLTVPath))
            {
                if (prefsForm.ShowDialog() == DialogResult.OK)
                {
                    // Update the preferences if OK was clicked
                    defaultM3UPath = prefsForm.M3UPath;
                    defaultXMLTVPath = prefsForm.XMLTVPath;
                    SavePreferences();
                }
            }
        }
        
    }
}


//<? xml version="1.0" encoding="utf-8"?> 
//<channels>
//  <channel id = "I40722.labs.zap2it.com" > 1:0:1:1:1:1:A1D8E8D:0:0:0:</channel> <!-- 101W MeTV      -->
//  <channel id = "I91694.labs.zap2it.com" > 1:0:1:2:1:1:A1D8E78:0:0:0:</channel> <!-- 101W Start TV East  -->  
//  <channel id = "I92434.labs.zap2it.com" > 1:0:1:5:1:0:A1D8E7C:0:0:0:</channel> <!-- 101W Start TV West  -->   
//  <channel id = "I75319.labs.zap2it.com" > 1:0:1:3:2:0:A1D8EB4:0:0:0:</channel> <!-- 101W Movies!   -->    
//  <channel id = "I97850.labs.zap2it.com" > 1:0:1:4:1:1:A1D8EA0:0:0:0:</channel> <!-- 101W Heroes  East  --> 
//  <channel id = "I54189.labs.zap2it.com" > 1:0:1:7:1:0:A1D8E95:0:0:0:</channel> <!-- 101W Heroes  West  -->   
//  <channel id = "I54193.labs.zap2it.com" > 1:0:1:8:1:1:A1D8EA4:0:0:0:</channel> <!-- 101W Decades    -->   
//  <channel id = "I67676.labs.zap2it.com" > 1:0:1:3:1:0:A0AAF71:0:0:0:</channel> <!-- 101W SBN       -->   
//  <channel id = "I66347.labs.zap2it.com" > 1:0:1:2:1:0:A0AAF71:0:0:0:</channel> <!-- 103W NHK World    -->  
//  <channel id = "I29114.labs.zap2it.com" > 1:0:1:6:1:0:A0AAF71:0:0:0:</channel> <!-- 103W CGTN         -->  
//</channels>
