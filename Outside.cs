using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeEstouNaCasa
{
    class Outside: Location, IhidingPlace
    {
        public bool hot ;
        public Outside (string name, bool hot): base(name)
        {
            this.hot = hot;
        }

        private bool Esconderijo;
        public bool esconderijo
        {
            get { return Esconderijo; }
            set { Esconderijo = value; }
        }

        public override string Description
        {
            get
            {
                string NewDescr = base.Description;
                if (hot)
                {
                    NewDescr += "It's very hot.";
                }
                return NewDescr;
            }
        }

    }
}
