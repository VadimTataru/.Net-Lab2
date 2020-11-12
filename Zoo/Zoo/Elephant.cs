using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    /// <summary>
    /// Class of Elephant
    /// </summary>
    class Elephant : Animal
    {
        private float weight;

        public Elephant(string name = "unknown", int age = 0, float weight = 0) : base(name, age)
        {
            this.weight = weight;
        }

        /// <summary>
        /// Transform horse characteristics to string
        /// </summary>
        /// <returns>
        /// String "Name : {name}, age : {age}, weight : {weight}
        /// </returns>

        public override string ToString()
        {
            return $"Name: {name}, age: {age}, weight: {weight}";
        }
    }
}
