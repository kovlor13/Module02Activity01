using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module02Activity01.Model;

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Module02Activity01.ViewModel
{

    public class StudentViewModel : INotifyPropertyChanged
    {
        //Role Of viewModel

        private Student _student;

        private string _fullName;

        public StudentViewModel()
        {
            _student = new Student { Firstname = "John", Lastname = "Doe", Age = 22 };

            LoadStudentDataCommand = new Command(async () => await LoadStudentDataAsync());

            Students = new ObservableCollection<Student>
            {

                new Student {Firstname = "CJ", Lastname = "Nuguid", Age = 22 },
                new Student {Firstname = "Lean", Lastname = "Sangalang", Age = 22 },
                new Student {Firstname = "Darwin", Lastname = "Sy", Age = 22 },
                new Student {Firstname = "Andrei", Lastname = "Agbisit", Age = 22 }

            };
        }

        public ObservableCollection<Student> Students { get; set; }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (_fullName != value)
                {
                    _fullName = value;
                    OnPropertyChanged(nameof(FullName));
                }
            }
        }
        public ICommand LoadStudentDataCommand { get; }



        private async Task LoadStudentDataAsync()
        {
            await Task.Delay(1000);
            FullName = $"{_student.Firstname} {_student.Lastname}";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}