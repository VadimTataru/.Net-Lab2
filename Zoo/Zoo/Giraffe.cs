using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    /// <summary>
    /// Class of Elephant
    /// </summary>
    class Giraffe : Animal
    {
        private float height;

        public Giraffe(string name = "unknown", int age = 0, float height = 0):base(name, age)
        {
            this.height = height;
        }

        /// <summary>
        /// Transform horse characteristics to string
        /// </summary>
        /// <returns>
        /// String "Name : {name}, age : {age}, height : {height}
        /// </returns>
        
        public override string ToString()
        {
            return $"Name: {name}, age: {age}, height: {height}";
        }
    }
}
