using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentUIApp.DAO
{
     class Student
    {

        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        public String regNo;
        public String Emaill;

       public Student(String name, String regNo, String Emaill)
       {
           this.name=name;
           this.regNo=regNo;
           this.Emaill=Emaill;
       }
    }
}
