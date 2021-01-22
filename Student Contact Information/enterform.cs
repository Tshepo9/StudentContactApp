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

            using (var context = new StudentDbEntity())
            {
                var student = new Student();

                student.FirstName = firstnametbx.Text;
                student.MiddleName = middlenametbx.Text;
                student.LastName = lastnametbx.Text;
                student.Course = coursetbx.Text;
                student.Cell = int.Parse(celltbx.Text);
                student.Email = emailtbx.Text;
                student.LevelOfStudy = int.Parse(leveltbx.Text);
                student.Address = addresstbx.Text;


                

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
