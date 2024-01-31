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

  
    public partial class print_recordcs : UserControl
    {


        public Label id;
        public Label fname;
        public Label lname;
        public Label age, sex,
            dob;
        public Label course;
        public Label yearlevel;
        public Label contact;
        public Label address;
        public Label emercontactperson;
        public Label emercontactnum;
        public Label emercontactadd;
        public Label height;
        public Label weight;
        public Label BMI;
        public Label hearrate;
        public Label bp;
        public Label bodytemp;
        public Label medihistory;
        public Label famhistory1;
        public Label famhistory2;
        public Label chronic;
        public Label allergies;
        public Label medications;
        public Label symptoms1;
        public Label symptoms2;
        public Label methalhealth1;
        public Label methalhealth2;
        public Label vaccine;


        public print_recordcs()
        {
            InitializeComponent();
            loading();
        }

        private void stud_datagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.stud_datagridView.SelectedRows[0].Cells[0].Value.ToString();
            this.textBox2.Text = this.stud_datagridView.SelectedRows[0].Cells[1].Value.ToString();
            this.textBox3.Text = this.stud_datagridView.SelectedRows[0].Cells[2].Value.ToString();
            this.textBox4.Text = this.stud_datagridView.SelectedRows[0].Cells[9].Value.ToString();
            this.textBox5.Text = this.stud_datagridView.SelectedRows[0].Cells[6].Value.ToString();

        }

        private void stud_search_TextChanged(object sender, EventArgs e)
        {
            DbConnect search = new DbConnect();
            search.connect();


            string sql = "SELECT students.StudentID, students.FirstName, students.LastName, students.Age, students.Sex, students.DateOfBirth, students.Year_Level, students.Contact_number, students.Address, students.program_course, students.Emer_ContactName, students.Emer_ContactNum, students.emerContactAddress, physical.Physical_id, medical_records.Med_rec_ID\tFROM students JOIN physical ON physical.StudentID = students.StudentID JOIN medical_records ON medical_records.Physical_id = physical.Physical_id WHERE Firstname LIKE @search OR Age LIKE @search OR Sex LIKE @search";
            MySqlCommand cmd = new MySqlCommand(sql, search.conn);
            cmd.Parameters.AddWithValue("@search", this.stud_search.Text + "%");
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            search.disconnect();
        }

        public void loading()
        {
            DbConnect addingConnection = new DbConnect();
            addingConnection.connect();
            string sql = "SELECT DISTINCT * FROM students JOIN physical ON students.StudentID = physical.StudentID JOIN medical_records ON students.StudentID = medical_records.StudentID;";
            MySqlCommand cmd = new MySqlCommand(sql, addingConnection.conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            this.stud_datagridView.DataSource = dt;
            addingConnection.disconnect();

            
        }

        private void print_recordcs_Load(object sender, EventArgs e)
        {
            loading();
            
        }

        private void stud_datagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Form1 form1 = new Form1();
            form1.id = this.stud_datagridView.SelectedRows[0].Cells[0].Value.ToString();
            form1.fname = this.stud_datagridView.SelectedRows[0].Cells[1].Value.ToString();
            form1.lname = this.stud_datagridView.SelectedRows[0].Cells[2].Value.ToString();
            form1.age = this.stud_datagridView.SelectedRows[0].Cells[3].Value.ToString();
            form1.sex = this.stud_datagridView.SelectedRows[0].Cells[4].Value.ToString();
            form1.dob = this.stud_datagridView.SelectedRows[0].Cells[5].Value.ToString();
            form1.course = this.stud_datagridView.Rows[0].Cells[9].Value.ToString();
            form1.contact = this.stud_datagridView.Rows[0].Cells[7].Value.ToString();
            form1.level = this.stud_datagridView.Rows[0].Cells[6].Value.ToString();
            form1.address = this.stud_datagridView.Rows[0].Cells[8].Value.ToString();
            form1.contactperson = this.stud_datagridView.Rows[0].Cells[10].Value.ToString();
            form1.contactpersonno = this.stud_datagridView.Rows[0].Cells[11].Value.ToString();
            form1.contactpersonadd = this.stud_datagridView.Rows[0].Cells[12].Value.ToString();
            form1.height = this.stud_datagridView.Rows[0].Cells[15].Value.ToString() + "  cm";
            form1.weight = this.stud_datagridView.Rows[0].Cells[16].Value.ToString() + "  kl";
            form1.hrate = this.stud_datagridView.Rows[0].Cells[17].Value.ToString() + "  BPM";
            form1.bp = this.stud_datagridView.Rows[0].Cells[18].Value.ToString() + "  mmHg";
            form1.bt = this.stud_datagridView.Rows[0].Cells[19].Value.ToString() + "  degrees celcius";
            form1.medichistory = this.stud_datagridView.Rows[0].Cells[24].Value.ToString();
            form1.famhis1 = this.stud_datagridView.Rows[0].Cells[25].Value.ToString();
            form1.famhis2 = this.stud_datagridView.Rows[0].Cells[26].Value.ToString();
            form1.chronic = this.stud_datagridView.Rows[0].Cells[27].Value.ToString();
            form1.allergy = this.stud_datagridView.Rows[0].Cells[28].Value.ToString();
            form1.medication = this.stud_datagridView.Rows[0].Cells[29].Value.ToString();
            form1.symptom1 = this.stud_datagridView.Rows[0].Cells[30].Value.ToString();
            form1.synptom2 = this.stud_datagridView.Rows[0].Cells[31].Value.ToString();
            form1.life1 = this.stud_datagridView.Rows[0].Cells[32].Value.ToString();
            form1.life2 = this.stud_datagridView.Rows[0].Cells[33].Value.ToString();
            form1.mental1 = this.stud_datagridView.Rows[0].Cells[34].Value.ToString() ;
            form1.mental2 = this.stud_datagridView.Rows[0].Cells[35].Value.ToString();
            form1.vax = this.stud_datagridView.Rows[0].Cells[36].Value.ToString();





            form1.ShowDialog();

        }
    }
}
