using System;
using System.Reflection.PortableExecutable;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal wageEmployee = 0;
            decimal salariedEmployee = 0;
            decimal partTimeEmployee = 0;
            double totalWeeklyPay = 0;
            double highestWeeklyPay = 0;
            double lowestSalary = 100000;
            int highestWeeklyPayName = 0;
            int lowestSalaryName = 0;


            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}Resources\\employees.txt", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            string[] lines = File.ReadAllLines(FileName);

            List<Employee> People = new List<Employee>();

            
            

            foreach (string line in lines)
            {
                 if (line[0] >= '0' && line[0] <= '4')
                {
                    string[] parts = line.Split(':');
                                                           
                    //Creates a new object naming it as the value stored in objectName
                                    

                    Employee salaried = new Salaried(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]));
                    
                    People.Add(salaried);
                }

                if (line[0] >= '5' && line[0] <= '7')
                { string[] parts = line.Split(':');
                
                      Employee wages = new Wages(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8]));
                
                      People.Add(wages);
                 }

                if (line[0] >= '8' && line[0] <= '9')
                {
                    string[] parts = line.Split(':');

                    Employee partTimer = new PartTime(parts[0], parts[1], parts[2], parts[3], long.Parse(parts[4]), parts[5], parts[6], double.Parse(parts[7]), double.Parse(parts[8]));

                    People.Add(partTimer);
                }





            }

            //Tests during construction
            /*foreach (Employee employee in People)
            {
                //if the object is a salaried employee, it will use the salaried ToString method
                if (employee is Salaried)
                {
                    Console.WriteLine(((Salaried)employee).ToString());
                }
                //Console.WriteLine(employee.ToString());
            }*/

                       

            foreach (Employee employee in People)
            {

                //Console.WriteLine(employee.ToString());
                
                totalWeeklyPay += employee.GetPay();

                if (employee is Wages)
                {
                    wageEmployee += 1;
                    if (employee.GetPay() > highestWeeklyPay)
                    {
                        highestWeeklyPay = employee.GetPay();
                        highestWeeklyPayName = People.IndexOf(employee);
                    }
                }

                if (employee is Salaried)
                {
                    salariedEmployee += 1;
                    if ((employee.GetPay() * 4) < lowestSalary)
                    {
                        lowestSalary = employee.GetPay() * 4 * 12;
                        lowestSalaryName = People.IndexOf(employee);
                    }
                }

                if (employee is PartTime)
                {
                    partTimeEmployee += 1;
                }

            }

            
            
            Console.WriteLine($"The average weekly pay for all employees is: {Math.Round(totalWeeklyPay / 9, 2)}");
                      
                        
            Console.WriteLine($"The highest weekly play for the wage employees is: {highestWeeklyPay}" +
                $"\nthe employee is: {People[highestWeeklyPayName].GetName()}");

            Console.WriteLine($"The lowest salary for the salaried employees is: {lowestSalary}" +
                $"\nthe employee is: {People[lowestSalaryName].GetName()}");

           

            Console.WriteLine($"The percentage of wage employees is: {Math.Round((wageEmployee/People.Count()*100),2)}%");
            
            Console.WriteLine($"The percentage of salaried employees is: {Math.Round((salariedEmployee/People.Count()*100),2)}%");
            Console.WriteLine($"The percentage of part time employees is: {Math.Round((partTimeEmployee/People.Count()*100),2)}%");

            

            








        }
    }
}
