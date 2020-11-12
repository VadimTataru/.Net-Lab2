using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    /// <summary>
    /// Class of Horse
    /// </summary>
    class Horse : Animal
    {
        private double speed;

        public Horse(string name = "unknown", int age = 0, double speed = 0) : base(name, age)
        {
            this.speed = speed;
        }

        /// <summary>
        /// Transform horse characteristics to string
        /// </summary>
        /// <returns>
        /// String "Name : {name}, age : {age}, speed : {speed}
        /// </returns>

        public override string ToString()
        {
            return $"Name: {name}, age: {age}, speed: {speed}";
        }

    }
}
