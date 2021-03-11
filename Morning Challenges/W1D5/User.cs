using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenges.W1D5
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public int ID { get; }
        public DateTime BirthDate { get; set; }



        public User() {}
        public User(string firstname, string lastname, int id, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            ID = id;
            BirthDate = birthdate;
        }


        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
            
        }
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - BirthDate;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears));
                return yearsOfAge;
            }
        }
    }
}
