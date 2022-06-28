namespace Prn.Se1621;

public class Employee : IComparable<Employee>
{
    public int ID { get; set; }

    public String Name { get; set; }

    public Double Salary { get; set; }

    public Employee(int iD, string name, Double salary)
    {
        ID = iD;
        Name = name;
        Salary = salary;
    }

    public override string? ToString()
    {
        return $"({this.ID},  {this.Name},  {this.Salary})";
    }

    public override bool Equals(object? obj)
    {
        if(obj == null)
            return false;
        Employee ? other = obj as Employee;
        return this.ID == other.ID;
    }

    public int CompareTo(Employee? other)
    {
        return (int)(this.Salary - other.Salary);
    }
}

