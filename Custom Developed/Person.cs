using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_Developed
{
    class Person
    {
        public string Name { get; set; }
        public string Rank { get; set; }
        public int Salary { get; set; }
        public int Prize { get; set; }
        public int Job_Hours { get; set; }

        public Person(string name, string rank, int salary, int prize, int job_Hours)
        {
            Name = name;
            Rank = rank;
            Salary = salary;
            Prize = prize;
            Job_Hours = job_Hours;
        }

        
    }
}
