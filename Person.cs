using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public List<License> licenses;
        public List<Vehicle> vehicles;

        public bool susFraud { get; set; }

        public Person()
        {
            licenses = new List<License>();
            vehicles = new List<Vehicle>();
        }
        public void getLicense(License license)
        {
            if (age < 18 | age > 90)
            {
                return;
            }
            else
            {
                if (licenses.Count != 0)
                {
                    for (int i = 0; i < licenses.Count; i++)
                    {
                        if (license.type == licenses[i].type)
                        {
                            int x = Int32.Parse(licenses[i].end.Substring(6));
                            int y = Int32.Parse(DateTime.Now.ToString("MM/dd/yyyy").Substring(6));
                            if (x < y)
                            {
                                licenses.RemoveAt(i);
                                licenses.Add(license);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            licenses.Add(license);
                        }
                    }
                }
                else if (licenses.Count == 0)
                {
                    licenses.Add(license);
                }

            }
        }
        public void getVehicle(Vehicle vehicle)
        {
            if (vehicles.Count > 5)
            {
                susFraud = true;
                return;
            }
            else
            {
                for (int i = 0; i < licenses.Count; i++)
                {
                    if (vehicle.type == licenses[i].type)
                    {
                        if (gender.Equals("WOMEN"))
                        {
                            if (vehicle.color.Equals("RED"))
                            {
                                vehicles.Add(vehicle);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (gender.Equals("MAN"))
                        {
                            if (vehicle.brand.Equals("FORD") | vehicle.brand.Equals("TOYOTA"))
                            {
                                vehicles.Add(vehicle);
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            Console.WriteLine("ERROR: GENDER NOT FOUND");
                            return;
                        }
                    }
                }
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Person person &&
                   EqualityComparer<List<Vehicle>>.Default.Equals(vehicles, person.vehicles);
        }
    }
}
