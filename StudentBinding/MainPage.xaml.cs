using System;
using StudentBinding.Models;
using Microsoft.Maui.Controls;
namespace StudentBinding
{
    public partial class MainPage : ContentPage
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }
    private Student currentStudent;
        public Student CurrentStudent
        {
            get => currentStudent;
            set
            {
                if (currentStudent != value)
                {
                    currentStudent = value;
                    this.BindingContext = currentStudent;
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            Student1 = new Student
            {
                Name = "Noa",
                Age = 16,
                BirthDate = new DateTime(2010, 5, 7),
                Email = "noa@gmail.com",
                PhoneNumber = "054-1234567",
                ImageSource = "noa.png"
            };

            Student2 = new Student
            {
                Name = "Daniel",
                Age = 22,
                BirthDate = new DateTime(2004, 3, 30),
                Email = "daniel@example.com",
                PhoneNumber = "053-9876543",
                ImageSource = "daniel.png"
            };
            CurrentStudent = Student1;
        }
        private void OnChangeStudentButtonClicked(object sender, EventArgs e)
        {
            if (CurrentStudent == Student1)
            {
                CurrentStudent = Student2;
            }
            else
            {
                CurrentStudent = Student1;
            }
        }
    }
}