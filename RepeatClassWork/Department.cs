using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Department
    {
        public int EmployeLimit { get; set; }
        private Employe[] _employes;

        public Department(int employeLimit)
        {
            _employes = new Employe[0];
            EmployeLimit=employeLimit;
        }

        public  void AddEmployes(Employe employe)
        {
            if (_employes.Length<EmployeLimit)
            {
               Array.Resize(ref _employes, _employes.Length + 1);
               _employes[_employes.Length-1] = employe;
                return;
            }
            throw new LimitException("The limit has been exceeded !!! ");
        }


        public Employe GetEmployeeById(int? id)
        {
            if (id == null)
            {
                throw new ArgNullException("Argument is null");
            }

            foreach (var employe in _employes)
            {
                if (employe.Id == id)
                {
                    return employe;
                }
            }  
            return null;
        }
        
        public Employe[] GetAllEmployees()
        {
            return _employes;
        }


    }
}

