using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Session_15 {
    public partial class Form1 : Form {
       
        public Form1() {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e) {

            Cook c = new Cook();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            AppendLog(c.Bake());
            this.Refresh();

            AppendLog(c.Boil());
            this.Refresh();

            AppendLog(c.Fry());
            this.Refresh();

            watch.Stop();

            AppendLog(watch.ElapsedMilliseconds.ToString());
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void AppendLog(string s) {

            txtLog.Text += s + Environment.NewLine;
        }

        private async void btnRunAsync_Click(object sender, EventArgs e) {

            CookAsync cook = new CookAsync();

            Stopwatch watch = new Stopwatch();
            watch.Start();

            Task<string> taskBake = cook.Bake();
            Task<string> taskBoil = cook.Boil();
            Task<string> taskFry = cook.Fry();

            AppendLog("Start");

            await taskBake;
            AppendLog(taskBake.Result);
            this.Refresh();

            await taskBoil;
            AppendLog(taskBoil.Result);
            this.Refresh();

            await taskFry;
            AppendLog(taskFry.Result);
            this.Refresh();

            watch.Stop();

            AppendLog(watch.ElapsedMilliseconds.ToString());

            AppendLog("End");
        }

        private void btnTest_Click(object sender, EventArgs e) {

            //ADO.NET
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost; initial catalog=AdventureWorksLT2019; integrated security=SSPI;";
            conn.Open();


            string query = "UPDATE [AdventureWorksLT2019].[SalesLT].[Customer] SET [LastName] = 'Kountourgiannis' WHERE CustomerID = 29847";

            SqlCommand comm = new SqlCommand(query, conn);

            int rowAffected = comm.ExecuteNonQuery();

            DataSet ds = new DataSet(); // XML, XSD

            string selectQuery = Resource1.CustomerQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);

            adapter.Fill(ds);

            DataTable dt = ds.Tables[0];

            DataRow dr = dt.Rows[0];

            ds.WriteXml("fotis.xml");
            
        }
    }
}