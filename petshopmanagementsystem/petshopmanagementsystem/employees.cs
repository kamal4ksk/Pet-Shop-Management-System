using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace petshopmanagementsystem
{
    public partial class employees : Form
    {
        public employees()
        {
            InitializeComponent();
            Displayemployees();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");
        private void Displayemployees()
        {
            con.Open();
            string Query = "select * from EmployeeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            employeeDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void clear()
        {
            nameTB.Text = "";
            addTB.Text = "";
            phoneTB.Text = "";
            passwordTB.Text = "";
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void Savebtn_Click(object sender, EventArgs e)
        { //save
            if (nameTB.Text == "" || addTB.Text == "" || phoneTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EmployeeTbl (EmpName,EmpAdd,EmpDOB,EmpPhone,EmpPass) values (@EN,@EA,@ED,@EP,@EPa)", con);
                    cmd.Parameters.AddWithValue("@EN", nameTB.Text);
                    cmd.Parameters.AddWithValue("@EA", addTB.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", phoneTB.Text);
                    cmd.Parameters.AddWithValue("@EPa", passwordTB.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EMPLOYEE ADDED!!!");
                    con.Close();
                    Displayemployees();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EmpNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void employees_Load(object sender, EventArgs e)
        {

        }

        private void employeeDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
           if (nameTB.Text == "" || addTB.Text == "" || phoneTB.Text == "" || passwordTB.Text == "")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update EmployeeTbl set EmpName=@EN,EmpAdd=@EA,EmpDOB=@ED,EmpPhone=@EP,EmpPass=@EPa where EmpNum=@Ekey", con);
                    cmd.Parameters.AddWithValue("@EN", nameTB.Text);
                    cmd.Parameters.AddWithValue("@EA", addTB.Text);
                    cmd.Parameters.AddWithValue("@ED", EmpDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@EP", phoneTB.Text);
                    cmd.Parameters.AddWithValue("@EPa", passwordTB.Text);
                    cmd.Parameters.AddWithValue("@Ekey", key); 
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EMPLOYEE UPDATED!!!");
                    con.Close();
                    Displayemployees();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gunaElipsePanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("SELECT AN EMPLOYEE");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from EmployeeTbl where EmpNum=@Empkey", con);
                    cmd.Parameters.AddWithValue("@Empkey", key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("EMPLOYEE DELETED!!");
                    con.Close();
                    Displayemployees();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void employeeDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            nameTB.Text = employeeDGV.SelectedRows[0].Cells[1].Value.ToString();
            addTB.Text = employeeDGV.SelectedRows[0].Cells[2].Value.ToString();
            EmpDOB.Text = employeeDGV.SelectedRows[0].Cells[3].Value.ToString();
            phoneTB.Text = employeeDGV.SelectedRows[0].Cells[4].Value.ToString();
            passwordTB.Text = employeeDGV.SelectedRows[0].Cells[5].Value.ToString();
            if (nameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(employeeDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void phoneTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            product Obj = new product();
            Obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void EmpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void gunaElipsePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            login U = new login();
            U.Show();
            this.Hide();
        
    }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
