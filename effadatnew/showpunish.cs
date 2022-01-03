using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace effadatnew
{
    public partial class showpunish : Form
    {
        public showpunish(int v)
        {
            InitializeComponent();

            this.dataTable1TableAdapter.FillBy1(effadatDataSet.DataTable1, v);

            //  this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void showpunish_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet.DataTable1' table. You can move, or remove it, as needed.
             this.dataTable1TableAdapter.Fill(this.effadatDataSet.DataTable1);
            // TODO: This line of code loads data into the 'effadatDataSet.Subjects' table. You can move, or remove it, as needed.
           // showpunish(int v)

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
