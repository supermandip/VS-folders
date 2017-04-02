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

namespace Mandip.Karki_Assignment2
{
    public partial class Form1 : Form
    {
        Color[] bcolors = { Color.Aqua, Color.Coral, Color.Blue, Color.MediumPurple };
        int cpos = 0;
        public Form1()
        {
            InitializeComponent();
            loadList();
            comboBox1.Text = "Choose a option...";

         
                
            
        }

        private void loadList()
        {
            List<string> columns;
            List<Dictionary<string, string>> myData = GetData(out columns);

            foreach (Dictionary<string, string> row in myData)
            {
                KarkimaData newOrder = new KarkimaData();
                foreach (string column in columns)
                {
                    if (column == "MusicOrMovie")
                    {
                        newOrder.MusOrMov = row[column].ToString();
                    }
                    else if (column == "EntertainGenre")
                    {
                        newOrder.Genre = row[column].ToString();
                    }
                    else if (column == "Title")
                    {
                        newOrder.Title = row[column].ToString();
                    }
                    else if (column == "Rating")
                    {
                        newOrder.Rating = double.Parse(row[column].ToString());
                    }
                }
                Global.GList.Add(newOrder);

               
            }
            for (int x = 0; x < Global.GList.Count; x++)
            {

                comboBox1.Items.Add(Global.GList[x].Title);
            }
            

        }

        private static List<Dictionary<string, string>> GetData(out List<string> columns)
        {
            string line;
            string[] stringArray;
            char[] charArray = new char[] { ',' };       //delimited character
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>(); //return value
            columns = new List<string>();

            try
            {
                FileStream fname = new FileStream("MyData/MusicMovie.txt", FileMode.Open);
                StreamReader ofile = new StreamReader(fname);

                line = ofile.ReadLine();                  //column names from first line
                if (line != null)                         //added check (not in original code)
                {
                    stringArray = line.Split(charArray);  //splits line based on location of ,
                    for (int x = 0; x <= stringArray.GetUpperBound(0); x++)
                    {
                        columns.Add(stringArray[x]);
                    }

                    line = ofile.ReadLine();
                    while (line != null)
                    {
                        stringArray = line.Split(charArray);
                        Dictionary<string, string> dataRow = new Dictionary<string, string>();
                        for (int x = 0; x <= stringArray.GetUpperBound(0); x++)
                        {
                            dataRow.Add(columns[x], stringArray[x]);  //key is column name; value is value of column for row
                        }
                        data.Add(dataRow);
                        line = ofile.ReadLine();
                    }
                }
                ofile.Close();
                return data;

            }
            catch (IOException ex)
            {
                FileStream fname = new FileStream("DATA/summary.txt", FileMode.OpenOrCreate);
                StreamReader ofile = new StreamReader(fname);
                ofile.Close();
                return data;        // all code paths must return a value even if empty
            }
        }

        private void newForm_Click(object sender, EventArgs e)
        {
            //Making form2 with all information appear.
           ListAndInfo frm = new ListAndInfo();
           frm.RefToForm1 = this;
           this.Visible = false;
           frm.BackColor = bcolors[cpos];
           frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //decending order of movie by thier Rating
            var descendingQuery = from data in Global.GList
                                  where data.MusOrMov == "Movie"
                                  orderby data.Rating descending
                                  select data;

            listBox1.Items.Add("Movie Based on Rating : ");
           // var wtip = from c in Global.GList where c.MusOrMov == "Movie" select c;
            foreach (var c in descendingQuery)
            {

                listBox1.Items.Add(c.ToString());
            }
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            



            float fontSize = 12; //font size 18 pts
            String fontFamily = "Times New Roman";
            richTextBox1.Font = new Font(fontFamily, fontSize, FontStyle.Bold);
            richTextBox1.SelectionBackColor = bcolors[cpos];
            this.BackColor = bcolors[cpos];
            label1.BackColor = Color.White;
            label3.BackColor = Color.Black;
            menuStrip1.BackColor = Color.Black;
            //using LINQ to query through list and finding selected in combo box
            var wtip = from c in Global.GList where c.Title == comboBox1.Text select c;
            foreach (var c in wtip)
            {
                richTextBox1.AppendText(Global.GList[comboBox1.SelectedIndex].ToString() + "\n");
            }

            cpos++;
            if (cpos >= bcolors.Length)
            {
                cpos = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            //Getting Pop music that are in List
            var wtip = from c in Global.GList where  c.Genre == "pop" select c;
            listBox1.Items.Add("Pop you like include : ");
            foreach (var c in wtip)
            {
                listBox1.Items.Add(c.ToString());
            }
        }

        private void movieRatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void bestGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
           button2_Click(sender,  e);
        }

        private void moreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm_Click(sender, e);
        }

        private void movieRatingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void bestGenreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            button2_Click(sender, e);
        }

        private void moreInfoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            newForm_Click(sender, e);
        }
    }
}
