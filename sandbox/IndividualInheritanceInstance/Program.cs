﻿using System.Security.Cryptography.X509Certificates;

class Program{
        public static void SetPersonFirstName(Person person, string FirstName){
            person.SetFirstName(FirstName);
        }
    public static void Main(string[] args){

//Note how you can not say person a 2nd time, i dont like it
        // Person bob = new ("Bob", "Billy", 39); //better bob is better because it says Person twice
        // Person betterBobCauseThereIsASecondPerson = new Person("Bob", "Billly", 38);
        Doctor bestBob = new Doctor("Bob", "Billlly", 37, "Scalpel, Stethoscope, Hacksaw, Bonesaw, Circsaw, Jug for hoedowns, Stick");//best bob is best because he's a doctor
        Police doug = new Police("Doug", "Dougson", 12, "Taser, Pepper Spray");


        // Console.WriteLine(bob.GetPersonInfo());
        // Console.WriteLine(betterBobCauseThereIsASecondPerson.GetPersonInfo());
        Console.WriteLine(bestBob.GetDoctorInformaion());
        Console.WriteLine(bestBob.GetPersonInfo());


        Console.WriteLine(doug.GetPoliceInformaion());
        
        SetPersonFirstName(doug, "Doug da copper");
        Console.WriteLine(doug.GetPoliceInformaion());
        Console.WriteLine(doug.GetPersonInfo());

        // SetPersonFirstName(bob, "Bob da billy bob");
        // Console.WriteLine(bob.GetPersonInfo());
        
        Console.WriteLine("\n\n");

        List<Person> people = new List<Person>();
        // people.Add(bob);
        // people.Add(betterBobCauseThereIsASecondPerson);
        people.Add(bestBob);
        people.Add(doug);

        foreach(Person person in people){
            Console.WriteLine(person.GetPersonInfo());
        }
    }




}