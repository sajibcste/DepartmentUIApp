using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepartmentUIApp.DAO
{
    class Department
    {
        private String code;

        public String Code
        {
            get { return code; }
        }
        private String deptName;

        public String DeptName
        {
            get { return deptName; }
        }

        List<Student> students = new List<Student>();

        internal List<Student> Students
        {
            get { return students; }
        }

        public Department(String code, String deptName)
        {
            this.code = code;
            this.deptName = deptName;
        }

        public String ADD(Student aStudent)
        {
            foreach (Student astuentObj  in Students)
            {
                if(astuentObj.regNo==aStudent.regNo)
                {
                    return "Registation Number Alredy Exit";
                }

            }
	
            students.Add(aStudent);
            return "Students added";
        }


    }
}
