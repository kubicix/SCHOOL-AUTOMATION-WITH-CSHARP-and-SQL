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

namespace Student_Grade_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Sql_Connection bgl = new Sql_Connection();
        private void BtnTeacherLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from TblTeacher where Number=@p1 and Password=@p2",bgl.connection());
            cmd.Parameters.AddWithValue("@p1", MskTeacherNumber.Text);
            cmd.Parameters.AddWithValue("@p2",TxtTeacherPass.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                FrmTeacher frm = new FrmTeacher();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Number or Password is not correct","Warning!",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            cmd.Connection.Close();
            if(MskTeacherNumber.Text=="" || TxtTeacherPass.Text=="")
            {
                MessageBox.Show("You Forgot to enter one of the numbers.Please Try Again.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
              
        }
    }
}
