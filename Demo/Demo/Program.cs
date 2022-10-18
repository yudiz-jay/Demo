using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // It is with inheritance
            myTutorial newTutorial = new myTutorial();
            //newTutorial.RenameTutorial(".net core"); //it is part of polymorphism
            //newTutorial.RenameTutorial(1, ".net core");
            newTutorial.RenameTutorial(2, "Java");
            newTutorial.getTutorial();
            Console.WriteLine(newTutorial.getTutorial());

            //It is without inheritance
            //Tutorial tutorial = new Tutorial();
            //tutorial.setTutorial(1,".NET"); // It throws an error using private
            //Console.WriteLine(tutorial.getTutorial());


            Console.ReadKey(); // It is used for waiting the end of programme

        }
    }
}
