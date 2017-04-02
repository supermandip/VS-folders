using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandip.Karki_Assignment2
{
    public partial class ListAndInfo : Form
    {
        public Form RefToForm1 { get; set; }
        public ListAndInfo()
        {
            InitializeComponent();
            Doit();
            this.ControlBox = false;
        }

        public void Doit() {
            var wtip = from c in Global.GList select c;
            foreach (var c in wtip)
            {
                listBox1.Items.Add(c.ToString()); ;
            }
        
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.RefToForm1.Show();
   
        }
    }
}
