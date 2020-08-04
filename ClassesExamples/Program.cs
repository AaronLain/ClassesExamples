using ClassesExamples.Animals;
using System;


namespace ClassesExamples // encapsulates an 'idea' of code. Follows folder structure hierarchy. Top of the hierarchy.
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Andy");
            var bob = new Chicken("Bob");

            // _isHungry is true
            chicken.Peck("acorns or w/e"); 
            bob.Peck("worms");

            // _isHungry is now false
            chicken.Peck("acorns or w/e"); 
            bob.Peck("worms");

        }
    }
}
