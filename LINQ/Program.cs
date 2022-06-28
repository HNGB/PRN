using System;
using System.Linq;

string[] names = { "Dong", "Nguyen Van A", "Cong Phuong", "A7", "Huynh Ngo Gia Bao", "Van B", "Cong Phuong" };

//1. sap xep tang dan va in ra
Array.Sort(names);
foreach(string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("-------------------");

//3. LinQ format 1

var nameAsc = names.OrderBy(n => n);

foreach (string name in nameAsc)
{
    Console.WriteLine(name);
}
Console.WriteLine("-------------------");
//lay ra tat ca ca name ma length >5

var nameLength = names.Where(n => n.Length > 5);

//4. LinQ format 2

var namesLin = from n in names where n.Length > 5 && n.Contains("B") select n;
