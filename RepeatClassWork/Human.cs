using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }


        private int _age;

        public int Age { 
            get { return _age; }
            set 
            {
                if (value>0)
                {
                    this._age = value;
                    return;

                }
                throw new AgeException("Age has not below zero !!! ");
                
                
            }
        
        }


    }
}
