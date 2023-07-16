using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentData
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Batch { get; set; }
        public string Birthday { get; set; }
        public double Gpa { get; set; } 
        public string Image { get; set; }

        public string ImagePath
        {
            get {
                return $"/icons/{Image}";
            }
                  
        }

        public Student() { }

        public Student(string firstName, string lastName, int batch, string birthday, double gpa, string image)
        {
            FirstName = firstName;
            LastName = lastName;
            Batch = batch;
            Birthday = birthday;
            Gpa = gpa;
            Image = image;
        }
    }
}
