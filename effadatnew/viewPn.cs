
using DevExpress.XtraReports.Parameters;
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
    public partial class viewPn : Form
    {
        public viewPn(int v)
        {
            InitializeComponent();

            Parameter parameter1 = new Parameter();
            parameter1.Name = "Parameter1";
            parameter1.Type = typeof(System.Int32);
            parameter1.Value = 25;
            var report = new XtraReport1();
            // report.Parameters.Add(parameter1);
            report.Parameters["parameter1"].Value = v;

            documentViewer1.DocumentSource = report;

            var dateParameter = new Parameter()
            {
                Name = "date",
                Type = typeof(System.DateTime),
              //  ExpressionBindings = { new BasicExpressionBinding("Value", "Now()") }
            };

         
            // Create a label and bind the label's Text property to the parameter value.
            // Use the parameter's name to reference the parameter in the label's expression.


            // Add the parameter to the report's Parameters collection.
            //report.Parameters.Add=
        }
    }
}
