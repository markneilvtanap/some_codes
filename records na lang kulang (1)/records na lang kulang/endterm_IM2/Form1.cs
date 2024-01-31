using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace endterm_IM2
{
    public partial class Form1 : Form
    {
        public string id;
        public string fname;
        public string lname;
        public string age;
        public string sex;
        public string dob;
        public string course;
        public string level;
        public string contact;
        public string address;
        public string contactperson;
        public string contactpersonno;
        public string contactpersonadd;
        public string height;
        public string weight;
        public string bmi;
        public string hrate;
        public string bp;
        public string bt;
        public string medichistory;
        public string famhis1;
        public string famhis2;
        public string chronic;
        public string allergy;
        public string medication;
        public string symptom1;
        public string synptom2;
        public string life1;
        public string life2;
        public string mental1;
        public string mental2;
        public string vax;




        public Form1()
        {
            InitializeComponent();

            id = this.label3.Text;
            fname = this.label4.Text;
            lname = this.label5.Text;
            age = this.label8.Text;
            sex = this.label10.Text;
            dob = this.label12.Text;
            course = this.label14.Text;
            level = this.label16.Text;
            contact = this.label18.Text;
            address = this.label20.Text;
           contactperson = this.label22.Text;
            contactpersonno = this.label24.Text;
            contactpersonadd = this.label26.Text;
            height = this.label32.Text;
            weight = this.label30.Text;
            hrate = this.label38.Text;
            bp = this.label38.Text;
            bt = this.label34.Text;
            medichistory = this.label42.Text;
            famhis1 = this.label40.Text;
            famhis2 = this.label46.Text;
            chronic = this.label44.Text;
            allergy = this.label48.Text;
            medication = this.label54.Text;
            symptom1 = this.label52.Text;
            synptom2 = this.label58.Text;
            life1  = this.label56.Text;
            life2 = this.label62.Text;
            mental1 = this.label60.Text;
            mental2 = this.label64.Text;
            vax = this.label47.Text;
            
            
        }

        private void pictureBoxPrint_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = id;
            label4.Text = fname;
            label6.Text = lname;
            label8.Text = age;
            label10.Text = sex;
            label12.Text = dob;
            label14.Text = course;
            label16.Text = level;
            label18.Text = contact;
            label20.Text = address;
            label22.Text = contactperson;
            label24.Text = contactpersonno;
            label26.Text = contactpersonadd;
            label32.Text = height;
            label30.Text = weight;
            label38.Text = hrate;
            label36.Text = bp;
            label34.Text = bt;
            label42.Text = medichistory;
            label40.Text = famhis1;
            label46.Text = famhis2;
            label44.Text = chronic;
            label48.Text = allergy;
            label54.Text = medication;

            label52.Text = symptom1;
            label58.Text = synptom2;
            label56.Text = life1;
            label62.Text = life2;
            label60.Text = mental1;
            label64.Text = mental2;
            label47.Text = vax;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("monthly bill", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString("sdasd basdill", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(10, 10));

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }


    }
}
