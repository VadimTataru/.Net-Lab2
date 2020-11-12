using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    /// <summary>
    /// Base class of all animal
    /// </summary>
    abstract class Animal
    {
        protected int age;
        protected string name;

        public Animal (string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
