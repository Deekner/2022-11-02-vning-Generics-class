using System;
using System.Collections.Generic;

namespace _2022_11_02_Övning_Generics_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees:\n");
            Läkare läkare1 = new Läkare()
            {
                WorkID = 1001,
                Name = "Dr.Jelly",
                Salary = 70000,
                WorkHours = 70,
                role = "Doktor",
            };

            Sjuksköterska sjuksköterska1 = new Sjuksköterska()
            {
                WorkID = 1002,
                Name = "ChrisFix",
                Salary = 45000,
                WorkHours = 45,
                role = "sjuksköterska",
            };

            Patient patient1 = new Patient()
            {
                Name = "Markus",
                role = "Patient",
                sjukdom = "Covid-19",
                timeOfReg = 20.00,
                timeOfDisCharge = 20.10,
                Recept = true,

            };
            Patient patient2 = new Patient()
            {
                Name = "Christoffer",
                role = "Patient",
                sjukdom = "Fever",
                timeOfReg = 13.15,
                timeOfDisCharge = 13.25,
                Recept = true,
            };
            Patient patient3 = new Patient()
            {
                Name = "Magnus",
                role = "Patient",
                sjukdom = "Covid-19",
                timeOfReg = 07.48,
                timeOfDisCharge = 07.58,
                Recept = false,
            };

            List<Person> listEmployees = new List<Person>();
            listEmployees.Add(läkare1);
            listEmployees.Add(sjuksköterska1);

            foreach (Person item in listEmployees)
            {
                Console.WriteLine("WorkID = {0}\nName = {1}\nSalary = {2}\nWork Hours = {3}\nRole = {4}\n", item.WorkID, item.Name, item.Salary, item.WorkHours, item.role);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            Console.WriteLine("Patients:\n");

            List<Patient> listPatients = new List<Patient>();
            listPatients.Add(patient1);
            listPatients.Add(patient2);
            listPatients.Add(patient3);

            foreach (Patient item in listPatients)
            {
                Console.WriteLine("Name = {0}\nRole = {1}\nSjukdom = {2}\nTime of registration = {3}\nTime of discharge = {4}\nRecept = {5}\n", item.Name, item.role, item.sjukdom, item.timeOfReg, item.timeOfDisCharge, item.Recept);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");
            Queue<Patient> patientQueue = new Queue<Patient>();

            patientQueue.Enqueue(patient1);
            patientQueue.Enqueue(patient2);
            patientQueue.Enqueue(patient3);

            foreach (Patient item in patientQueue)
            {
                Console.WriteLine("Name = {0}\nSjukdom = {1}\nRecept = {2}\n", item.Name, item.sjukdom, item.Recept);
            }

            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            patientQueue.Dequeue();

            foreach (Patient item in patientQueue)
            {
                Console.WriteLine("Name = {0}\nSjukdom = {1}\nRecept = {2}\n", item.Name, item.sjukdom, item.Recept);
            }

















            //bool equal = TestGeneric.Equals(2, 2);

            //if (equal)
            //{
            //    Console.WriteLine("The Values are equal");
            //}
            //else
            //{
            //    Console.WriteLine("The values are not equal");
            //}

            //bool equal2 = TestGeneric.Equals("Igor", "Affe");

            //if (equal2)
            //{
            //    Console.WriteLine("The strings are equal");
            //}
            //else
            //{
            //    Console.WriteLine("The strings are not equal");
            //}






            Console.ReadKey();
        }
    }
}
