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
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
            DisplayProducts();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");
        private void DisplayProducts()
        {
            con.Open();
            string Query = "select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void clear()
        {
            PrNameTB.Text = "";
            PrQtyTB.Text = "";
            PrPriceTB.Text = "";
            PrCatCB.SelectedIndex = 0;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            login U = new login();
            U.Show();
            this.Hide();
    }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            employees U = new employees();
            U.Show();
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            customer U = new customer();
            U.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            customer U = new customer();
            U.Show();
            this.Hide();

        }
        int Key = 0;
        private void PrSavebtn_Click(object sender, EventArgs e)
        {
            if (PrNameTB.Text == "" || PrCatCB.Text == "" || PrQtyTB.Text == "" || PrPriceTB.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ProductTbl (PrName,PrCat,PrQty,PrPrice) values (@PN,@PC,@PQ,@PP)", con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTB.Text);
                    cmd.Parameters.AddWithValue("@PC", PrCatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", PrQtyTB.Text);
                    cmd.Parameters.AddWithValue("@PP", PrPriceTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT ADDED!!!");
                    con.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTB.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            PrCatCB.Text = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            PrQtyTB.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            PrPriceTB.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void PrDeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("SELECT AN PRODUCT!!");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ProductTbl where PrId=@Pkey", con);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT DELETED!!");
                    con.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PrEditBtn_Click(object sender, EventArgs e)
        {
            if (PrNameTB.Text == "" || PrCatCB.Text == "" || PrQtyTB.Text == "" || PrPriceTB.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update ProductTbl set PrName=@PN,PrCat=@PC,PrQty=@PQ,PrPrice=@PP where PrId=@PKey", con);
                    cmd.Parameters.AddWithValue("@PN", PrNameTB.Text);
                    cmd.Parameters.AddWithValue("@PC", PrCatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PQ", PrQtyTB.Text);
                    cmd.Parameters.AddWithValue("@PP", PrPriceTB.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT EDITED!!!");
                    con.Close();
                    DisplayProducts();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PrNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
