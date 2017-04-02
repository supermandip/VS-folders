using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandip.Karki_Assignment1
{
    public partial class Form1 : Form
    {
        double people;
        String Oven = "Instruction for Oven cooking :\n 1)Keep everything cold. \n 2) Use Oil to make sure it does not stick to the pan \n 3) Bake on the bottom of your cookie sheet. \n 4)For the first batch carefully watch them and time for when they get the first hint of brown at the edges. ";
        String Microwave = "Instruction for Microwave cooking :\n First, mix powder and with milk. \n 2) add egg and stir well \n 3) let it sit for 2 min to get thick. \n 4) Prepare microwaving by shaping cookie with a spatula or a spoon. \n 5) It takes about 1 minute for me with a 700W microwave. \n 6) After 20 minutes the cookie’s still warm, so you can eat with a fork and a knife. ";
        public Form1()
        {
            InitializeComponent();
            cooking ck = new cooking(NumServed.Text);
            ck.calcIng();
            IngList.DataSource = ck.lister();
            RecipeInstr.Text = Oven;
            OvenTime();
        }

        private void OvenTime()
        {
            RecipeInstr.Text = Oven;
            RecipeInstr.BackColor = Color.Red;
            RecipeInstr.ForeColor = Color.White;
        }

        public void MicroTime()
        {
            RecipeInstr.Text = Microwave;
            RecipeInstr.BackColor = Color.Blue;
            RecipeInstr.ForeColor = Color.Yellow;
        }

        private void ChangeServeButton_Click(object sender, EventArgs e)
        {
            NumServed.Enabled = true;
            SaveServeButton.Enabled = true;
            ChangeServeButton.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About frm = new About();
            frm.Show();
        }

        private void SaveServeButton_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(NumServed.Text, out people)){
            cooking ck = new cooking(NumServed.Text);
            ck.calcIng();
            IngList.DataSource = ck.lister();
            SaveServeButton.Enabled = false;
            NumServed.Enabled = false;
            ChangeServeButton.Enabled = true;
            }
            else{
            MessageBox.Show("Only Number Can Be Entered", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NumServed.Text = "4";
                SaveServeButton.Enabled = false;
                 NumServed.Enabled = false;
            
            }

        }

        private void OvenButton_Click(object sender, EventArgs e)
        {
            OvenTime();

        }

        private void MicroButton_Click(object sender, EventArgs e)
        {
            MicroTime();
        }

        private void ovenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OvenTime();
        }

        private void microwaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MicroTime();
        }

        private void ovenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OvenTime();
        }

        private void microwaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MicroTime();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
