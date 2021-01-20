using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Contact_Information
{
    public partial class entryform : Form
    {
        public entryform()
        {
            InitializeComponent();
        }

        private void btnctn_Click(object sender, EventArgs e)
        {
            //displays the main form
            mainform instancemainform = new mainform();
            instancemainform.Show();
            //cut the entryform
            this.Dispose();

             

        }

        private void entryform_Load(object sender, EventArgs e)
        {
      
        }
    }
}
