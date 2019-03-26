using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeEstouNaCasa
{
    class Room : Location, IhidingPlace
    {
        public string decoration; 
        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }

        private bool Esconderijo;
        public bool esconderijo
        {
            get { return Esconderijo; }
            set { Esconderijo = value; }
        }

        public override string Description
        {
            get { return base.Description + "You see" + decoration + "."; }
        }

    }
}
