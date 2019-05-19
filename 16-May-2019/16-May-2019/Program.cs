using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_May_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Bakhtiyar", "Shamilzada", new DateTime(1998, 02, 28), "123@gmail.com");
            Console.WriteLine(student1.ShortInfo());
        }
    }
    public class Student
    {
        public string FirstName;
        public string LastName;
        private string _userName;
        private string _email;
        private DateTime Birthday;

        public Student(string firstname, string lastname)
        {
            if(firstname.Trim().Length >= 2 && lastname.Trim().Length >=2)
            {
                int checkFirstNameLastName = 0;
                foreach (char letter in firstname.Trim())
                {
                    if((int)letter < 65 || (int)letter > 122)
                    {
                        Console.WriteLine("Ad yalniz herflerden ibaret olmalidir");
                    }
                    else
                    {
                        checkFirstNameLastName++;
                        break;
                    }
                }

                foreach (char letter in lastname.Trim())
                {
                    if ((int)letter < 65 || (int)letter > 122)
                    {
                        Console.WriteLine("Soyadd yalniz herflerden ibaret olmalidir");
                    }
                    else
                    {
                        checkFirstNameLastName++;
                        break;
                    }
                }

                if(checkFirstNameLastName == 2)
                {
                    FirstName = firstname;
                    LastName = lastname;
                    _userName = (firstname + lastname).ToLower();
                }
            }
            else
            {
                Console.WriteLine("Ad ve Soyad minimum 2 karakter olmalidir");
            }
        }

        public Student(string firstname, string lastname, DateTime birthday) : this(firstname, lastname)
        {
            if(birthday >= DateTime.Now)
            {
                Console.WriteLine("Dogum tarixinizi duzgun daxil edin");
            }
            else
            {
                Birthday = birthday;
            }
        }

        public Student(string firstname, string lastname, DateTime birthday, string email) : this(firstname, lastname, birthday)
        {
            if(email.IndexOf("@") == -1)
            {
                Console.WriteLine("Duzgun email daxil edin");
            }
            else
            {
                _email = email;
            }
        }

        public string ShortInfo()
        {
            return $"{FirstName} {LastName}";
        }
        public string FullInfo()
        {
            return $" Ad: {FirstName} \n " +
                $"Soyad: {LastName} \n " +
                $"Username: {_userName} \n " +
                $"Yas: {DateTime.Now.Year - Birthday.Year} \n " +
                $"Email :{_email}";
        }

        public string ShowUserName()
        {
            return _userName;
        }

        public DateTime ShowBirthday()
        {
            return Birthday;
        }

        public void ChangeBirthday(DateTime birthday)
        {
            if (birthday >= DateTime.Now)
            {
                Console.WriteLine("Dogum tarixinizi duzgun daxil edin");
            }
            else
            {
                Birthday = birthday;
            }
        }

        public string ShowEmail()
        {
            return _email;
        }

        public void ChangeEmail(string email)
        {
            if (email.IndexOf("@") == -1)
            {
                Console.WriteLine("Duzgun email daxil edin");
            }
            else
            {
                _email = email;
            }
        }
    }

}
