using ClientDemoWS.DemoRef;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student = ClientDemoWS.DemoRef.Student;

namespace ClientDemoWS
{
    public partial class Form1 : Form
    {
        //private List<Student> students;
        DemoRef.DemoWebServiceSoapClient service = new DemoRef.DemoWebServiceSoapClient();
        public Form1()
        {
            InitializeComponent();
            //students = new List<Student>();
            //loadDataFromService();
        }

        private void loadDataFromService()
        {
            //lstStudent.Items.Clear();

            //Console.WriteLine(service.getAll().ToList().Count());

            List<Student> students = service.getAll().ToList();
            foreach (Student student in students)
            {
                Console.WriteLine(student.name + " - " + student.address);
                lstStudent.Items.Add(student.name + " - " + student.address);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Student student = new Student() { name = txtName.Text, address = txtAddress.Text};
            var res = service.addStudent(txtName.Text, txtAddress.Text);
            Console.WriteLine(service.getAll().ToList().Count());
            Console.WriteLine(res);
            loadDataFromService();
        }
    }
}
