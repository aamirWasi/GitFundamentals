﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSecondProject
{
    class Program
    {
        static void Main(string[] args)
        {

            //Started Interfaces

            var missle = new Missle();
            missle.Fire();

            var gun = new MachineGun();
            gun.Fire();

            var weapons = new Weapon[]
            {
                new Missle(),
                new MachineGun()
            };
            foreach (var weapon in weapons)
            {
                weapon.Fire();
            }
            //Ended Interfaces
            //Anonymous Type
            //Added two more class in Anonymous project
            var person = new
            {
                FirstName = "aamirWasi",
                LastName = "Morshed",
                Age = 23
            };
            var person2 = new
            {
                FirstName = "aamirWasi",
                LastName = "Morshed",
                Age = 23,
                Salary=35000
            };
            Console.WriteLine($"{person.FirstName} {person.LastName}");
            //Code to call at DevAamir
            //Added a console
            //Code to call Aspdotnetcore Group
            Console.WriteLine("Hello world");
            //Added a comment from github
            //Updated
            int[] NumOfArray=new int[]{1,2,3,4,5,6,7};
            int sum=0;
            foreach (var item in NumOfArray)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            //Code was updated by Green
            //Now code was not updated but edited in vscode
            //Added Assignment project in vs
            //New Feature in dev (Code to call Dev)
            //New Feature in dev (Code to call Dev) but this was an updated version in github not vs
        }
    }
}
