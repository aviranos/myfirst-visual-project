using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarProjectV1
{
    public partial class MainForm : Form
    {
        public  MainForm()
        {
            InitializeComponent();
        }




        //הגדרת חלונות


        readonly loginform loginf = new loginform();


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void btnAddNewCarMain_Click(object sender, EventArgs e)
        {
            lblComp newcarform = new lblComp();
            newcarform.Show();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            formSERCHcar newserchform = new formSERCHcar();
            newserchform.Show();
        }

        public void מכוניתחדשהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblComp newcarform = new lblComp();
            newcarform.Show();

        }

        private void סגורToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            loginf.Close();
            return;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void icoEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void icoMINW_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            icoMIN.Visible = true;
            icoMAX.Visible = false;
        }

        private void btnAddNewCarMain_MouseUp(object sender, MouseEventArgs e)
        {
          btnAddNewCarMain.BackColor=Color.Green;
            

        }

        private void btnAddNewCarMain_MouseDown(object sender, EventArgs e)
        {
            btnAddNewCarMain.BackColor = Color.FromArgb(113, 179, 87);
        }
    }
}
