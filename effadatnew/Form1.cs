using effadatnew.effadatDataSetTableAdapters;
using effadatnew.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace effadatnew
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                int count = loginTableAdapter.FillBy(this.effadatDataSet.login, textBox1.Text, textBox2.Text);

                if (count > 0)
                {
                    int userType = Convert.ToInt16(effadatDataSet.login.Rows[0]["UserType"].ToString());

                    Settings.Default["userID"] = effadatDataSet.login.Rows[0]["ID"];


                    if (userType == 1)
                    {
                        //absent form1 = new absent();
                      //  form1.Show();
                    }
                    else
                    {
                        userProfile form1 = new userProfile();
                        form1.Show();
                    }
                }
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.effadatDataSet.login);

        }
    }
}
