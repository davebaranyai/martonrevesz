﻿using Dominoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetOfThings 
{
    class Thing : IComparable, IPrintable
    {
        private string Name;
        private bool Completed;

        public Thing(string name)
        {
            this.Name = name;
        }

        public int CompareTo(object obj)
        {
            Thing anotherThing = obj as Thing;
            if (Completed && !anotherThing.Completed)
                return 1;
            else if (!Completed && anotherThing.Completed)
                return -1;

            return Name.CompareTo(anotherThing.Name);
        }

        public void Complete()
        {
            this.Completed = true;
        }

        public bool GetCompleted()
        {
            return Completed;
        }

        public string GetName()
        {
            return Name;
        }

        public void PrintAllFields()
        {
            Console.WriteLine($"{Name} , {Completed}");
        }
    }
}
