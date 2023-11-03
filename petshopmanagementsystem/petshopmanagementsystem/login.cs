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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace petshopmanagementsystem
{
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=KAMAL;Initial Catalog=petShop;Integrated Security=True");
        SqlCommand cmd;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaTransfarantPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameTB.Text = "";
            paswordTB.Text = "";
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from EmployeeTbl where(EmpName ='" + nameTB.Text + "'and EmpPass ='" + paswordTB.Text + "')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")

            {
              
                    this.Hide();
                    home form3 = new home();
                    form3.Show();
                
            }
            else
            {
                MessageBox.Show("invald username or password");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminlogin Obj = new adminlogin();
            Obj.Show();
            this.Hide();
        }

        private void loginTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
