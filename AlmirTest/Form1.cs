
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

namespace AlmirTest
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvZaposleniciPrisustva.AutoGenerateColumns = false;
            dgvZaposleniciPrisustva.RowHeadersVisible = false;
            dgvZaposleniciPrisustva.Columns[1].DefaultCellStyle.Format = "dd-MM-yyyy";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            System.Windows.Forms.Application.VisualStyleState = VisualStyleState.NoneEnabled;


        }
        SqlConnection con;
        SqlCommand cmd;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source = SUN-TEST; Initial Catalog = AlmirTest; Integrated Security = True");
            cmd=con.CreateCommand();


            LoadZaposlenici();
            LoadVrstePrisustva();

            mpK_Calendar1.SelectedDate = DateTime.Now;

            

        }
        
        private void LoadVrstePrisustva()
        {
            try
            {
                string selectQuery = "proc_getVrstePrisustva";
                cmd = new SqlCommand(selectQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adpt = new SqlDataAdapter(selectQuery, con);
                
                DataTable table = new DataTable();
                adpt.Fill(table);

                
                cmbVrstePrisustva.DisplayMember = "Naziv";
                cmbVrstePrisustva.ValueMember = "VrstaPrisustvaID";
                cmbVrstePrisustva.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" "+ex.InnerException?.Message);
            }
            finally { con.Close(); }
        }

        private void LoadZaposlenici()
        {
            try
            {   
                string selectQuery = "proc_getZaposlenici";
                cmd=new SqlCommand(selectQuery, con);
                cmd.CommandType= CommandType.StoredProcedure;

                SqlDataAdapter adpt = new SqlDataAdapter(cmd);

                DataTable table = new DataTable();
                adpt.Fill(table);


                cmbZaposlenici.DisplayMember = "ip";
                cmbZaposlenici.ValueMember = "ZaposlenikID";
                cmbZaposlenici.DataSource = table;
        }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message+" "+ex.InnerException?.Message);
            }
            finally {con.Close();}
        }

        private void cmbZaposlenici_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           GetFilteredData();
           LoadDatumi();
           lblZaposlenik.Text= cmbZaposlenici.Text;
        }

        private void LoadDatumi()
        {
            int selectedZaposlenikID = Convert.ToInt32(cmbZaposlenici.SelectedValue);

            string selectQuery = "proc_getDatumi";

            try
            {
                con.Open();
                cmd=new SqlCommand(selectQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);
                
                DataTable table = new DataTable();
                SqlDataAdapter adapter=new SqlDataAdapter(cmd);
                adapter.Fill(table);

                MonthCalendar mc=new MonthCalendar();
                MPK_Calendar.MPK_Calendar mpk = new MPK_Calendar.MPK_Calendar();

                string vrsta = cmbVrstePrisustva.Text;
                foreach(DataRow row in table.Rows) 
                {
                    if ((int)row["ZaposlenikID"]==selectedZaposlenikID)
                    {
                        if (row["Datum"]!=DBNull.Value)
                        {
                            DateTime date = (DateTime)row["Datum"];
                            
                            mc.AddBoldedDate(date);
                           


                        }
                    } 
                    
                }
                mpK_Calendar1.BoldedDates = mc.BoldedDates;


                mpK_Calendar1.Refresh();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" "+ex.InnerException?.Message);
            }
            finally { con.Close(); }
        }

        

        private void cmbVrstePrisustva_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetFilteredData();
            dgvZaposleniciPrisustva.Columns[2].Visible = false;
        }
        private void GetFilteredData()
        {
            int selectedZaposlenikID = Convert.ToInt32(cmbZaposlenici.SelectedValue);
            int selectedVrstaPrisustvaID = Convert.ToInt32(cmbVrstePrisustva.SelectedValue);

            string selectQuery = "proc_getFilteredData";
            DataTable table = new DataTable();


            try
            {
                con.Open();
                cmd = new SqlCommand(selectQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);
                cmd.Parameters.AddWithValue("@IDVrstaPrisustva",selectedVrstaPrisustvaID);

                if (cmbVrstePrisustva.Text == "SVE")
                {

                    string selectQueryGetAll = "proc_getFilteredDataSVE";
                    cmd = new SqlCommand(selectQueryGetAll, con);
                    cmd.CommandType=CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);
                    
                }

                SqlDataReader reader =cmd.ExecuteReader();

                table.Load(reader);

                dgvZaposleniciPrisustva.DataSource= table;

                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
            }
            finally { con.Close(); }

        }
        
        private void dgvZaposleniciPrisustva_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow item in dgvZaposleniciPrisustva.Rows)
            {
                string vrsta = cmbVrstePrisustva.Text;


                if (vrsta == "DA")
                {
                    item.DefaultCellStyle.BackColor = Color.Green;
                    item.DefaultCellStyle.ForeColor = Color.White;

                }
                else if (vrsta == "NE")
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                    item.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (vrsta == "BOLOVANJE")
                {
                    item.DefaultCellStyle.BackColor = Color.Yellow;
                    item.DefaultCellStyle.ForeColor = Color.Red;
                }
                else if (vrsta == "GODISNJI")
                {
                    item.DefaultCellStyle.BackColor = Color.Gray;
                    item.DefaultCellStyle.ForeColor = Color.White;
                }
                else if (vrsta == "SVE")
                {
                    dgvZaposleniciPrisustva.Columns[2].Visible = true;


                    if (Convert.ToString(item.Cells["Prisustvo"].Value) == "DA")
                    {
                        item.DefaultCellStyle.BackColor = Color.Green;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (Convert.ToString(item.Cells["Prisustvo"].Value) == "NE")
                    {
                        item.DefaultCellStyle.BackColor = Color.Red;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                    else if (Convert.ToString(item.Cells["Prisustvo"].Value) == "BOLOVANJE")
                    {
                        item.DefaultCellStyle.BackColor = Color.Yellow;
                        item.DefaultCellStyle.ForeColor = Color.Red;
                    }
                    else if (Convert.ToString(item.Cells["Prisustvo"].Value) == "GODISNJI")
                    {
                        item.DefaultCellStyle.BackColor = Color.Gray;
                        item.DefaultCellStyle.ForeColor = Color.White;
                    }
                }
            }
        }

        private void dgvZaposleniciPrisustva_SelectionChanged(object sender, EventArgs e)
        {
            dgvZaposleniciPrisustva.ClearSelection();
        }

       

        private void dgvZaposleniciPrisustva_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex ==3 &&e.RowIndex>=0)
            {
                DialogResult result = MessageBox.Show("Jeste li sigurni da zelite izbrisati prisutnost?","Upozorenje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

                if(result== DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        int selectedID = (int)dgvZaposleniciPrisustva.Rows[e.RowIndex].Cells[0].Value;

                        string deleteQuery= "proc_deleteFromDataGridView";
                        cmd=new SqlCommand(deleteQuery, con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@ID", selectedID);
                        cmd.ExecuteNonQuery();

                        con.Close();
                        GetFilteredData();
                        LoadDatumi();

                    }
                    catch (Exception ex )
                    {

                        MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
                    }
                    finally { con.Close(); }
                }
            }
        }

        private void btnDodajPrekoKalendara_Click(object sender, EventArgs e)
        {
            int selectedZaposlenikID = Convert.ToInt32(cmbZaposlenici.SelectedValue);
            int selectedVrstaID = Convert.ToInt32(cmbVrstePrisustva.SelectedValue);
            DateTime datum = mpK_Calendar1.SelectedDate.Date;

            
            if (selectedZaposlenikID <= 0 || selectedVrstaID <= 0 || datum == DateTime.MinValue)
            {
                MessageBox.Show("Morate odabrati zaposlenika, vrstu prisustva i datum!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbVrstePrisustva.Text == "SVE")
            {
                MessageBox.Show("Morate odabrati vrstu prisustva i datum!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Provjera(datum))
            {
                MessageBox.Show("Prisustvo za odabrani datum već postoji!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                con.Open();

                
                string insertQuery = "proc_insertZaposlenikVrstaPrisustva";

                cmd = new SqlCommand(insertQuery, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);
                cmd.Parameters.AddWithValue("@IDVrstaPrisustva", selectedVrstaID);
                cmd.Parameters.AddWithValue("@Datum", datum);
                cmd.ExecuteNonQuery();

                con.Close();
                GetFilteredData();
                LoadDatumi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška pri unosu prisustva: " + ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }
            
        }

        private bool Provjera(DateTime datum)
        {
            int selectedZaposlenikID = Convert.ToInt32(cmbZaposlenici.SelectedValue);
            DataTable table = new DataTable();
            string selectQueryGetAll = "proc_getFilteredDataSVE";

            try
            {
                con.Open();
                cmd = new SqlCommand(selectQueryGetAll, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);

                SqlDataReader reader = cmd.ExecuteReader();
                table.Load(reader);

                foreach (DataRow item in table.Rows)
                {
                    if ((DateTime)item["Datum"] == datum)
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
               
                return false;
            }
            finally { con.Close(); }
        }




        private void btnIzbrisiPrekoKalendara_Click(object sender, EventArgs e)
        {
            if (cmbVrstePrisustva.Text == "SVE")
            {
                MessageBox.Show("Morate odabrati vrstu prisustva i datum!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Jeste li sigurni da zelite izbrisati prisustvo?","Upozorenje",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
               
                try
                {
                    con.Open();
                    int selectedZaposlenikID = Convert.ToInt32(cmbZaposlenici.SelectedValue);
                    int selectedVrstaID = Convert.ToInt32(cmbVrstePrisustva.SelectedValue);
                    DateTime datum = mpK_Calendar1.SelectedDate;


                    string deleteQuery = "proc_deleteZaposlenikVrstaPrisustva";
                    cmd=new SqlCommand(deleteQuery,con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IDZaposlenik", selectedZaposlenikID);
                    cmd.Parameters.AddWithValue("@IDVrstaPrisustva", selectedVrstaID);
                    cmd.Parameters.AddWithValue("@Datum",datum);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    LoadDatumi();
                    GetFilteredData();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message + " " + ex.InnerException?.Message);
                }
                finally { con.Close(); }    
            }
        }
    }
}
