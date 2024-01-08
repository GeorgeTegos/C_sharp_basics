using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ExtrasFile
    {
        private string name;
        private int age;
        public ExtrasFile(string name, int age) {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public void giveInfo()
        {
            Console.WriteLine($"Hello!, my name is {this.Name} and I am {this.Age} year's old");
        }

        public void ageUp(int amount) {
            this.Age += amount;
            Console.WriteLine($"New age is {this.Age}");
        }
    
    }

}
