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
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

       
        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm mainf = new MainForm();
            mainf.Show();
            this.Hide();
        }
    }
}
