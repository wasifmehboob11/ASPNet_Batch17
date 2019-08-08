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

namespace WinUI
{
    public partial class frmAddCountry : Form
    {
        public frmAddCountry()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Connection String
            string conString = "Data Source=.;Initial Catalog=SalesDemoBatch17;Integrated Security=True";
            // Query
            string insQuery = "Insert Into Country (Name) Values ('" + txtName.Text + "')";

            // Create Connection
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();

                SqlCommand conCommand = new SqlCommand(insQuery, con);

                conCommand.ExecuteNonQuery();

                txtName.Text = "";
                lblMessage.Text = "Inserted Successfully";
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }
    }
}
