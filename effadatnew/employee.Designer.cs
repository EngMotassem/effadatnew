namespace effadatnew
{
    partial class employee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.panel2 = new System.Windows.Forms.Panel();
            this.devgrid = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.effadatDataSet = new effadatnew.effadatDataSet();
            this.txtsearch = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnprintqarar = new MetroFramework.Controls.MetroButton();
            this.txtnumherman = new MetroFramework.Controls.MetroTextBox();
            this.txtPosition = new MetroFramework.Controls.MetroTextBox();
            this.seerTxt = new MetroFramework.Controls.MetroTextBox();
            this.txtname = new MetroFramework.Controls.MetroTextBox();
            this.txtempname = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.employeeTableAdapter = new effadatnew.effadatDataSetTableAdapters.employeeTableAdapter();
            this.RomeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new effadatnew.effadatDataSetTableAdapters.roomsTableAdapter();
            this.txtempid = new MetroFramework.Controls.MetroTextBox();
            this.txtroomid = new MetroFramework.Controls.MetroTextBox();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new effadatnew.effadatDataSetTableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new effadatnew.effadatDataSetTableAdapters.TableAdapterManager();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filenoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeePositionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shows = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.devgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(234)))), ((int)(((byte)(238)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.devgrid);
            this.panel2.Controls.Add(this.txtsearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnprintqarar);
            this.panel2.Controls.Add(this.txtnumherman);
            this.panel2.Controls.Add(this.txtPosition);
            this.panel2.Controls.Add(this.seerTxt);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Location = new System.Drawing.Point(23, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 605);
            this.panel2.TabIndex = 28;
            // 
            // devgrid
            // 
            this.devgrid.AllowUserToAddRows = false;
            this.devgrid.AllowUserToDeleteRows = false;
            this.devgrid.AllowUserToOrderColumns = true;
            this.devgrid.AllowUserToResizeColumns = false;
            this.devgrid.AllowUserToResizeRows = false;
            this.devgrid.AutoGenerateColumns = false;
            this.devgrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.devgrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.devgrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.devgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.employeeNameDataGridViewTextBoxColumn,
            this.cidDataGridViewTextBoxColumn,
            this.filenoDataGridViewTextBoxColumn,
            this.employeePositionDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.shows});
            this.devgrid.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devgrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.devgrid.EnableHeadersVisualStyles = false;
            this.devgrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.devgrid.Location = new System.Drawing.Point(22, 75);
            this.devgrid.MultiSelect = false;
            this.devgrid.Name = "devgrid";
            this.devgrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.devgrid.RowHeadersVisible = false;
            this.devgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devgrid.Size = new System.Drawing.Size(527, 492);
            this.devgrid.TabIndex = 4;
            this.devgrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devgrid_CellClick);
            this.devgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devgrid_CellContentClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.effadatDataSet;
            // 
            // effadatDataSet
            // 
            this.effadatDataSet.DataSetName = "effadatDataSet";
            this.effadatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtsearch
            // 
            // 
            // 
            // 
            this.txtsearch.CustomButton.Image = null;
            this.txtsearch.CustomButton.Location = new System.Drawing.Point(312, 1);
            this.txtsearch.CustomButton.Name = "";
            this.txtsearch.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtsearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtsearch.CustomButton.TabIndex = 1;
            this.txtsearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtsearch.CustomButton.UseSelectable = true;
            this.txtsearch.CustomButton.Visible = false;
            this.txtsearch.Lines = new string[0];
            this.txtsearch.Location = new System.Drawing.Point(113, 41);
            this.txtsearch.MaxLength = 32767;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PromptText = "بحث باسم العضو";
            this.txtsearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtsearch.SelectedText = "";
            this.txtsearch.SelectionLength = 0;
            this.txtsearch.SelectionStart = 0;
            this.txtsearch.ShortcutsEnabled = true;
            this.txtsearch.Size = new System.Drawing.Size(336, 25);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtsearch.UseSelectable = true;
            this.txtsearch.WaterMark = "بحث باسم العضو";
            this.txtsearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtsearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(84)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "كل الأعضاء";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnprintqarar
            // 
            this.btnprintqarar.Location = new System.Drawing.Point(275, 480);
            this.btnprintqarar.Name = "btnprintqarar";
            this.btnprintqarar.Size = new System.Drawing.Size(113, 29);
            this.btnprintqarar.Style = MetroFramework.MetroColorStyle.Black;
            this.btnprintqarar.TabIndex = 8;
            this.btnprintqarar.Text = "old";
            this.btnprintqarar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnprintqarar.UseSelectable = true;
            this.btnprintqarar.Visible = false;
            // 
            // txtnumherman
            // 
            // 
            // 
            // 
            this.txtnumherman.CustomButton.Image = null;
            this.txtnumherman.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.txtnumherman.CustomButton.Name = "";
            this.txtnumherman.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtnumherman.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtnumherman.CustomButton.TabIndex = 1;
            this.txtnumherman.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtnumherman.CustomButton.UseSelectable = true;
            this.txtnumherman.CustomButton.Visible = false;
            this.txtnumherman.Lines = new string[0];
            this.txtnumherman.Location = new System.Drawing.Point(143, 502);
            this.txtnumherman.MaxLength = 32767;
            this.txtnumherman.Multiline = true;
            this.txtnumherman.Name = "txtnumherman";
            this.txtnumherman.PasswordChar = '\0';
            this.txtnumherman.PromptText = "رقم اللجنة";
            this.txtnumherman.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumherman.SelectedText = "";
            this.txtnumherman.SelectionLength = 0;
            this.txtnumherman.SelectionStart = 0;
            this.txtnumherman.ShortcutsEnabled = true;
            this.txtnumherman.Size = new System.Drawing.Size(244, 29);
            this.txtnumherman.TabIndex = 15;
            this.txtnumherman.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumherman.UseSelectable = true;
            this.txtnumherman.Visible = false;
            this.txtnumherman.WaterMark = "رقم اللجنة";
            this.txtnumherman.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtnumherman.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPosition
            // 
            // 
            // 
            // 
            this.txtPosition.CustomButton.Image = null;
            this.txtPosition.CustomButton.Location = new System.Drawing.Point(363, 1);
            this.txtPosition.CustomButton.Name = "";
            this.txtPosition.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtPosition.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPosition.CustomButton.TabIndex = 1;
            this.txtPosition.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPosition.CustomButton.UseSelectable = true;
            this.txtPosition.CustomButton.Visible = false;
            this.txtPosition.Lines = new string[0];
            this.txtPosition.Location = new System.Drawing.Point(116, 432);
            this.txtPosition.MaxLength = 32767;
            this.txtPosition.Multiline = true;
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.PasswordChar = '\0';
            this.txtPosition.PromptText = "الوظيفة";
            this.txtPosition.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPosition.SelectedText = "";
            this.txtPosition.SelectionLength = 0;
            this.txtPosition.SelectionStart = 0;
            this.txtPosition.ShortcutsEnabled = true;
            this.txtPosition.Size = new System.Drawing.Size(387, 25);
            this.txtPosition.TabIndex = 12;
            this.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPosition.UseSelectable = true;
            this.txtPosition.Visible = false;
            this.txtPosition.WaterMark = "الوظيفة";
            this.txtPosition.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPosition.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // seerTxt
            // 
            // 
            // 
            // 
            this.seerTxt.CustomButton.Image = null;
            this.seerTxt.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.seerTxt.CustomButton.Name = "";
            this.seerTxt.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.seerTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.seerTxt.CustomButton.TabIndex = 1;
            this.seerTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.seerTxt.CustomButton.UseSelectable = true;
            this.seerTxt.CustomButton.Visible = false;
            this.seerTxt.Lines = new string[0];
            this.seerTxt.Location = new System.Drawing.Point(121, 490);
            this.seerTxt.MaxLength = 32767;
            this.seerTxt.Multiline = true;
            this.seerTxt.Name = "seerTxt";
            this.seerTxt.PasswordChar = '\0';
            this.seerTxt.PromptText = "لجنة السير";
            this.seerTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.seerTxt.SelectedText = "";
            this.seerTxt.SelectionLength = 0;
            this.seerTxt.SelectionStart = 0;
            this.seerTxt.ShortcutsEnabled = true;
            this.seerTxt.Size = new System.Drawing.Size(303, 25);
            this.seerTxt.TabIndex = 20;
            this.seerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.seerTxt.UseSelectable = true;
            this.seerTxt.Visible = false;
            this.seerTxt.WaterMark = "لجنة السير";
            this.seerTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.seerTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtname
            // 
            // 
            // 
            // 
            this.txtname.CustomButton.Image = null;
            this.txtname.CustomButton.Location = new System.Drawing.Point(279, 1);
            this.txtname.CustomButton.Name = "";
            this.txtname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtname.CustomButton.TabIndex = 1;
            this.txtname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtname.CustomButton.UseSelectable = true;
            this.txtname.CustomButton.Visible = false;
            this.txtname.Lines = new string[0];
            this.txtname.Location = new System.Drawing.Point(146, 471);
            this.txtname.MaxLength = 32767;
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.PasswordChar = '\0';
            this.txtname.PromptText = "العضو";
            this.txtname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtname.SelectedText = "";
            this.txtname.SelectionLength = 0;
            this.txtname.SelectionStart = 0;
            this.txtname.ShortcutsEnabled = true;
            this.txtname.Size = new System.Drawing.Size(303, 25);
            this.txtname.TabIndex = 10;
            this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtname.UseSelectable = true;
            this.txtname.Visible = false;
            this.txtname.WaterMark = "العضو";
            this.txtname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtempname
            // 
            // 
            // 
            // 
            this.txtempname.CustomButton.Image = null;
            this.txtempname.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtempname.CustomButton.Name = "";
            this.txtempname.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtempname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempname.CustomButton.TabIndex = 1;
            this.txtempname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempname.CustomButton.UseSelectable = true;
            this.txtempname.CustomButton.Visible = false;
            this.txtempname.Lines = new string[0];
            this.txtempname.Location = new System.Drawing.Point(602, 189);
            this.txtempname.MaxLength = 32767;
            this.txtempname.Multiline = true;
            this.txtempname.Name = "txtempname";
            this.txtempname.PasswordChar = '\0';
            this.txtempname.PromptText = "الاسم";
            this.txtempname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempname.SelectedText = "";
            this.txtempname.SelectionLength = 0;
            this.txtempname.SelectionStart = 0;
            this.txtempname.ShortcutsEnabled = true;
            this.txtempname.Size = new System.Drawing.Size(320, 25);
            this.txtempname.TabIndex = 41;
            this.txtempname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtempname.UseSelectable = true;
            this.txtempname.WaterMark = "الاسم";
            this.txtempname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(755, 315);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(89, 29);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButton2.TabIndex = 9;
            this.metroButton2.Text = "نقل";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // RomeComboBox
            // 
            this.RomeComboBox.DataSource = this.roomsBindingSource;
            this.RomeComboBox.DisplayMember = "roomName";
            this.RomeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RomeComboBox.FormattingEnabled = true;
            this.RomeComboBox.ItemHeight = 24;
            this.RomeComboBox.Location = new System.Drawing.Point(611, 239);
            this.RomeComboBox.Name = "RomeComboBox";
            this.RomeComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RomeComboBox.Size = new System.Drawing.Size(311, 30);
            this.RomeComboBox.TabIndex = 42;
            this.RomeComboBox.UseSelectable = true;
            this.RomeComboBox.ValueMember = "ID";
            this.RomeComboBox.SelectedIndexChanged += new System.EventHandler(this.RomeComboBox_SelectedIndexChanged);
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.effadatDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // txtempid
            // 
            // 
            // 
            // 
            this.txtempid.CustomButton.Image = null;
            this.txtempid.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtempid.CustomButton.Name = "";
            this.txtempid.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtempid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtempid.CustomButton.TabIndex = 1;
            this.txtempid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtempid.CustomButton.UseSelectable = true;
            this.txtempid.CustomButton.Visible = false;
            this.txtempid.Lines = new string[0];
            this.txtempid.Location = new System.Drawing.Point(602, 135);
            this.txtempid.MaxLength = 32767;
            this.txtempid.Multiline = true;
            this.txtempid.Name = "txtempid";
            this.txtempid.PasswordChar = '\0';
            this.txtempid.PromptText = "رقم العضو";
            this.txtempid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtempid.SelectedText = "";
            this.txtempid.SelectionLength = 0;
            this.txtempid.SelectionStart = 0;
            this.txtempid.ShortcutsEnabled = true;
            this.txtempid.Size = new System.Drawing.Size(320, 25);
            this.txtempid.TabIndex = 43;
            this.txtempid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtempid.UseSelectable = true;
            this.txtempid.WaterMark = "رقم العضو";
            this.txtempid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtempid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtroomid
            // 
            // 
            // 
            // 
            this.txtroomid.CustomButton.Image = null;
            this.txtroomid.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtroomid.CustomButton.Name = "";
            this.txtroomid.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtroomid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtroomid.CustomButton.TabIndex = 1;
            this.txtroomid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtroomid.CustomButton.UseSelectable = true;
            this.txtroomid.CustomButton.Visible = false;
            this.txtroomid.Lines = new string[0];
            this.txtroomid.Location = new System.Drawing.Point(611, 428);
            this.txtroomid.MaxLength = 32767;
            this.txtroomid.Multiline = true;
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.PasswordChar = '\0';
            this.txtroomid.PromptText = "الاسم";
            this.txtroomid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtroomid.SelectedText = "";
            this.txtroomid.SelectionLength = 0;
            this.txtroomid.SelectionStart = 0;
            this.txtroomid.ShortcutsEnabled = true;
            this.txtroomid.Size = new System.Drawing.Size(320, 25);
            this.txtroomid.TabIndex = 44;
            this.txtroomid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtroomid.UseSelectable = true;
            this.txtroomid.WaterMark = "الاسم";
            this.txtroomid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtroomid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.effadatDataSet;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.employeePunishTableAdapter = null;
            this.tableAdapterManager.employeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.PunishTableAdapter = null;
            this.tableAdapterManager.PunishTypesTableAdapter = null;
            this.tableAdapterManager.roomlagnaTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.SubjectsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = effadatnew.effadatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeNameDataGridViewTextBoxColumn
            // 
            this.employeeNameDataGridViewTextBoxColumn.DataPropertyName = "employeeName";
            this.employeeNameDataGridViewTextBoxColumn.HeaderText = "الاسم";
            this.employeeNameDataGridViewTextBoxColumn.Name = "employeeNameDataGridViewTextBoxColumn";
            // 
            // cidDataGridViewTextBoxColumn
            // 
            this.cidDataGridViewTextBoxColumn.DataPropertyName = "cid";
            this.cidDataGridViewTextBoxColumn.HeaderText = "cid";
            this.cidDataGridViewTextBoxColumn.Name = "cidDataGridViewTextBoxColumn";
            this.cidDataGridViewTextBoxColumn.Visible = false;
            // 
            // filenoDataGridViewTextBoxColumn
            // 
            this.filenoDataGridViewTextBoxColumn.DataPropertyName = "fileno";
            this.filenoDataGridViewTextBoxColumn.HeaderText = "fileno";
            this.filenoDataGridViewTextBoxColumn.Name = "filenoDataGridViewTextBoxColumn";
            this.filenoDataGridViewTextBoxColumn.Visible = false;
            // 
            // employeePositionDataGridViewTextBoxColumn
            // 
            this.employeePositionDataGridViewTextBoxColumn.DataPropertyName = "employeePosition";
            this.employeePositionDataGridViewTextBoxColumn.HeaderText = "employeePosition";
            this.employeePositionDataGridViewTextBoxColumn.Name = "employeePositionDataGridViewTextBoxColumn";
            this.employeePositionDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.Visible = false;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "roomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "الغرفة";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // shows
            // 
            this.shows.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.shows.FillWeight = 9.723158F;
            this.shows.HeaderText = "عرض";
            this.shows.Image = ((System.Drawing.Image)(resources.GetObject("shows.Image")));
            this.shows.Name = "shows";
            this.shows.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.shows.Width = 53;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 717);
            this.Controls.Add(this.txtroomid);
            this.Controls.Add(this.txtempid);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.RomeComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtempname);
            this.Name = "employee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "أعضاء الغرف";
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.devgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroTextBox txtempname;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView devgrid;
        private MetroFramework.Controls.MetroTextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnprintqarar;
        private MetroFramework.Controls.MetroTextBox txtnumherman;
        private MetroFramework.Controls.MetroTextBox txtPosition;
        private MetroFramework.Controls.MetroTextBox seerTxt;
        private MetroFramework.Controls.MetroTextBox txtname;
        private effadatDataSet effadatDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private effadatDataSetTableAdapters.employeeTableAdapter employeeTableAdapter;
        private MetroFramework.Controls.MetroComboBox RomeComboBox;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private effadatDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private MetroFramework.Controls.MetroTextBox txtempid;
        private MetroFramework.Controls.MetroTextBox txtroomid;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private effadatDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private effadatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeePositionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn shows;
    }
}