using effadatnew.Properties;
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
    public partial class userProfile : Form
    {
        public userProfile()
        {
            InitializeComponent();
            label1.Text = Settings.Default["userID"].ToString();

            int count = this.loginTableAdapter.FillByid(effadatDataSet.login, Convert.ToInt32(label1.Text));

            if (count > 0)
            {

              txtUser.Text = effadatDataSet.login.Rows[0]["userName"].ToString();
              txtPass.Text = effadatDataSet.login.Rows[0]["password"].ToString();
             txtFull.Text = effadatDataSet.login.Rows[0]["FullName"].ToString();


            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.effadatDataSet.login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
          int count=  loginTableAdapter.UpdateQuery1(txtUser.Text, txtPass.Text, txtFull.Text, Convert.ToInt32(label1.Text));
            if (count > 0)
            {
                MessageBox.Show("تم التعديل بنجاح");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fani fani1 = new fani();
            fani1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            employee employee1 = new employee();
            employee1.Show();
        }
    }
}
