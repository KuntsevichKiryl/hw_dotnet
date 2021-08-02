using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08_02.Models
{
    abstract class Developer
    {
        Guid id = new Guid();
        string _companyName = "Macrohard";
        protected string CompanyName
        {
            get
            {
                return _companyName;
            }
        }
        string _title;
        protected string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        string _firstName;
        protected string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }
        string _lastName;
        protected string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        int _experience;
        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                _experience = value;
            }
        }
        string _responsibilities = "Knowledge of English. ";
        protected string Responsibilities
        {
            get
            {
                return _responsibilities;
            }
            set
            {
                _responsibilities += value;
            }
        }
        string _technologies;
        protected string Technologies
        {
            get
            {
                return _technologies;
            }
            set
            {
                _technologies = value;
            }
        }
        string _gitHub;
        protected string GitHub
        {
            get
            {
                return _gitHub;
            }
            set
            {
                _gitHub = value;
            }
        }
        int _salary;
        protected virtual int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                _salary = value;
            }
        }
        protected const int baseSalary = 500;

        protected Developer(string firstN, string lastN, int exp, string resp, string tech, string git)
        {
            FirstName = firstN;
            LastName = lastN;
            Experience = exp;
            Responsibilities = resp;
            Technologies = tech;
            GitHub = git;
            Salary = baseSalary;
        }

        internal void GetSalary()
        {
            Console.WriteLine($"The salary of {FirstName} {LastName} is {Salary}\n");
        }

        internal void GetResponsibilities()
        {
            Console.WriteLine($"The responsibilities of {FirstName} {LastName}: {Responsibilities}\n");
        }

        public override string ToString()
        {
            return $"Company: {CompanyName}, Full Name: {FirstName} {LastName}, Experience: {Experience}," +
                $" Title: {Title}, Salary: {Salary}, GitHub: {GitHub}";
        }
    }
}
