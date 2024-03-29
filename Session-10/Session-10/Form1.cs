using Session_10.Libs;

namespace Session_10
{
    public partial class Form1 : Form {

        private University _university;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            //PopulateData();

        }

        private void PopulateData() {
            _university = new University() {
                Name = "University of Portsmouth"
            };


            Student student1 = new Student() {
                Name = "Fotis",
                Age = 44
            };


            Student student2 = new Student() {

                Name = "Dimitris",
                Age = 40
            };


            _university.Students.Add(student1);
            _university.Students.Add(student2);
        }

        private void btnSave_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();
            serializer.SerializeToFile(_university, "university.json");

            MessageBox.Show("Save Done!");

        }

        private void btnLoad_Click(object sender, EventArgs e) {

            Serializer serializer = new Serializer();

            _university = serializer.DeserializeFromFile<University>("university.json");

            MessageBox.Show(_university.Name + " Loaded!");

        }
    }
}