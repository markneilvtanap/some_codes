using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm_IM2
{
    public partial class admin_patient : Form
    {
      
        public admin_patient()
        {
            InitializeComponent();
            loading();
        }
        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT * FROM students";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            this.student_id.Enabled = false;
            this.stud_address.Enabled = false;
            this.stud_emer_add.Enabled = false;
            this.stud_emer_name.Enabled = false;
            this.stud_emer_no.Enabled = false;
            this.stud_Fname.Enabled = false;
            this.stud_LName.Enabled = false;
            this.groupBox1.Enabled = false;
            this.stud_level.Enabled = false;
            this.dateTimePicker1.Enabled = false;

            this.stud_contact.Enabled = false;
            this.stud_age.Enabled = false;
            this.stud_course.Enabled = false;


        }

        private void stud_search_TextChanged(object sender, EventArgs e)
        {
            DbConnect search = new DbConnect();
            search.connect();


            string sql = "SELECT * FROM students WHERE Firstname LIKE @search OR Age LIKE @search OR Sex LIKE @search";
            MySqlCommand cmd = new MySqlCommand(sql, search.conn);
            cmd.Parameters.AddWithValue("@search", this.stud_search.Text + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            search.disconnect();
        }

        private void admin_patient_Load(object sender, EventArgs e)
        {

        }

        private void stud_cancel_Click(object sender, EventArgs e)
        {
            this.student_id.Clear();
            this.stud_address.Clear();
            this.stud_emer_add.Clear();
            this.stud_emer_name.Clear();
            this.stud_emer_no.Clear();
            this.stud_Fname.Clear();
            this.stud_LName.Clear();
            this.stud_level.Clear();
            
            this.stud_contact.Clear();
            this.stud_age.Clear();
            this.stud_course.Clear();

            this.student_id.Enabled = false;
            this.stud_address.Enabled = false;
            this.stud_emer_add.Enabled = false;
            this.stud_emer_name.Enabled = false;
            this.stud_emer_no.Enabled = false;
            this.stud_Fname.Enabled = false;
            this.stud_LName.Enabled = false;
            this.groupBox1.Enabled = false;
            this.stud_level.Enabled = false;
            this.dateTimePicker1.Enabled = false;

            this.stud_contact.Enabled = false;
            this.stud_age.Enabled = false;
            this.stud_course.Enabled = false;
        }

        private void stud_datagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            this. student_id.Text = this.stud_datagridView.SelectedRows[0].Cells[0].Value.ToString();
            this.stud_Fname.Text = this.stud_datagridView.SelectedRows[0].Cells[1].Value.ToString();
            this.stud_LName.Text = this.stud_datagridView.SelectedRows[0].Cells[2].Value.ToString();
            this.stud_age.Text = this.stud_datagridView.SelectedRows[0].Cells[3].Value.ToString();
            if (this.stud_datagridView.SelectedRows[0].Cells[4].Value.ToString() == "Male")
            {
                this.radioButton1.Checked = true;
            }
            else if (this.stud_datagridView.SelectedRows[0].Cells[4].Value.ToString() == "Female")
            {

                this.radioButton2.Checked = true;
            }
            this.dateTimePicker1.Text = this.stud_datagridView.SelectedRows[0].Cells[5].Value.ToString();
            this.stud_level.Text = this.stud_datagridView.SelectedRows[0].Cells[6].Value.ToString();
            this.stud_contact.Text = this.stud_datagridView.SelectedRows[0].Cells[7].Value.ToString();
            this.stud_address.Text = this.stud_datagridView.SelectedRows[0].Cells[8].Value.ToString();
            this.stud_course.Text = this.stud_datagridView.SelectedRows[0].Cells[9].Value.ToString();
            this.stud_emer_name.Text = this.stud_datagridView.SelectedRows[0].Cells[10].Value.ToString();
            this.stud_emer_add.Text = this.stud_datagridView.SelectedRows[0].Cells[11].Value.ToString();
            this.stud_emer_no.Text = this.stud_datagridView.SelectedRows[0].Cells[12].Value.ToString();
           
        }

        private void stud_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                DbConnect connectionDelete = new DbConnect();
                connectionDelete.connect();

                string sqlDelete = "DELETE FROM students WHERE StudentID = @StudentID";
                using (MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, connectionDelete.conn))
                {
                    cmdDelete.Parameters.AddWithValue("@StudentID", this.student_id.Text);
                    cmdDelete.ExecuteNonQuery();
                }

                MessageBox.Show("Record has been deleted!", "Success");
          
                connectionDelete.disconnect();
                loading();
            }
        }

        private void stud_edit_Click(object sender, EventArgs e)
        {
            if (stud_edit.Text == "EDIT")
            {
                stud_edit.Text = "UPDATE";
                this.student_id.Enabled = false;
                this.stud_address.Enabled = true;
                this.stud_age.Enabled = true;
                this.stud_contact.Enabled = true;
                this.stud_course.Enabled = true;
                this.groupBox1.Enabled = true;
                this.dateTimePicker1.Enabled = true;
                this.stud_emer_add.Enabled = true;
                this.stud_emer_name.Enabled = true;
                this.stud_emer_no.Enabled = true;
                this.stud_Fname.Enabled = true;
                this.stud_LName.Enabled = true;
                this.stud_course.Enabled = true;
                this.stud_level.Enabled = true;
            }
            else if (stud_edit.Text == "UPDATE")
            {

                DbConnect connectionUpdate = new DbConnect();
                connectionUpdate.connect();
                string sqlUpdate = "UPDATE `students` SET `FirstName` = '" + this.stud_Fname.Text + "', `LastName` = '" + this.stud_LName.Text + "', `Age` = '" + this.stud_age.Text + "', `Sex` = '" + this.groupBox1.Text + "', `Year_Level` = 'asdas', `Address` = 'asdasd', `program_course` = 'asdasd', `Emer_ContactName` = 'asdasd', `Emer_ContactNum` = '434321321', `emerContactAddress` = 'asdas' WHERE `students`.`StudentID` = '21'";
               //"UPDATE `students` SET FirstName = '" + this.stud_Fname.Text + "', LastName = '', Age = '', Sex = '', DateOfBirth = '" + this.dateTimePicker1.Text + "', Year_Level = '" + this.stud_level.Text + "', Contact_number = '" + this.stud_contact.Text + "', Address='" + this.stud_address.Text + "',program_course='" + this.stud_course.Text + "', Emer_ContactName= '" + this.stud_emer_name.Text + "', Emer_ContactNum = '" + this.stud_emer_no.Text + "', emerContactAddress= '" + this.stud_emer_add.Text + "' WHERE StudentID = '" + student_id + "'";
                MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, connectionUpdate.conn);
                MySqlDataReader reader = cmdUpdate.ExecuteReader();
                MessageBox.Show("RECORD HAS BEEN UPDATED!", "Success");
                stud_edit.Text = "EDIT";
                loading();
                connectionUpdate.disconnect();
            }

        }
    }
}
