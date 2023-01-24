using Session_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_12 {
    public partial class SelectCourseF : Form {
        public SelectCourseF() {
            InitializeComponent();
        }

        public Course SelectedCourse { get; set; }

        private void SelectCourseF_Load(object sender, EventArgs e) {
            SetControlProperties();
            PopulateCourses();
        }


        private void SetControlProperties() {

            grvCourses.DataSource = bsCourses;

            DataGridViewComboBoxColumn colSemester = grvCourses.Columns["colSemester"] as DataGridViewComboBoxColumn;
            colSemester.Items.Add(Course.SemesterEnum.Winter);
            colSemester.Items.Add(Course.SemesterEnum.Spring);
        }

        private void PopulateCourses() {

            bsCourses.DataSource = DataHelper.GetCourses();
        }

        private void btnOk_Click(object sender, EventArgs e) {
            SelectedCourse = bsCourses.Current as Course;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
