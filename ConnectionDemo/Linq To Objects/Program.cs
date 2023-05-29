using System;

namespace Linq_To_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> people = new List<string>();
            //people.Add("a");
            //people.Add("ab");
            //people.Add("abc");

            //var filteredPeople = from person in people
            //                     where person.Length > 2
            //                     select person;

            //foreach (var person in filteredPeople)
            //{
            //    Console.WriteLine(person);
            //}


            //Aggregate Functions
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            //numbers.Add(5);

            //int total=numbers.Aggregate((a,b)=>a+b);
            //Console.WriteLine(total);

            //int count=numbers.Count();
            //Console.WriteLine(count);

            //int min=numbers.Min();
            //Console.WriteLine(min);

            //int max=numbers.Max();
            //Console.WriteLine(max);

            //int sum = numbers.Sum();
            //Console.WriteLine(sum);



            //Sorting functions
            //var listofEmployees = from employee in Employee.GetDetails()
            //                      orderby employee.EName
            //                      select employee;

            //var listofEmployees = from employee in Employee.GetDetails()
            //                     orderby employee.EName descending
            //                     select employee;

            //var listofEmployees = Employee.GetDetails().OrderByDescending(x => x.job).ThenBy(a => a.EName);

            //foreach (var item in listofEmployees)
            //{
            //    Console.WriteLine(item.EName + " " + item.job);
            //}



            //Elementarylevel Functions

            //var employee = Employee.GetDetails().ElementAt(2);
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().ElementAtOrDefault(10);
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().First();
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().FirstOrDefault(a => a.job=="SDE");
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().Last();
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().LastOrDefault(a => a.job == "SDE");
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().Single(e=>e.EName=="Pavan");
            //Console.WriteLine(employee.EName + " " + employee.job);

            //var employee = Employee.GetDetails().SingleOrDefault(e => e.EName == "Pavannn");
            //Console.WriteLine(employee.EName + " " + employee.job);

            //string[] names = { "pavan" };
            //var strings = names.DefaultIfEmpty();

            //foreach (string item in strings)
            //{
            //    Console.WriteLine(item);
            //}

            int[] names = {};
            var strings = names.DefaultIfEmpty();

            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}