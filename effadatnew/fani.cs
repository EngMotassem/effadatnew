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
    public partial class fani : MetroFramework.Forms.MetroForm
    {
        effadatDataSet.SubjectsDataTable list = new effadatDataSet.SubjectsDataTable();
        int roomtype;

        public fani()
        {
            InitializeComponent();
        }

        private void fani_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'effadatDataSet.roomlagna' table. You can move, or remove it, as needed.
            this.roomlagnaTableAdapter.Fill(this.effadatDataSet.roomlagna);
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
            this.roomsTableAdapter.FillBy1(this.effadatDataSet.rooms);
         //   this.roomsTableAdapter.
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

                    roomlagnaTableAdapter.FillByri(effadatDataSet.roomlagna, Convert.ToInt32(RoomID.Text));
                    lagnaCombo.DisplayMember = "lagna_no";
                    lagnaCombo.ValueMember = "ID";
                    lagnaCombo.DataSource = effadatDataSet.roomlagna;

                }



                else  if(roomtype==2)
                {
                    this.subjectsTableAdapter.FillBy1andorder(this.effadatDataSet.Subjects);
                    

                    subjectCombo.DisplayMember = "subjectName";
                    subjectCombo.ValueMember = "ID";
                    subjectCombo.DataSource = effadatDataSet.Subjects;

                    roomlagnaTableAdapter.Fill(effadatDataSet.roomlagna);
                    lagnaCombo.DisplayMember = "lagna_no";
                    lagnaCombo.ValueMember = "ID";
                    lagnaCombo.DataSource = effadatDataSet.roomlagna;
                }


                else
                {
                    this.subjectsTableAdapter.FillBy(this.effadatDataSet.Subjects, 0);
                    subjectCombo.DataSource = effadatDataSet.Subjects;

                    subjectCombo.DisplayMember = "subjectName";
                    subjectCombo.ValueMember = "ID";

                    roomlagnaTableAdapter.FillByri(effadatDataSet.roomlagna, 0);
                    lagnaCombo.DisplayMember = "lagna_no";
                    lagnaCombo.ValueMember = "ID";
                    lagnaCombo.DataSource = effadatDataSet.roomlagna;
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
                //txtEffadatCount.Text = punishTableAdapter.COUNTOFEFFADAT(Convert.ToInt32(metroTextBox1.Text)).ToString();


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
                int empid =Convert.ToInt32( effadatDataSet.employee.Rows[0]["ID"]);
                txtEffadatCount.Text = punishTableAdapter.COUNTOFEFFADAT(empid).ToString();
            }


           // employeeTableAdapter.FillByrid(effadatDataSet.employee, Convert.ToDouble(RoomID.Text));
        }



        void directPirint(int v)
        {
            try
            {
                DevExpress.XtraReports.UI.XtraReport report = new XtraReport1();//your report class

                report.Parameters["parameter1"].Value = v;
                report.CreateDocument();
                DevExpress.XtraPrinting.PrintToolBase printTool =
               new DevExpress.XtraPrinting.PrintToolBase(report.PrintingSystem);
               // printTool.Print("HP LaserJet 400 M401 PCL 6");//select printer with name
               printTool.Print();//default printer
                roomsTableAdapter.Fill(effadatDataSet.rooms);
            }
            catch (Exception ex)
            {
              //  Response.Write(ex.Message);
                return;
            }

        }

        void directPirint()
        {
            try
            {
                XtraReportstat re = new XtraReportstat();
                DevExpress.XtraReports.UI.XtraReport report = re;//your report class

               // report.Parameters["parameter1"].Value = v;
                report.CreateDocument();
                DevExpress.XtraPrinting.PrintToolBase printTool =
               new DevExpress.XtraPrinting.PrintToolBase(report.PrintingSystem);
                // printTool.Print("HP LaserJet 400 M401 PCL 6");//select printer with name
                printTool.Print();//default printer
            }
            catch (Exception ex)
            {
                //  Response.Write(ex.Message);
                return;
            }

        }

        private void printEfadaBt_Click(object sender, EventArgs e)
        {

           insert_pro();

            // insertorUpdate();

            //showpunish form1 = new showpunish(Convert.ToInt32(metroTextBox2.Text));

            //form1.Show();

            directPirint(Convert.ToInt32(metroTextBox2.Text));
            //viewPn view = new viewPn(Convert.ToInt32(metroTextBox2.Text));
            //view.Show();
            fillgrid();
           //   roomsTableAdapter.Fill(effadatDataSet.rooms);
            //   this.dataTable1TableAdapter.Fill(this.effadatDataSet.DataTable1);
            //fillgrid();


        }

        private void directPrintemp(int empid)
        {
            try
            {
                XtraReportEmp re = new XtraReportEmp();
                DevExpress.XtraReports.UI.XtraReport report = re;//your report class

                report.Parameters["parameter1"].Value = empid;
                report.CreateDocument();
               // report.ExportToPdf(@"");
                DevExpress.XtraPrinting.PrintToolBase printTool =
               new DevExpress.XtraPrinting.PrintToolBase(report.PrintingSystem);
                // printTool.Print("HP LaserJet 400 M401 PCL 6");//select printer with name
                printTool.Print();//default printer
               // printTool.
                roomsTableAdapter.Fill(effadatDataSet.rooms);
            }
            catch (Exception ex)
            {
                //  Response.Write(ex.Message);
                return;
            }

        }



        private void insert_pro()
        {

            int roomId = 0, empid = 0, puishtype = 0, lagnaid = 0, subjectID = 0;
            string punishtext = "";
            DateTime punishDate = DateTime.Today;
            if (RomeComboBox.SelectedValue != null)
                roomId = Convert.ToInt32(RomeComboBox.SelectedValue);
               roomId = Convert.ToInt32(RoomID.Text);

            if (employeeCombo1.SelectedValue != null)
                empid = Convert.ToInt32(employeeCombo1.SelectedValue);
            if (employeeCombo1.SelectedValue != null)
                puishtype = Convert.ToInt32(metroComboBox2.SelectedValue);

            if (lagnaCombo.SelectedValue != null)
                lagnaid = Convert.ToInt32(lagnaCombo.SelectedValue);

            if (dateTimePicker1.Value != null)
                punishDate = dateTimePicker1.Value.Date;

            if (txtreport.Text != "")
                punishtext = txtreport.Text;

            if (subjectCombo.SelectedValue != null)
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


            //SqlParameter rtnParam = new SqlParameter("@ID", SqlDbType.Int);
            //cmd.Parameters.Add(rtnParam);

            var returnParameter = cmd.Parameters.Add("@ID", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            
            cmd.ExecuteNonQuery();
            var result = returnParameter.Value;


       
            connection.Close();

            metroTextBox2.Text = result.ToString();
           // roomsTableAdapter.Fill(effadatDataSet.rooms);


        }

        private void insertorUpdate()
        {
            int roomId=0, empid=0, puishtype=0, lagnaid=0, subjectID=0;
            string punishtext="";
            DateTime punishDate=DateTime.Today;
           if( RomeComboBox.SelectedValue !=null)
                roomId = Convert.ToInt32(RomeComboBox.SelectedValue);
              //  roomId = Convert.ToInt32(RoomID.Text);

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

            roomsTableAdapter.Fill(effadatDataSet.rooms);
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


        private void fillgrid()
        {


            dataTable1TableAdapter.FillBy2(effadatDataSet.DataTable1);

       


            devgrid.Refresh();
        }

        private void devgrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    // عرض قرار سابق من الجريد
                    if (e.ColumnIndex == 8)
                    {
                       // MessageBox.Show(devgrid.Rows[e.RowIndex].Cells[0].Value.ToString());

                        punishTableAdapter.FillBy(effadatDataSet.Punish, Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value));

                        effadatDataSet.PunishDataTable list1 = effadatDataSet.Punish;

                        if(list1.Count != 0)
                        {

                          //  RomeComboBox.SelectedIndex = RomeComboBox.Items.IndexOf(list1[0].roomID.ToString());

                       //    txtCivil.Text = list1[0].roomID.ToString();

                            roomsTableAdapter.FillBy(effadatDataSet.rooms,list1[0].roomID);
                            //RomeComboBox.DataSource = 

                            RomeComboBox.DisplayMember = "roomName";
                            RomeComboBox.ValueMember = "ID";

                            RoomID.Text = RomeComboBox.SelectedValue.ToString();

                            employeeTableAdapter.FillBy(effadatDataSet.employee, list1[0].empID);
                            employeeCombo1.DataSource = employeeBindingSource;
                            employeeCombo1.DisplayMember = "employeeName";
                            employeeCombo1.ValueMember = "ID";

                            txtreport.Text = list1[0].punishText;

                            dateTimePicker1.Value = list1[0].punishDate;

                            metroTextBox1.Text = list1[0].empID.ToString();
                            metroTextBox3.Text = list1[0].ID.ToString();
                            metroComboBox2.SelectedValue = list1[0].punshType;

                            txtEffadatCount.Text=punishTableAdapter.COUNTOFEFFADAT(list1[0].empID).ToString();
                            //  txtPosition.Text=list1[0].po

                            // txtCivil.Text = list1[0].
                            //       roomsTableAdapter.Fill(effadatDataSet.rooms);

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

                        txtreport.Text = devgrid.Rows[e.RowIndex].Cells[0].Value.ToString();

                         DialogResult res = MetroMessageBox.Show(this, "هل أنت متأكد من حذف هذا القرار \n مع العلم  سيتم حذفه نهائياَ؟", "معلومات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, 150);

                        if (res == DialogResult.Yes)
                        {
                            test= punishTableAdapter.Delete(Convert.ToInt32(devgrid.Rows[e.RowIndex].Cells[0].Value)) ;

                            if (test > 0)
                            {

                            
                              //  MetroMessageBox.Show(this, "تم حذف البيانات بنجاح", "معلومات ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, 100);
                                fillgrid();
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

        private void btnprintgolaph_Click(object sender, EventArgs e)
        {
            employee employee1 = new employee();
            employee1.Show();
        }

        private void subjectStaticsmetroButton_Click(object sender, EventArgs e)
        {
            directPirint();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            directPrintemp(Convert.ToInt32(metroTextBox1.Text));
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

