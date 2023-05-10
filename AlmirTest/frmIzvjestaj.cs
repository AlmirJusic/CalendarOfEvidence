using Microsoft.Reporting.WinForms;
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

namespace AlmirTest
{
    public partial class frmIzvjestaj : Form
    {
        public frmIzvjestaj()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;


        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = SUN-TEST; Initial Catalog = AlmirTest; Integrated Security = True");
            cmd = con.CreateCommand();

            string selectQuery = "proc_getSVE";
            cmd = new SqlCommand(selectQuery, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adp=new SqlDataAdapter(cmd);
            DataTable table=new DataTable();
            adp.Fill(table);

            ReportDataSource source = new ReportDataSource("DataSet1",table);
            
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }
    }
}
