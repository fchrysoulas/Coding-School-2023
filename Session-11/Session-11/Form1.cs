using Session_11.Libs;

namespace Session_11 {

    public partial class Form1 : Form {

        private Classroom _classroom;



        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLoad_Click(object sender, EventArgs e) {
            
            Serializer serializer = new Serializer();

            _classroom = serializer.DeserializeFromFile<Classroom>("classroom.json");


            foreach ( Student student in _classroom.Students) {

                ctrlStudentList.Items.Add(student.Name);

            }



            
        }
    }
}