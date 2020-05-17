using System;
using System.Windows.Forms;

namespace CarProjectV1
{
    public partial class lblComp : Form
    {
        public lblComp()
        {
            InitializeComponent();
        }

        readonly MainForm backtom = new MainForm();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            return;
        }
        
        private void FORMaddNEWcar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'טבלת_אקסס_פרויקטDataSet1.orter' table. You can move, or remove it, as needed.
            this.orterTableAdapter.Fill(this.טבלת_אקסס_פרויקטDataSet1.orter);
            // TODO: This line of code loads data into the 'טבלת_אקסס_פרויקטDataSet1.cars' table. You can move, or remove it, as needed.
            this.carsTableAdapter.Fill(this.טבלת_אקסס_פרויקטDataSet1.cars);
            // TODO: This line of code loads data into the 'טבלת_אקסס_פרויקטDataSet1.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.טבלת_אקסס_פרויקטDataSet1.MODEL);

        }
        
        private void trackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mODELBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void lblComp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'טבלת_אקסס_פרויקטDataSet1.MODEL' table. You can move, or remove it, as needed.
            this.mODELTableAdapter.Fill(this.טבלת_אקסס_פרויקטDataSet1.MODEL);

        }

         private void fillByToolStripButton_Click(object sender, EventArgs e)
         {
             try
             {
                 this.mODELTableAdapter.FillBy(this.טבלת_אקסס_פרויקטDataSet1.MODEL);
             }
             catch (System.Exception ex)
             {
                 System.Windows.Forms.MessageBox.Show(ex.Message);
             }

         }
         
        
                private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
                {
                    try
                    {
                        this.mODELTableAdapter.FillBy1(this.טבלת_אקסס_פרויקטDataSet1.MODEL);
                    }
                    catch (System.Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                    }
                    

    }
}
}
