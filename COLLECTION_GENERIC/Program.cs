using System.Collections;
using System.Collections.Generic;
using Prn.Se1621;

IList<Employee> list = new List<Employee>();
list.Add(new Employee(1, "Dong", 1222.2d));
list.Add(new Employee(2, "t", 1222.2d));
list.Add(new Employee(3, "as", 1222.2d));
list.Add(new Employee(4, "ddgg", 124.5d));
list.Add(new Employee(5, "444", 12867.2d));
list.Add(new Employee(6, "Dfh", 123.2d));

Console.WriteLine($"Number of em: { list.Count}");
foreach (Employee e in list)
{
    Console.WriteLine(e);
}

SortedSet<Employee> s = new SortedSet<Employee>();
s.Add(new Employee(1, "Dong", 1222.2d));
s.Add(new Employee(2, "t", 1222.2d));
s.Add(new Employee(3, "as", 1222.2d));
s.Add(new Employee(4, "ddgg", 124.5d));
s.Add(new Employee(5, "444", 12867.2d));
s.Add(new Employee(6, "Dfh", 123.2d));

Console.WriteLine("=============================================================");
foreach (Employee e in s)
{
    Console.WriteLine(e);
}
