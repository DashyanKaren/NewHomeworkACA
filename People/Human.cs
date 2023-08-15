using System;

public interface IHuman
{

	public string Name { get; set; }
	public string SurName { get; set; }
	public int Salary { get; set; }
}

public class Employee: Banking, IHuman
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Salary { get; set; }
    public override int CardId { get; set; }
    public override int CryptoId { get; set; }
    
    public Employee(string name, string surname)
    {
        Name = name;
        SurName=surname;
         Random random = new Random();
        CardId = random.Next(100000, 150000);
        CryptoId = random.Next(200000, 250000);
       
    }

}

public class Student:Banking, IHuman
{
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Salary { get; set; }
    public override int CardId { get; set; }
    public override int CryptoId { get; set; }
    public Student(string name, string surname)
    {
        Name = name;
        SurName = surname;
        Random random = new Random();
        CardId = random.Next(100000, 150000);
        CryptoId = random.Next(200000, 250000);
    }

}