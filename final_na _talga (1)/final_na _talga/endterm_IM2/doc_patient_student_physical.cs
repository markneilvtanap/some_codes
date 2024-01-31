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
    public partial class doc_patient_student_physical : UserControl
    {



        public TextBox Height;
        public TextBox Weight;
        public TextBox Heart_rate;
        public TextBox Blood_pressure;
        public TextBox Body_temperature;
     
        public doc_patient_student_physical()
        {
            InitializeComponent();
            Height = this.txtbox_height;
            Weight = this.txtbox_weight;
            Heart_rate = this.txtbox_heart_rate;
            Blood_pressure = this.txtbox_blood_press;
            Body_temperature = this.txtbox_temp;
         


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void patient_student_physical_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_height_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbox_height.Text, "^[0-9]+$"))
            {
                txtbox_height.Text = "";
            }
        }

        private void txtbox_weight_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbox_weight.Text, "^[0-9]+$"))
            {
                txtbox_weight.Text = "";
            }
        }

        private void txtbox_heart_rate_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbox_heart_rate.Text, "^[0-9]+$"))
            {
                txtbox_heart_rate.Text = "";
            }
        }

        private void txtbox_temp_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtbox_temp.Text, "^[0-9]+$"))
            {
                txtbox_temp.Text = "";
            }
        }
    }
}
