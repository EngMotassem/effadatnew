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
using effadatnew.Properties;
using MetroFramework;
//using MetroFramework.Forms;

namespace effadatnew
{
    public partial class fani :  MetroFramework.Forms.MetroForm
    {
        effadatDataSet.SubjectsDataTable list = new effadatDataSet.SubjectsDataTable();
        int roomtype;

        public fani()
        {
            InitializeComponent();
        }

        private void fani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.effadatDataSet.DataTable1);
            // TODO: This line of code loads data into the 'effadatDataSet.ALlreports' table. You can move, or remove it, as needed.
            this.aLlreportsTableAdapter.Fill(this.effadatDataSet.ALlreports);
            // TODO: This line of code loads data into the 'effadatDataSet.Punish' table. You can move, or remove it, as needed.
            this.punishTableAdapter.Fill(this.effadatDataSet.Punish);
            // TODO: This line of code loads data into the 'effadatDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.effadatDataSet.employee);
            // TODO: This line of code loads data into the 'effadatDataSet2.PunishTypes' table. You can move, or remove it, as needed.
            this.punishTypesTableAdapter1.Fill(this.effadatDataSet2.PunishTypes);
            // TODO: This line of code loads data into the 'effadatDataSet.Subjects' table. You can move, or remove it, as needed.
            //  this.subjectsTableAdapter.Fill(this.effadatDataSet.Subjects);
            // TODO: This line of code loads data into the 'effadatDataSet.rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.effadatDataSet.rooms);
            RomeComboBox.SelectedIndex = -1;
            RomeComboBox.Text = "من فضلك اختر الغرفة";

        }

        private void RomeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

         




            if (RomeComboBox.SelectedIndex != -1)



            {




                roomtype = Convert.ToInt16(RomeComboBox.SelectedValue.ToString());



                RoomID.Text = this.roomsTableAdapter.getRoomID(RomeComboBox.Text).ToString();

                this.employeeTableAdapter.FillByrid(effadatDataSet.employee, Convert.ToDouble(RoomID.Text));
                employeeCombo1.DataSource = effadatDataSet.employee;
                employeeCombo1.DisplayMember = "employeeName";
                employeeCombo1.ValueMember = "ID";
               employeeCombo1.SelectedIndex =-1;
                //typedesc.Text = roomtype.ToString();
                //this.subjectsTableAdapter.FillBy(effadatDataSet.Subjects, roomtype);

                if (roomtype == 1 || roomtype==3)
                {

                    this.subjectsTableAdapter.FillBy(this.effadatDataSet.Subjects, roomtype);
                   

                    subjectCombo.DisplayMember = "subjectName";
                    subjectCombo.ValueMember = "ID";
                    //list = effadatDataSet.Subjects;
                    //cmbcourse.DataSource = list;
                    subjectCombo.DataSource = effadatDataSet.Subjects;

                }



                else  if(roomtype==2)
                {
                    this.subjectsTableAdapter.FillBy1andorder(this.effadatDataSet.Subjects);
                    

                    subjectCombo.DisplayMember = "subjectName";
                    subjectCombo.ValueMember = "ID";
                    subjectCombo.DataSource = effadatDataSet.Subjects;
                }


                else
                {
                    this.subjectsTableAdapter.FillBy(this.effadatDataSet.Subjects, 0);
                    subjectCombo.DataSource = effadatDataSet.Subjects;

                    subjectCombo.DisplayMember = "subjectName";
                    subjectCombo.ValueMember = "ID";
                }
               
               
            }

        }

      

        private void employeeCombo1_SelectedIndexChanged(object sender, EventArgs e)
        {



            if (employeeCombo1.SelectedIndex != -1 && employeeCombo1.SelectedValue.ToString() !=null)
            {

                // int selectedValue = (int)(employeeCombo1.SelectedItem);

                    metroTextBox1.Text = employeeCombo1.SelectedValue.ToString();

                  if (metroTextBox1.Text !="System.Data.DataRowView")

                 fillemplo(Convert.ToInt32(metroTextBox1.Text));


            }
        }

       

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void fillemplo(int id)
        {
            int count = employeeTableAdapter.FillBy(effadatDataSet.employee,id);

            if (count > 0)
            {
                txtCivil.Text = effadatDataSet.employee.Rows[0]["cid"].ToString();
                txtPosition.Text = effadatDataSet.employee.Rows[0]["employeePosition"].ToString();
            }


           // employeeTableAdapter.FillByrid(effadatDataSet.employee, Convert.ToDouble(RoomID.Text));
        }

        private void printEfadaBt_Click(object sender, EventArgs e)
        {

           // insert_pro();
          
           insertorUpdate();

            showpunish form1 = new showpunish(Convert.ToInt32(metroTextBox2.Text));
            form1.Show();
        }



        private void insert_pro()
        {

      //      string conn 
      //=     Settings.Default["effadatConnectionString"].ToString();
      //      metroTextBox2.Text = conn;

      //      SqlConnection connection = new SqlConnection(conn);
      //      connection.Open();
      //      SqlCommand cmd = new SqlCommand("dbo.Punish_Insert", connection);
      //      cmd.CommandType = CommandType.StoredProcedure;
      //      cmd.Parameters.AddWithValue("@empID ", Users.UserName_Details);
      //      cmd.Parameters.AddWithValue("@roomID ", Users.Password_Details);


      //      cmd.Parameters.Add("@ErrorPrint", SqlDbType.Char, 500);
      //      cmd.Parameters["@ErrorPrint"].Direction = ParameterDirection.Output;
      //      string message = cmd.Parameters["@ErrorPrint"].Value.ToString();
      //      cmd.ExecuteScalar().ToString();
      //      connection.Close();
      //      return message;
        }

        private void insertorUpdate()
        {
            int roomId=0, empid=0, puishtype=0, lagnaid=0, subjectID=0;
            string punishtext="";
            DateTime punishDate=DateTime.Today;
           if( RomeComboBox.SelectedValue !=null)
                //roomId = Convert.ToInt32(RomeComboBox.SelectedValue);
                roomId = Convert.ToInt32(RoomID.Text);

            if (employeeCombo1.SelectedValue != null)
                empid = Convert.ToInt32(employeeCombo1.SelectedValue);
            if (employeeCombo1.SelectedValue != null)
                puishtype = Convert.ToInt32(metroComboBox2.SelectedValue);

          if(  lagnaCombo.SelectedValue != null)
                lagnaid = Convert.ToInt32(lagnaCombo.SelectedValue);

            if (dateTimePicker1.Value != null)
                punishDate = dateTimePicker1.Value.Date;

            if (txtreport.Text != "")
                punishtext = txtreport.Text;

            if(subjectCombo.SelectedValue != null)
                subjectID = Convert.ToInt32(subjectCombo.SelectedValue);

            //int count = punishTableAdapter.InsertQuery(empid, roomId, lagnaid, puishtype, punishtext, subjectID, punishDate.ToString());

            string conn
          = Settings.Default["effadatConnectionString"].ToString();
            metroTextBox2.Text = conn;

            SqlConnection connection = new SqlConnection(conn);
            connection.Open();
            SqlCommand cmd = new SqlCommand("dbo.Punish_Insert", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empID ", empid);
            cmd.Parameters.AddWithValue("@roomID ", roomId);


            cmd.Parameters.AddWithValue("@lagnaID  ", lagnaid);
            cmd.Parameters.AddWithValue("@punshType  ", puishtype);


            cmd.Parameters.AddWithValue("@punishText   ", punishtext);
            cmd.Parameters.AddWithValue("@SubjectID   ", subjectID);

            cmd.Parameters.AddWithValue("@punishDate    ", punishDate);


            SqlParameter rtnParam = new SqlParameter("@ID", SqlDbType.Int);
            cmd.Parameters.Add(rtnParam);

            // cmd.Parameters.Add("@ID", SqlDbType.Int,10);
            cmd.Parameters["@ID"].Direction = ParameterDirection.Output;

            int id = Convert.ToInt32(cmd.ExecuteScalar());

            string message = id.ToString();

            
            //cmd.ExecuteNonQuery();
            connection.Close();

            metroTextBox2.Text = message;
            // return message;


            //if (count > 0)
            //{

            //    MessageBox.Show("تمت الإضافة بنجاح");
            //    int last = effadatDataSet.Punish.Rows.Count;
            //    metroTextBox2.Text=effadatDataSet.Punish.Rows[last]["ID"].ToString();
            //    //     metroTextBox2.Text = SCOPE_IDENTITY();



            //}
            // MetroFramework.Forms.MetroMessageBox.Show(this, "تم إدخال البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);

        }

        private void txtsearch_Click(object sender, EventArgs e)
        {

            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = effadatDataSet.DataTable1;
            string columnNameToSearch = "employeeName";
            bs.Filter = columnNameToSearch + " like '%" + txtsearch.Text + "%'";
            devgrid.DataSource = bs;
        }

        private void devgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void employeeCombo1_TextChanged(object sender, EventArgs e)
        //{
        //    var text = employeeCombo1.Text;

        //    if (text != "")
        //    {
        //        int count = employeeTableAdapter.FillBylike(effadatDataSet.employee, Convert.ToDouble(RoomID.Text), text);
        //        if (count > 0)
        //        {

        //            employeeCombo1.DataSource = employeeTableAdapter.FillBylike(effadatDataSet.employee, Convert.ToDouble(RoomID.Text), text);
        //            var sText = employeeCombo1.Items[0].ToString();
        //            employeeCombo1.SelectionStart = text.Length;
        //            employeeCombo1.SelectionLength = sText.Length - text.Length;
        //            employeeCombo1.DroppedDown = true;


        //            return;
        //        }
        //        else
        //        {
        //            employeeCombo1.DroppedDown = false;
        //            employeeCombo1.SelectionStart = text.Length;
        //        }
        //    }
        //}
    }
    }

