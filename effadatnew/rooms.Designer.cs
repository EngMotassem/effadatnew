namespace effadatnew
{
    partial class rooms
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.effadatDataSet1 = new effadatnew.effadatDataSet1();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colroomName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colroomType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.roomsTableAdapter = new effadatnew.effadatDataSet1TableAdapters.roomsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.roomsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(48, 41);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 438);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.effadatDataSet1;
            // 
            // effadatDataSet1
            // 
            this.effadatDataSet1.DataSetName = "effadatDataSet1";
            this.effadatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colroomName,
            this.colroomType});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(728, 539, 212, 212);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 2;
            // 
            // colroomName
            // 
            this.colroomName.Caption = "اسم الغرفة";
            this.colroomName.FieldName = "roomName";
            this.colroomName.Name = "colroomName";
            this.colroomName.Visible = true;
            this.colroomName.VisibleIndex = 0;
            // 
            // colroomType
            // 
            this.colroomType.Caption = "ادبي - ديني ";
            this.colroomType.FieldName = "roomType";
            this.colroomType.Name = "colroomType";
            this.colroomType.Visible = true;
            this.colroomType.VisibleIndex = 1;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 561);
            this.Controls.Add(this.gridControl1);
            this.Name = "rooms";
            this.Text = "rooms";
            this.Load += new System.EventHandler(this.rooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effadatDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private effadatDataSet1 effadatDataSet1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private effadatDataSet1TableAdapters.roomsTableAdapter roomsTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colroomName;
        private DevExpress.XtraGrid.Columns.GridColumn colroomType;
    }
}