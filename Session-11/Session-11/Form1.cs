using Session_11.Libs;

namespace Session_11 {

    public partial class Form1 : Form {

        private Classroom _classroom;

        //TEST

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnLoad_Click(object sender, EventArgs e) {

            string fileName = "classroom.json";

            Serializer serializer = new Serializer();

            if (File.Exists(fileName)) {
                LoadData(fileName, serializer);
            }
            else {
                InitData(fileName, serializer);
            }

            DisplayData();

        }

        private void LoadData(string fileName, Serializer serializer) {
            Classroom classroom = serializer.DeserializeFromFile<Classroom>(fileName);
            _classroom = classroom;
        }

        private void DisplayData() {
            ctrlStudentList.Items.Clear();
            foreach (Student student in _classroom.Students) {
                ctrlStudentList.Items.Add(student.Name);
            }
        }

        private void InitData(string fileName, Serializer serializer) {
            _classroom = new Classroom();
            AddStudent("��������� ���������");                       
            AddStudent("���������� ��������");            
            AddStudent("������ �������");                 
            AddStudent("��� ����������");                 
            AddStudent("���������� �������");             
            AddStudent("������������� �������");          
            AddStudent("�������� ��������");              
            AddStudent("������������� ������������");     
            AddStudent("��������� �������");              
            AddStudent("���� ����");                      
            AddStudent("��������� �����");                
            AddStudent("�������� ��������");              
            AddStudent("�������� ������");                
            AddStudent("��������� �������");              
            AddStudent("�������� ��������");              
            AddStudent("������������ �������");           
            AddStudent("����������� ��������");           
            AddStudent("������� ������");                 
            AddStudent("��������������� �������");        
            AddStudent("������� ���������");              
            AddStudent("������� �������");                
            AddStudent("�������� ��������");              
            AddStudent("������ ������");                  
            AddStudent("������������ �����");
            AddStudent("������ ������");
            AddStudent("�������� �������");
            AddStudent("����� �������");
            AddStudent("����������� ����������");
            AddStudent("����������� ���������");
            AddStudent("��������� �������");

            serializer.SerializeToFile(_classroom, fileName);
        }

        private void AddStudent(string name) {
            Student student = new Student(name);
            _classroom.Students.Add(student);
        }

        private void btnDist_Click(object sender, EventArgs e) {


            ListBoxDist listDist = new ListBoxDist();
            listDist.ListBoxes.Add(listBoxBlack);
            listDist.ListBoxes.Add(listBoxRed);
            listDist.ListBoxes.Add(listBoxGreen);
            listDist.ListBoxes.Add(listBoxPurple);
            listDist.ListBoxes.Add(listBoxYellow);
            listDist.ListBoxes.Add(listBoxBlue);


            while (ctrlStudentList.Items.Count > 0) {

                Distribute(listDist);

                Thread.Sleep(200);

                this.Refresh();
            
            }

        }


        private void Distribute(ListBoxDist listDist) {


            Random r = new Random();

            int i = r.Next(ctrlStudentList.Items.Count);

            List<ListBox> availableListBoxes = listDist.ListBoxes.FindAll(x => x.Items.Count < 5);

            int j = r.Next(availableListBoxes.Count);

            availableListBoxes[j].Items.Add(ctrlStudentList.Items[i]);

            ctrlStudentList.Items.RemoveAt(i);



        }
    }
}