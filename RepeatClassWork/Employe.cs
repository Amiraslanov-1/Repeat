using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Employe
    {
        public static int _id;
        public int Id { get => _id; }

        public Employe(string name,double salary)
        {
            _id++;
            Name = name;
            Salary = salary;
        }


        public string Name { get; set; }
        public double Salary { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"Name : {Name}    Salary : {Salary}");
        }

    }
}
