using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndeEstouNaCasa
{
    class Oponente
    {
        Location esconde;
        Location esco;
        bool Estaescon = false;

        

        Random random = new Random();
        public Location Move(Location MyLoc)
        {
            esconde = MyLoc;
            for (int i = 0; i <= 7; i++)
            {

                if (esconde is IhasExteriorDoor)
                {
                    int UmouDois = random.Next(2);
                    if (UmouDois == 1)
                    {
                        IhasExteriorDoor hasDoor = esconde as IhasExteriorDoor;
                        esconde = hasDoor.DoorLocation;
                        
                    }
                    if (esconde.Exits.Length == 1)
                    {
                        Location rs = esconde.Exits[0] as Location;
                        esconde = rs;
                        
                    }
                }
                else
                {
                    esconde = esconde.Exits[random.Next(esconde.Exits.Length)];
                    
                }
               

            }
            Estaescon = true;
            IhidingPlace esco = esconde as IhidingPlace;
            esco.esconderijo = true;
            return esconde;

        }

        public bool Check(Location CurrentLocat)
        {
            
            IhidingPlace esco = CurrentLocat as IhidingPlace;
            if (esco.esconderijo)
            {
                esco.esconderijo = false;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
