using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples.Animals
{
    class Chicken
    {
        //property -- order is idiomatic C#
        public string Name { get; set; }

        //field -- naming convention has _ then camel case 
        private bool _isHungry = true;

        //constructor
        public Chicken(string name)
        {
            Name = name;
            Console.WriteLine($"{name} is instantiated! \r\n");
        }

        //method
        public void Peck(string typeOfFood)
        {
            
            if (_isHungry)
            {
                Console.WriteLine($"{Name} pecked hungrily at the {typeOfFood} \r\n");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is full! \r\n");
            }
        }
    }
}
