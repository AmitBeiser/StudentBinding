using System;
namespace StudentBinding.Models;
public class Student : ObservableObject
{
    private string name;
    public string Name
    {
        get => name;
        set
        {
            if (name != value)
            {
                name = value;
                OnPropertyChanged();
            }
        }
    }

    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (age != value)
            {
                age = value;
                OnPropertyChanged();
            }
        }
    }

    private DateTime birthDate;
    public DateTime BirthDate
    {
        get => birthDate;
        set
        {
            if (birthDate != value)
            {
                birthDate = value;
                OnPropertyChanged();
            }
        }
    }

    private string email;
    public string Email
    {
        get => email;
        set
        {
            if (email != value)
            {
                email = value;
                OnPropertyChanged();
            }
        }
    }

    private string phoneNumber;
    public string PhoneNumber
    {
        get => phoneNumber;
        set
        {
            if (phoneNumber != value)
            {
                phoneNumber = value;
                OnPropertyChanged();
            }
        }
    }

    private string imageSource;
    public string ImageSource
    {
        get => imageSource;
        set
        {
            if (imageSource != value)
            {
                imageSource = value;
                OnPropertyChanged();
            }
        }
    }
}
