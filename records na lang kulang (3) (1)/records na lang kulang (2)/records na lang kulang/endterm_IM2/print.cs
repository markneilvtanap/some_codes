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
    public partial class print : Form
    {
     
        public print()
        {
            InitializeComponent();
        }

        private void print_Load(object sender, EventArgs e)
        {
          

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void updatelist(string[] data)
        {
        
        }

        private void print_recordcs1_Load(object sender, EventArgs e)
        {
           
        }

        private void print_recordcs1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
