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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            
        }

        private void panelenter_MouseClick(object sender, MouseEventArgs e)
        {
            enterform instace_of_enterform = new enterform();
            instace_of_enterform.Show();
        }

        private void panelview_MouseClick(object sender, MouseEventArgs e)
        {
            veiwform viewinstance = new veiwform();
            viewinstance.Show();

        }
    }
}
