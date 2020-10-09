using System;
using System.IO;


namespace Program
{
  class Person
  {
    string Name;
    string Surname;
    System.DateTime DateTime;

    Person(string Name, string Surname, DateTime Datetime)
    {
      this.Name = Name;
      this.Surname = Surname;
      
    }
    Person()
    {
      Name = "pass";
      Surname = "pass";
      DateTime = DateTime.MinValue;
    }

  }
  class Program
  {
    static void Main(string[] args)
    {
     
    }
  }
}
