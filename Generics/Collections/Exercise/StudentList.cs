using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Collections.Exercise
{
    //StudentList is a class represented by a List of students.

    public class StudentList
    {

        //Targil 1 - write the Property of StudentList called Students
        #region Properties
        public List<Student> Students { get; set; }

        #endregion

        //Targil 2 - Write a constructor which initiates the students and calls for Student.FillList()
        #region Constructor
        public StudentList()
        {
            Students = Student.FillList().ToList();
        }
        #endregion



        //Targil 3- Create a dictionary where the key is the name of the Student and the value is the Student object
        #region Work with  Dictionary
        public Dictionary<string, Student> CreateDictionaryFromStudentList()
        {
            Dictionary<string, Student> studentsDic = new Dictionary<string, Student>();
            foreach (var student in Students)
            {
                studentsDic.Add(student.Name, student);
            }
            return studentsDic;
        }

        //Targil 4- write a method which retrieves a Student By name. Use the Dictionary create in Targil 3
        public Student FindStudentByName(string name)
        {
            return CreateDictionaryFromStudentList()[name];
        }
        #endregion

        #region retrieving a list
        //Targil 5-  write a method which retrieves a list of Students By Kita
        public List<Student> GetStudentsByKits(string kita)
        {
            var list = new List<Student>();
            foreach (var student in Students)
            {
                 if(student.Kita.ToString() == kita)
                {
                    list.Add(student);
                }
            }
            return list;
        }
        #endregion



    }
}
