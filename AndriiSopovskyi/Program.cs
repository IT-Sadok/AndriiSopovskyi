using System;
using System.Collections.Generic;
namespace AndriiSopovskyi;

public class Apartment
{
    public int Id;
    public string Title;
    public int Price;
}

public class Host
{
    public int Id;
    public string Name;
    public List<Apartment> Apartments = new List<Apartment>();
}

public class Program
{
    public static void Main(string[] args)
    {
        //Список усіх власників
        List<Host> allHosts = new List<Host>();
        
        //перший власник
        Host h1 = new Host();
        h1.Name = "Andrii";
        h1.Id = 1;
        
        //другий власник
        Host h2 = new Host();
        h2.Name = "Igor";
        h2.Id = 2;
        
        //Створюю квартиру 
        Apartment a1 = new Apartment();
        a1.Id = 101;
        a1.Title = "Loft Wroclaw";
        a1.Price = 2000;
        h1.Apartments.Add(a1);
        
        Apartment a2 = new Apartment();
        a2.Id = 102;
        a2.Title = "Loft Gdansk";
        a2.Price = 3000;
        h2.Apartments.Add(a2);
        
        Apartment a3 = new Apartment();
        a3.Id = 103;
        a3.Title = "Noli Gdansk Old Town";
        a3.Price = 2500;
        h2.Apartments.Add(a3);
        
        
        
        allHosts.Add(h1);
        allHosts.Add(h2);
        
        Console.WriteLine("Список власників: ");
        foreach (var h in allHosts)
        {
            Console.WriteLine("ID: " + h.Id + " | Name: " + h.Name);
        }
        
        Console.WriteLine("\nВведіть ID власника:");
        int searchId = int.Parse(Console.ReadLine());

        foreach (var h in allHosts )
        {
            if (h.Id == searchId)
            {
                Console.WriteLine("Квартири власника " + h.Name + ":");
                foreach (var apt in h.Apartments)
                {
                    Console.WriteLine("- " + apt.Title + " за " + apt.Price + "грн");
                }
            }
        }
    }
}