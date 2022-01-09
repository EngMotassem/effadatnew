using effadatnew.Properties;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace effadatnew
{
    public partial class employee :  MetroFramework.Forms.MetroForm
    {
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet1.empPosition' table. You can move, or remove it, as needed.
            this.empPositionTableAdapter.Fill(this.effadatDataSet1.empPosition);
            // TODO: This line of code loads data into the 'effadatDataSet.DataTable1' table. You can move, or remove it, as needed.
            //   this.dataTable1TableAdapter.Fill(this.effadatDataSet.DataTable1);
            // TODO: This line of code loads data into the 'effadatDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.effadatDataSet.rooms);
            // TODO: This line of code loads data into the 'effadatDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.FillBy1(this.effadatDataSet.employee);
          //  this.employeeTableAdapter.Fill(this.effadatDataSet.employee);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void devgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void devgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    // عرض قرار سابق من الجريد
                    if (e.ColumnIndex == 7)
                    {
                        // MessageBox.Show(devgrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                        employeeTableAdapter.FillBy(effadatDataSet.employee, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));

                        //effadatDataSet.PunishDataTable list1 = effadatDataSet.Punish;

                        effadatDataSet.employeeDataTable list1 = effadatDataSet.employee;

                        if (list1.Count != 0)
                        {

                            //  RomeComboBox.SelectedIndex = RomeComboBox.Items.IndexOf(list1[0].roomID.ToString());

                            //    txtCivil.Text = list1[0].roomID.ToString();

                            
                            txtempid.Text = list1[0].ID.ToString();
                            txtempname.Text = list1[0].employeeName;


                            employeeTableAdapter.Fill(effadatDataSet.employee);

                            // txtCivil.Text = list1[0].


                        }
                        // //adabdec.FillBy(dataDataSet1.decTbl, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));

                        //// adabePunish.FillBy(dataDataSet1.employeePunish, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));


                        // dataDataSet.employeePunishDataTable list1 = dataDataSet1.employeePunish;
                        // if (list1.Count != 0)
                        // {

                        //     dateTimePicker1.Text = list1[0].punishDate;
                        //     txtCivil.Text = list1[0].civilId.ToString();
                        //     RomeComboBox.Text = list1[0].roomName;

                        //     employeeCombo1.Text = list1[0].empName;

                        //     lagnaCombo.Text = list1[0].lagnaNumber;
                        //     cmbcourse.Text = list1[0].examName;

                        //     txtreport.Text = list1[0].notes;

                        //     metroComboBox2.Text = list1[0].punishtype;


                        // }
                    }

                    // حذف قرار
                    else if (e.ColumnIndex == 9)
                    {

                        int test = 0;

                   //     txtreport.Text = devgrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                        DialogResult res = MetroMessageBox.Show(this, "هل أنت متأكد من حذف هذا القرار \n مع العلم  سيتم حذفه نهائياَ؟", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                        if (res == DialogResult.Yes)
                        {
                          //  test = punishTableAdapter.Delete(Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));

                            if (test > 0)
                            {


                                MetroMessageBox.Show(this, "تم حذف البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);
                             //   fillgrid();
                            }


                        }
                        //    {

                        //  DialogResult res = M.Show(this, "هل أنت متأكد من حذف هذا القرار \n مع العلم  سيتم حذفه نهائياَ؟", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                    }
                }
            }
            //    int test = 0;
            //    DialogResult res = MetroMessageBox.Show(this, "هل أنت متأكد من حذف هذا القرار \n مع العلم  سيتم حذفه نهائياَ؟", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);
            //    if (res == DialogResult.Yes)
            //    {

            //        //adabePunish.FillAll(dataDataSet1.employeePunish, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));


            //        adabePunish.FillBy(dataDataSet1.employeePunish, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));
            //        dataDataSet.employeePunishDataTable list = dataDataSet1.employeePunish;
            //        if (list.Count != 0)
            //        {

            //            test = adabePunish.DeleteQuery(list[0].decID);

            //            if (test == 1)
            //            {
            //                MetroMessageBox.Show(this, "تم حذف البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

            //                ShowPunishments();
            //            }

            //        }
            //    }
            //}

            //  }
            //}
            catch (Exception v)
            {
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.UpdateQuery(Convert.ToDouble(txtroomid.Text), Convert.ToInt32(txtempid.Text));

            employeeTableAdapter.UpdateQuery1();
        }

        private void RomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(RomeComboBox.SelectedIndex !=-1)
            txtroomid.Text = RomeComboBox.SelectedValue.ToString();
        }

        private void fillgrid()
        {


            this.employeeTableAdapter.FillBy1(this.effadatDataSet.employee);


            devgrid.Update();

            devgrid.Refresh();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = effadatDataSet.employee;
            string columnNameToSearch = "employeeName";
            bs.Filter = columnNameToSearch + " like '%" + txtsearch.Text + "%'";
            devgrid.DataSource = bs;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            if (txtofempame.Text !="" && txtcid.Text != "" )
                Insert_pro();
        }

        private void Insert_pro()
        {
            string conn
        = Settings.Default["effadatConnectionString"].ToString();
          //  metroTextBox2.Text = conn;

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("dbo.employee_I", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeName", txtofempame.Text);
            cmd.Parameters.AddWithValue("@cid ", Convert.ToDecimal(txtcid.Text));


            cmd.Parameters.AddWithValue("@fileno", Convert.ToDecimal( txtfileno.Text));
            cmd.Parameters.AddWithValue("@employeePosition", empPositionComboBox.Text);


            cmd.Parameters.AddWithValue("@room_id", RomComboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@roomName", RomComboBox1.Text);

          


            //SqlParameter rtnParam = new SqlParameter("@ID", SqlDbType.Int);
            //cmd.Parameters.Add(rtnParam);

            var returnParameter = cmd.Parameters.Add("@ID", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;


            cmd.ExecuteNonQuery();
            var result = returnParameter.Value;
            IDTextBox1.Text = result.ToString();


            connection.Close();
            //MessageBox("")
            fillgrid();
            MessageBox.Show("تمت الإضافة بنجاح");

        }
    }
}
