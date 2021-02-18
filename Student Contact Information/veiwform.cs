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
    public partial class veiwform : Form
    {
        public veiwform()
        {
            InitializeComponent();
        }
       
        private void veiwform_Load(object sender, EventArgs e)
        {
            //viewctrl control = new viewctrl();
            //flowLayout.Controls.Add(control);
            using( var context = new StudentDbEntity())
            {

              foreach(var student in context.Students)
              {

                    FlowLayoutPanel flow = new FlowLayoutPanel();
                    flow.FlowDirection = FlowDirection.TopDown;
                    flow.Size =  new System.Drawing.Size(180,230);
                    //aading student firstname
                    Label labelf = new Label();
                    labelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labelf.AutoSize = true;
                    labelf.Text ="Firstname:"+student.FirstName;
                    flow.Controls.Add(labelf);
                    //aading student middlename
                    Label labelm = new Label();
                    labelm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labelm.AutoSize = true;
                    labelm.Text = "Middlename: " + student.MiddleName;
                    flow.Controls.Add(labelm);
                    //aading student lastname
                    Label labell = new Label();
                    labell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labell.AutoSize = true;
                    labell.Text = "Lastname: " + student.LastName;
                    flow.Controls.Add(labell);
                    //aading student course
                    Label labelc = new Label();
                    labelc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labelc.AutoSize = true;
                    labelc.Text = "Course: " + student.Course;
                    flow.Controls.Add(labelc);
                    //aading student levelofstudy
                    Label labellev = new Label();
                    labellev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labellev.AutoSize = true;
                    labellev.Text = "Level of study: " + student.LevelOfStudy;
                    flow.Controls.Add(labellev);
                    //aading student email
                    Label labele = new Label();
                    labele.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labele.AutoSize = true;
                    labele.Text = "Email: " + student.Email;
                    flow.Controls.Add(labele);
                    //aading student cell
                    Label labelcel = new Label();
                    labelcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labelcel.AutoSize = true;
                    labelcel.Text = "Cell: " + student.Cell;
                    flow.Controls.Add(labelcel) ;
                    //aading student Address
                    Label labela = new Label();
                    labela.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5f);
                    labela.AutoSize = true;
                    labela.Text = "Address: " + student.Address;
                    flow.Controls.Add(labela);
                    //adding the subpanel to main panel
                    flowLayout.Controls.Add(flow);
                    

              }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
