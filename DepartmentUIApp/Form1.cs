using DepartmentUIApp.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentUIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Department adepartment;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DeptNaneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptSaveButton_Click(object sender, EventArgs e)
        {

             adepartment = new Department(DeptCodeTextBox.Text, DeptNaneTextBox.Text);

            MessageBox.Show("Added");
        }

        private void StudentSaveButton_Click(object sender, EventArgs e)
        {
            Student astudent = new Student(RegNoTextBox.Text, NameTextBox.Text, EmaillTextBox.Text);
          String msg=  adepartment.ADD(astudent);

          MessageBox.Show(msg);
        }

        private void ShowDetailsButton_Click(object sender, EventArgs e)
        {
            String info = "DEPTCODE:\t" + adepartment.Code + " DEPTNAME\t" + adepartment.DeptName + "\n";
             info+= "RegNo\t"+ "Name\t"+"Emaill\n";
            foreach(Student astudent in adepartment.Students)
            {
                info+=astudent.regNo+"\t"+astudent.Name+"\t"+astudent.Emaill;
             
            }
            MessageBox.Show(info);
        }
    }
}
