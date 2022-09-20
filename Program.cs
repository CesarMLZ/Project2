using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Project2;
using License = Project2.License;

namespace Program
{
    class Program
    {
        private static void Main(string[] args)
        {
            Person person1 = new Person();
            License license1 = new License();
            Vehicle vehicle1 = new Vehicle();
            person1.id = 12345;
            person1.age = 18;
            person1.gender = "Female";
            person1.name = "GABRIELA";
            person1.lastname = "JÍMENEZ";
            person1.susFraud = false;

            license1.start = "05/30/2015";
            license1.end = "05/30/2018";
            license1.status = true;
            license1.type = "A";
            license1.person = person1;

            License license2 = new License();
            license2.start = "05/30/2015";
            license2.end = "05/30/2023";
            license2.status = true;
            license2.type = "A";
            license2.person = person1;

            vehicle1.year = 2005;
            vehicle1.description = "HAS A CRASH IN THE BACK";
            vehicle1.wheels = "BBS BLACK";
            vehicle1.brand = "TOYOTA";
            vehicle1.color = "RED";
            vehicle1.type = "A";

            person1.getLicense(license1);
            person1.getLicense(license2);
            person1.getVehicle(vehicle1);
            Console.WriteLine(person1.licenses.Count);
            Console.WriteLine(person1.vehicles.Count);
        }
    }
}
