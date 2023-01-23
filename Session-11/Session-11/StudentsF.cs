using Session_11;
using Session_11.UniClasses;
using System.Windows.Forms;

namespace Session_11 {
    public partial class StudentsF : Form {

        List<Student> students;

        public StudentsF() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            SetControlProperties();
            PopulateStudents();

        }

        private void PopulateStudents() {

            List<University> unis = DataHelper.GetUniversities();
            List<Course> courses = DataHelper.GetCourses();

            students = new List<Student>();

            Student student1 = new Student() {
                Name = "Dimitris",
                Surname = "Raptodimos",
                Gender = Student.GenderEnum.Male,
                Age = 40,
                Undergraduate = false,
                UniversityID = unis[0].ID,
            };
            students.Add(student1);
            student1.Courses.AddRange(courses.FindAll(x => x.Semester == Course.SemesterEnum.Winter));


            Student student2 = new Student() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                Gender = Student.GenderEnum.Male,
                Age = 44,
                Undergraduate = true,
                UniversityID = unis[1].ID
            };
            students.Add(student2);
            student2.Courses.AddRange(courses.FindAll(x => x.Semester == Course.SemesterEnum.Spring));

            bsStudents.DataSource = students;
            bsStudentCourses.DataSource = bsStudents;
            bsStudentCourses.DataMember = "Courses";
        }



        private void SetControlProperties() {

            grvStudents.AutoGenerateColumns = false;
            grvStudents.DataSource = bsStudents;
            grvStudentCourses.AutoGenerateColumns = false;
            grvStudentCourses.DataSource = bsStudentCourses;

            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Student.GenderEnum.Male);
            colGender.Items.Add(Student.GenderEnum.Female);
            colGender.Items.Add(Student.GenderEnum.Other);

            DataGridViewComboBoxColumn colUniversity1 = grvStudents.Columns["colUniversity"] as DataGridViewComboBoxColumn;
            colUniversity1.DataSource = DataHelper.GetUniversities();
            colUniversity1.DisplayMember = "Name";
            colUniversity1.ValueMember = "ID";


            DataGridViewComboBoxColumn colSemester = grvStudentCourses.Columns["colSemester"] as DataGridViewComboBoxColumn;
            colSemester.Items.Add(Course.SemesterEnum.Winter);
            colSemester.Items.Add(Course.SemesterEnum.Spring);

            grvStudents.CellContentClick += GrvStudents_CellContentClick;

        }

        private void GrvStudents_CellContentClick(object? sender, DataGridViewCellEventArgs e) {

            var grv = (DataGridView)sender;


            DataGridViewButtonColumn col = grv.Columns[e.ColumnIndex] as DataGridViewButtonColumn;

            if (col != null && col.Name == "colShowID" && e.RowIndex >= 0) {
                Student student = grv.CurrentRow.DataBoundItem as Student;
                MessageBox.Show($"The ID of student {student.Surname} {student.Name} is {student.ID}");
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {




        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            PopulateStudents();
        }

        private void btnAddStudent_Click(object sender, EventArgs e) {

            bsStudents.AddNew();
        }

        private void btnDelStudent_Click(object sender, EventArgs e) {
            bsStudents.RemoveCurrent();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e) {
            bsStudentCourses.RemoveCurrent();
        }

        private void btnAddCourse_Click(object sender, EventArgs e) {

            SelectCourseF courseF = new SelectCourseF();
            var res = courseF.ShowDialog();

            if (res == DialogResult.OK) {
                bsStudentCourses.Add(courseF.SelectedCourse);
            }

        }
    }
}