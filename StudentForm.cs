using Padilla_Angelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padilla_Angelo
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            // Mock Student Data
            StudentNameLabel.Text = "Angelo Padilla";
            StudentAgeLabel.Text = "24";
            StudentAddressLabel.Text = "Cabuaan";
            StudentContactLabel.Text = "09692907324";
            StudentEmailLabel.Text = "email@sample.com";
            StudentCourseYearLabel.Text = "BSIT Third";
            ParentNameLabel.Text = "Rodolfo";
            ParentContactLabel.Text = "09123456789";
            HobbiesLabel.Text = "Eating, 3d model";
            NicknameLabel.Text = "long";
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeImageBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change Image functionality is not implemented.", "Feature Not Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void EditUpdateBtn_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this);
            this.Hide();
            editForm.Show();
        }

    }
}