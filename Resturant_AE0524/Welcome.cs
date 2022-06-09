using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_AE0524
{
    public partial class frmWelcome : Form
    {
        public string user2 { get; set; }

        public frmWelcome()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void frmWelcome_Load(object sender, EventArgs e)
        { 

            lbl2.Text =user2;
          
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
           
       
        }
    
        private void btmDrinks_Click(object sender, EventArgs e)
        {
            Drinks frm2 = new Drinks();
            
            frm2.TopLevel = false;
            this.panel3.Controls.Add(frm2);
            frm2.Show();

        }

        private void btmFoods_Click(object sender, EventArgs e)
        {
            Foods frm1 = new Foods();
          
            frm1.TopLevel = false;   
            this.panel3.Controls.Add(frm1);
            frm1.Show();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
