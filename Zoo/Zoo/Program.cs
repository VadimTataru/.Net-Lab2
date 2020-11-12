using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse(name: "Breeze", age: 12, speed: 69.69d);
            Elephant elephant = new Elephant(name: "Bubble", age: 5, weight: 130.4f);
            Giraffe giraffe = new Giraffe(name: "Melman", age: 7, height: 20.8f);

            object[] zoo = { horse, elephant, giraffe };

            foreach(object elem in zoo)
            {
                Console.WriteLine(elem.ToString());
            }
        }
    }
}
