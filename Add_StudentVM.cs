using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentData
{
    public partial class Add_StudentVM : ObservableObject
    {
        [ObservableProperty]
        public string firstname;

        [ObservableProperty]
        public string lastname;

        [ObservableProperty]
        public string birthday;

        [ObservableProperty]
        public double gpa;

        [ObservableProperty]
        public int batch;

        public Student Person { get; private set; }

        public Action Close { get; internal set; }

        public Add_StudentVM()
        {

        }
        public Add_StudentVM(Student person)
        {
            Person = person;
            firstname = Person.FirstName;
            lastname = Person.LastName;
            gpa = Person.Gpa;
            birthday = Person.Birthday;
            batch=Person.Batch;
        }

        [RelayCommand]
        public void Save()
        {
            if ((firstname == null) || (birthday == null) || (lastname == null) || (gpa == null))
            {
                MessageBox.Show("Insert All  Details.", "Error");
                return;
            }

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA must be between 0 and 4...", "Error");
               return;
            }

            if (batch < 0 || batch > 24)
                {
                MessageBox.Show("Invalid Batch Number", "Error");
                }

            if (Person == null)
            {
                Person = new Student()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Birthday = birthday,
                    Gpa = gpa,
                    Batch = batch,
                };

            }
            else
            {
                Person.FirstName = firstname;
                Person.LastName = lastname;
                Person.Gpa = gpa;
                Person.Birthday = birthday;
                Person.Batch = batch;

                MessageBox.Show("Details Saved Succesfully", "Error");
            }
           
           
        }
        
    }
}


