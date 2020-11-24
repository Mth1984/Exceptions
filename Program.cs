using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nAbfangen einer NullReferenceException Exception");                         
            try
            {
                Person testPerson = null;
                testPerson.ChangeName("Mathias");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Das Objekt ist null.\n Exeption Info:\n{ex}");
            }

            
            Console.WriteLine("\nAbfangen einer IndexOutOfRangeException Exception");
            try
            {
                List<Person> personList = new List<Person>();
                personList.Add(new Person("Mathias"));
                personList[1].ChangeName("Karl");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Das Objekt ist out of range.\nExeption Info:\n{ex}");
            }

           
            Console.WriteLine("\nAbfangen mehrerer Exceptions(allgemein) mit Exception(Mutterklasse)");
            try
            {
                List<Person> personList = new List<Person>();
                personList.Add(new Person("Mathias"));
                personList[1].ChangeName("Karl");
            }
            catch (Exception ex)
            {                
                switch (ex.GetType().ToString())
                {
                    case "System.ArgumentOutOfRangeException":
                        Console.WriteLine($"Das Objekt ist out of range.\nExeption Info:\n{ex}");
                        break;
                    case "System.NullReferenceException":
                        Console.WriteLine($"Das Objekt ist null.\n Exeption Info:\n{ex}");
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("\n Abfangen einer FormatException Exception. Diese tritt auf, wenn Ihr int.Parse(XY) verwendet");
            Console.WriteLine("Gib eine Zahl ein");
            string testInputstring = Console.ReadLine();
            try
            {                
                int testInputNum = int.Parse(testInputstring);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Console Parse to Int. FormatException Input was {testInputstring}.\nExeption Info:\n{ex}");
            }

            Console.WriteLine("\n Eigene Extension Class");
            PersonList members = new PersonList();
            Person person1 = new Person("Mathias");
            Person person2 = new Person("Karl");
            Person person3 = new Person("Andrea");

            try
            {
                members.AddPerson(person1);
                members.AddPerson(person2);
                members.AddPerson(person3);
                members.AddPerson(person2);
            }
            catch (PersonExeption ex)
            {

                Console.WriteLine($"Add Person not posible! Info:\n{ex.Message}, Name: {ex.PersonName}, IDX:{ex.PersonListId}");
            }
        }
    }
}
