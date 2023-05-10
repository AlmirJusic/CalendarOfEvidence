using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        SqlConnection con;
        SqlCommand cmd;
        string dbContext = ConfigurationManager.ConnectionStrings["AlmirTestConnectionString"].ConnectionString;
        public frmIzvjestaj()
        {
            InitializeComponent();

            con = new SqlConnection(dbContext);
            cmd = con.CreateCommand();
        }
        


        private void frmIzvjestaj_Load(object sender, EventArgs e)
        {
            
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
