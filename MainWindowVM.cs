using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentData
{
    public partial class MainWindowVM : ObservableObject
    {
        public ObservableCollection<Student> Students { get; set; }

        public Student SelectedStudent { get; set; }

        public MainWindowVM()
        {
            Students = new ObservableCollection<Student>()
             {
              new Student("Nadula","Madugalle",22,"1999/11/4",3.0,"1.png"),
              new Student("Thilina ","Ekanayake",22,"1999/1/1",3.1,"2.png"),
              new Student("Ashan","Isuru",22,"2000/12/12",3.2,"3.png"),
              new Student("Gaweshi","Gunathilake",22,"2000/12/1",3.3,"4.png"),
              new Student("Sithum","Samarakoon",22,"1998/1/4",3.4,"5.png"),
              new Student("Damihta","Abeykoon",22,"2001/5/5",3.5,"6.png"),
             };
        }

        [RelayCommand]
        public void AddStudent()
        {
            var vm = new Add_StudentVM();
            Add_Student window = new Add_Student(vm);
            window.ShowDialog();

            if (vm.Person != null)
            {
                Students.Add(vm.Person);
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (SelectedStudent == null)
            {
                MessageBox.Show("You must select a student first.", "Error");
            }
            else
            {

                var vm = new Add_StudentVM(SelectedStudent);
                var window = new Add_Student(vm);
                window.ShowDialog();
                int index = Students.IndexOf(SelectedStudent);
                Students.RemoveAt(index);
                Students.Insert(index, vm.Person);
            }
        }


        [RelayCommand]
        public void DeleteStudent()
        {
            if (SelectedStudent == null)
            {
                MessageBox.Show("Select a student to delete.", "Error");
            }
            else Students.Remove(SelectedStudent);
        }
    }
}
