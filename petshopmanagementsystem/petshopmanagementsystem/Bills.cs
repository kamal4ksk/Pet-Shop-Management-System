using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshopmanagementsystem
{
    public partial class Bills : Form
    {
        public Bills()
        {
            InitializeComponent();
          //EmpNameLb1.Text = login.employees.cs;
            GetCustomers();
            DisplayProduct();
            DisplayTranscation();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");
        private void GetCustomers()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select CustId from CustomerTbl", Con);
            SqlDataReader Rdr;
            Rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CustId", typeof(int));
            dt.Load(Rdr);
            CustIdcb.ValueMember = "CustId";
            CustIdcb.DataSource = dt;
            Con.Close();
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        private void DisplayProduct()
        {
            Con.Open();
            string Query = "Select * from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ProductDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void GetCustName()
        {
            using (SqlConnection Con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True"))
            {
        Con.Open();
        string Query = "select * from CustomerTbl where CustId='" + CustIdcb.SelectedValue.ToString() + "'";
        SqlCommand cmd = new SqlCommand(Query, Con);
        DataTable dt = new DataTable();
        SqlDataAdapter sda = new SqlDataAdapter(cmd);
        sda.Fill(dt);
        foreach (DataRow dr in dt.Rows)
        {
            CustNameTb.Text = dr["CustName"].ToString();
        }
        // The connection is automatically closed when it goes out of scope
    }
        }
        private void UpdateStock()
        {
            try
            {
                int NewQty = Stock - Convert.ToInt32(QtyTb.Text);
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl SET PrQty =@PQ WHERE PrId = @PKey", Con);
                cmd.Parameters.AddWithValue("@PQ", NewQty);
                cmd.Parameters.AddWithValue("@PKey", Key);
                cmd.ExecuteNonQuery();
                // MessageBox.Show("Product Edited!!!");
                Con.Close();
                DisplayProduct();
                //Clear();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int n = 0, GrdTotal = 0;
        private void addBtn_Click(object sender, EventArgs e)
        {
            // Check if BillDGV already has enough columns, and if not, add them.
            if (BillDGV.Columns.Count < 5)
            {
                for (int i = BillDGV.Columns.Count; i < 5; i++)
                {
                    BillDGV.Columns.Add(new DataGridViewTextBoxColumn());
                }

                // Optionally, you can set column names here:
                BillDGV.Columns[0].Name = "ID";
                BillDGV.Columns[1].Name = "Product";
                BillDGV.Columns[2].Name = "Quantity";
                BillDGV.Columns[3].Name = "Price";
                BillDGV.Columns[4].Name = "Total";
            }

            if (QtyTb.Text == "" || Convert.ToInt32(QtyTb.Text) > Stock)
            {
                MessageBox.Show("No Enough In House");
            }
            else if (QtyTb.Text == "" || Key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                int total = Convert.ToInt32(QtyTb.Text) * Convert.ToInt32(PrPriceTb.Text);
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(BillDGV);
                newRow.Cells[0].Value = n + 1;                                                                             
                newRow.Cells[1].Value = PrNameTb.Text;
                newRow.Cells[2].Value = QtyTb.Text;
                newRow.Cells[3].Value = PrPriceTb.Text;                                                                                               
                newRow.Cells[4].Value = total;
                GrdTotal = GrdTotal + total;
                BillDGV.Rows.Add(newRow);
                n++;
                TotalLbl.Text = "RS " + GrdTotal;
                UpdateStock();
                Reset();
            }

        }
        int Key = 0, Stock = 0;
        private void Reset()
        {
            PrNameTb.Text = "";
            QtyTb.Text = "";
            Stock = 0;
            Key = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            customer U = new customer();
            U.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            home U = new home();
            U.Show();
            this.Hide();
        }

        private void EmpNameLb1_Click(object sender, EventArgs e)
        {

        }

        private void BillDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TotalLbl_Click(object sender, EventArgs e)
        {

        }

        private void QtyTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }
        String prodname;
        private void PrintBtn_Click(object sender, EventArgs e)
        {
             printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();

                }
            InsertBill();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            
                e.Graphics.DrawString("PAWS - PET SHOP ", new Font("Modern No. 20", 12, FontStyle.Bold), Brushes.RoyalBlue, new Point(80));
                e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Century Gothic", 10, FontStyle.Bold), Brushes.RoyalBlue, new Point(26, 40));
                foreach (DataGridViewRow row in BillDGV.Rows)
                {

                    prodid = Convert.ToInt32(row.Cells[0].Value);
                    prodname = "" + row.Cells[1].Value;
                    prodprice = Convert.ToInt32(row.Cells[2].Value);
                    prodqty = Convert.ToInt32(row.Cells[3].Value);
                    tottal = Convert.ToInt32(row.Cells[4].Value);
                    e.Graphics.DrawString("" + prodid, new Font("Modern No. 20", 8, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                    e.Graphics.DrawString("" + prodname, new Font("Modern No. 20", 8, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                    e.Graphics.DrawString("" + prodprice, new Font("Modern No. 20", 8, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                    e.Graphics.DrawString("" + prodqty, new Font("Modern No. 20", 8, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                    e.Graphics.DrawString("" + tottal, new Font("Modern No. 20", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));
                    pos = pos + 20;
                }
                e.Graphics.DrawString("Grand Total: Rs" + GrdTotal, new Font("Modern No. 20", 12, FontStyle.Bold), Brushes.RoyalBlue, new Point(50, pos + 50));
                e.Graphics.DrawString("******** THANK YOU ********", new Font("Modern No. 20", 12, FontStyle.Bold), Brushes.RoyalBlue, new Point(10, pos + 85));
                BillDGV.Rows.Clear();
                BillDGV.Refresh();
                pos = 100;
                GrdTotal = 0;
                n = 0;
            

        }

        private void InsertBill()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into BillTbl (BDate,CustId,CustName,EmpName,Amt) values (@BD,@CI,@CN,@EN,@Am)", Con);
                cmd.Parameters.AddWithValue("@BD", DateTime.Today.Date);
                cmd.Parameters.AddWithValue("@CI", CustIdcb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@CN", CustNameTb.Text);
                cmd.Parameters.AddWithValue("@EN", EmpNameLb1.Text);
                cmd.Parameters.AddWithValue("@Am", GrdTotal);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Bill Saved!!!");
                Con.Close();
                DisplayTranscation();
              //  clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void DisplayTranscation()
        {

            Con.Open();
            string Query = "Select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            transcationDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void CustIdcb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetCustName();
        }

        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PrNameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            //Catcb.Text = ProductDGV. SelectedRows[0].Cells[2].Value.ToString();
            Stock = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[3].Value.ToString());
            PrPriceTb.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (PrNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
