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
    public partial class doc_manage_patient : UserControl
    {
        public string manage_stud_id;
        public string manage_phy_id;
        public string manage_med_rec_id;
        public string manage_fname;
        public string manage_lname;
        public string manage_age;
        public string manage_sex;
        public string manage_dateofbirth;
        public string manage_year_level;
        public string manage_contact_num;
        public string manage_address;
        public string manage_program_course;
        public string manage_emer_contact_name;
        public string manage_emer_contact_num;
        public string manage_emer_contat_address;
        

        public doc_manage_patient()
        {
            InitializeComponent();
            loading();
        }
        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.Age, students.Sex, students.DateOfBirth, students.Year_Level, students.Contact_number, students.Address, students.program_course, students.Emer_ContactName, students.Emer_ContactNum, students.emerContactAddress, physical.Physical_id, physical.Height, physical.Weight, physical.Heart_Rate, physical.Blood_Pressure, physical.Body_Temperature, medical_records.Med_rec_ID, medical_records.Medical_history, medical_records.family_history, medical_records.family_history2, medical_records.ChronicConditions, medical_records.Allergies, medical_records.Medications, medical_records.Symptoms, medical_records.Symptoms2, medical_records.LifeStyle, medical_records.habits, medical_records.Mental, medical_records.Mental2,medical_records.Vaccine FROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id;";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
        }

        private void doc_manage_patient_Load(object sender, EventArgs e)
        {
            loading();

        }

        private void stud_search_TextChanged(object sender, EventArgs e)
        {

            DbConnect search = new DbConnect();
            search.connect();


            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.Age, students.Sex, students.DateOfBirth, students.Year_Level, students.Contact_number, students.Address, students.program_course, students.Emer_ContactName, students.Emer_ContactNum, students.emerContactAddress, physical.Physical_id, physical.Height, physical.Weight, physical.Heart_Rate, physical.Blood_Pressure, physical.Body_Temperature, medical_records.Med_rec_ID, medical_records.Medical_history, medical_records.family_history, medical_records.family_history2, medical_records.ChronicConditions, medical_records.Allergies, medical_records.Medications, medical_records.Symptoms, medical_records.Symptoms2, medical_records.LifeStyle, medical_records.habits, medical_records.Mental, medical_records.Mental2,medical_records.Vaccine FROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id WHERE Firstname LIKE @search OR Age LIKE @search OR Sex LIKE @search";
            MySqlCommand cmd = new MySqlCommand(sql, search.conn);
            cmd.Parameters.AddWithValue("@search", this.stud_search.Text + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            search.disconnect();
        }

        private void stud_datagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            manage_stud_id = this.stud_datagridView.CurrentRow.Cells[0].Value.ToString();
            manage_fname = this.stud_datagridView.CurrentRow.Cells[1].Value.ToString();
            manage_lname = this.stud_datagridView.CurrentRow.Cells[2].Value.ToString();
            manage_age = this.stud_datagridView.CurrentRow.Cells[3].Value.ToString();
            manage_sex = this.stud_datagridView.CurrentRow.Cells[4].Value.ToString();
            manage_dateofbirth = this.stud_datagridView.CurrentRow.Cells[5].Value.ToString();
            manage_year_level = this.stud_datagridView.CurrentRow.Cells[6].Value.ToString();
            manage_contact_num = this.stud_datagridView.CurrentRow.Cells[7].Value.ToString();
            manage_address = this.stud_datagridView.CurrentRow.Cells[8].Value.ToString();
            manage_program_course = this.stud_datagridView.CurrentRow.Cells[9].Value.ToString();
            manage_emer_contact_name = this.stud_datagridView.CurrentRow.Cells[10].Value.ToString();
            manage_emer_contact_num  = this.stud_datagridView.CurrentRow.Cells[11].Value.ToString();
            manage_emer_contat_address = this.stud_datagridView.CurrentRow.Cells[12].Value.ToString();
            manage_phy_id = this.stud_datagridView.CurrentRow.Cells[13].Value.ToString();
            manage_med_rec_id = this.stud_datagridView.CurrentRow.Cells[14].Value.ToString();
        }
    }
}
