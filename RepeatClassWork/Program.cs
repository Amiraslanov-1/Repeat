using System;
using static ConsoleApp2.Currency;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CheckCurrency
            //Console.WriteLine("Enter The Amount : ");
            //double azn=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Exchange(CurrencyType.TRY,azn));
            #endregion
            #region CheckException
            //Human human1 = new Human();
            //try
            //{  
            //    Console.WriteLine("Enter Age :");
            //    human1.Age = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (AgeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            #endregion

            Console.WriteLine("Enter Username : ");
            string username=Console.ReadLine();



            Console.WriteLine("Enter Password : ");
            string password=Console.ReadLine();
            while (!User.CheckPassword(password))
            {
                Console.WriteLine("Enter Correctly Password:");
                password = Console.ReadLine();
            }
            int role;
            bool isNum;
           

            do
            {
                Console.WriteLine("Server (1. Admin, 2. Member):");
                string roleStr = Console.ReadLine();
                isNum = int.TryParse(roleStr, out role);

            } while (!isNum || !Enum.IsDefined(typeof(Server),role));

            User user = new User(username, password, (Server)role);

            Department department = new Department(3);

            bool check = true;
            do
            {

                Console.WriteLine("-----------------Choose One From The Menu---------------");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Get Employee By Id");
                Console.WriteLine("3. Get All Employee");
                Console.WriteLine("0. Quit");


                string choice=Console.ReadLine();

                switch (choice)
                {
                 case "1":

                        try
                        {
                            if (user.RoleEnum == Server.Admin)
                            {
                                Console.WriteLine("Enter Name :");
                                string name = Console.ReadLine();

                                double salary;
                                bool isDouble;
                                do
                                {
                                    Console.WriteLine("Salary:");
                                    string salaryStr = Console.ReadLine();
                                    isDouble = double.TryParse(salaryStr, out salary);
                                } while (!isDouble);

                                Employe employe = new Employe(name, salary);

                                department.AddEmployes(employe);
                            }
                        }
                        catch (IsNotAdmin ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                       

                        
                        break;
                    case "2":
                        Console.WriteLine("Enter ID : ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        department.GetEmployeeById(id).ShowInfo();
                        break;
                    case "3":
                        foreach (var item in department.GetAllEmployees())
                        {
                            item.ShowInfo();
                        }
                        break;
                    case "0":
                        check=false;
                        break;
                    default:
                        Console.WriteLine("Wrong Input!!!");
                        break;
                }






















            } while (check);







        }


        #region Currency Method
        //static double Exchange(Enum currency,double azn )
        //{
        //    if (currency is CurrencyType)
        //    {
        //        switch (currency)
        //        {
        //            case CurrencyType.USD:
        //                return azn * 0.59;
        //                break;

        //            case CurrencyType.EURO:
        //                return azn * 0.50;
        //                break;

        //            case CurrencyType.TRY:
        //                return azn * 8.73;
        //                break;

        //            case CurrencyType.RUB:
        //                return azn * 51.32;
        //                break;

        //            case CurrencyType.GBP:
        //                return azn * 0.45;
        //                break;

        //            default:
        //                return -1;
        //                break;
        //        }
        //    }
        //    return 0;

        //}
        #endregion














    }
}
