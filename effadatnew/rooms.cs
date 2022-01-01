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
    public partial class rooms : Form
    {
        public rooms()
        {
            InitializeComponent();
        }

        private void rooms_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet1.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.effadatDataSet1.rooms);

        }
    }
}
