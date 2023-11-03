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

namespace petshopmanagementsystem
{
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
            DisplayCustomers();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");
        private void DisplayCustomers()
        {
            con.Open();
            string Query = "select * from CustomerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void clear()
        {
            CustNameTB.Text = "";
            CustAddTB.Text = "";
            CustPhoneTB.Text = "";
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaTransfarantPictureBox2_Click(object sender, EventArgs e)
        {

        }
        int key = 0;

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTB.Text == "" || CustAddTB.Text == "" || CustPhoneTB.Text == "" )
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTbl (CustName,CustAdd,CustPhone) values (@CN,@CA,@CP)", con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTB.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTB.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTB.Text);
                   

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CUSTOMER ADDED!!!");
                    con.Close();
                    DisplayCustomers();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void ustumerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustNameTB.Text = CustomerDGV.SelectedRows[0].Cells[1].Value.ToString();
            CustAddTB.Text = CustomerDGV.SelectedRows[0].Cells[2].Value.ToString();
            CustPhoneTB.Text = CustomerDGV.SelectedRows[0].Cells[3].Value.ToString();
           
            if (CustNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CustomerDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void CustPhoneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            home U = new home();
            U.Show();
            this.Hide();

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("SELECT AN CUSTOMER");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from CustomerTbl  where  CustId= @CKey", con);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CUSTOMER DELETED !!");
                    con.Close();
                    DisplayCustomers();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (CustNameTB.Text == "" || CustAddTB.Text == "" || CustPhoneTB.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update CustomerTbl set CustName=@CN,CustAdd=@CA,CustPhone=@CP where CustId=@CKey", con);
                    cmd.Parameters.AddWithValue("@CN", CustNameTB.Text);
                    cmd.Parameters.AddWithValue("@CA", CustAddTB.Text);
                    cmd.Parameters.AddWithValue("@CP", CustPhoneTB.Text);
                    cmd.Parameters.AddWithValue("@CKey", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CUSTOMER UPDATED!!!");
                    con.Close();
                    DisplayCustomers();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Bills U = new Bills();
            U.Show();
            this.Hide();
        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            login U = new login();
            U.Show();
            this.Hide();
        }
    }
}
