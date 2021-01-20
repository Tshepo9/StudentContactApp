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
    public partial class enterform : Form
    {
        public enterform()
        {
            InitializeComponent();
        }

        private void enterform_Load(object sender, EventArgs e)
        {

        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

            using (var context = new studentinfoEntities())
            {
               var student = new Student()
               {
                   FirstName = firstnametbx.Text,
                   MiddleName = middlenametbx.Text,
                   LastName = lastnametbx.Text,
                   Course = coursetbx.Text,
                   Cell = int.Parse(celltbx.Text),
                   Email = emailtbx.Text,
                   LevelOfStudy =int.Parse(lastnametbx.Text),
                   Address = addresstbx.Text,


               };

               context.Students.Add(student);
               context.SaveChanges();
           }

            firstnametbx.Text = "";
            middlenametbx.Text = "";
            lastnametbx.Text = "";
            coursetbx.Text = "";
            celltbx.Text = "";
            emailtbx.Text = "";
            leveltbx.Text = "";
            addresstbx.Text = "";
        }
    }
}
