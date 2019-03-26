using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeEstouNaCasa
{
    abstract class Location
    {
        public Location(string name)
        {
            this.name = name;
        }
        public Location[] Exits;
        private string name;
        public string Nome
        {
            get { return name; }
        }
        public virtual string Description
        {
            get
            {
                string description = " You're standing in the " + Nome + ". You see " +
                    " exits to the following places: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Nome;
                    if (i != Exits.Length-1)
                    {
                        description += ", ";
                    }
                }
                description += ".";
                return description;
            }
        }
    }
}
