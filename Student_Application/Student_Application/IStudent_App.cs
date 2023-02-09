using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Application
{
    interface IStudent_App
    {
        void Add_New_Student(Student student);
        void Get_Student_Details_By_Student_ID(int ID);
        void Delete_Student_Details_By_Student_ID(int ID);
        void Update_Student_Details(Student student);
        void Get_Students_By_Department(string department);
        void Get_Students_By_Year_Of_Study(int year);
    }
}
