using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OndeEstouNaCasa
{
    public partial class Form1 : Form

    {
        Location CurrentLocation;
        Location ObgEscondido;
        Oponente ObjHidi;

        RoomWDoor Living;
        RoomWDoor Kitchen;
        Room DinigRoom;

        OutSideWDoor FrontYard;
        OutSideWDoor BackYard;
        Outside Garden;

        public Form1()
        {

            InitializeComponent();
            CreateObj();
            MoveToaNewLocat(Living);
            ObgEscondido = DinigRoom;
            iniciar();
        }

        //bjs

        private void CreateObj()
        {
            Living = new RoomWDoor(" Living Room ", " An antique carpet "
                , " Porta de vidro escuro ");
            Kitchen = new RoomWDoor(" Kitchen ", " Geladeira ", " Porta de madeira ");
            DinigRoom = new Room(" Dining Room ", " Mesa redonda ");
            FrontYard = new OutSideWDoor(" FrontYard ", false, " Porta de vidro escuro ");
            BackYard = new OutSideWDoor(" BackYard ", false, " Porta de medeira ");
            Garden = new Outside(" garden ", false);

            DinigRoom.Exits = new Location[] { Living, Kitchen };
            Living.Exits = new Location[] { DinigRoom };
            Kitchen.Exits = new Location[] { DinigRoom };
            FrontYard.Exits = new Location[] { BackYard, Garden };
            BackYard.Exits = new Location[] { FrontYard, Garden };
            Garden.Exits = new Location[] { BackYard, FrontYard };

            Living.DoorLocation = FrontYard;
            FrontYard.DoorLocation = Living;

            Kitchen.DoorLocation = BackYard;
            BackYard.DoorLocation = Kitchen;

        }
        // ir para algum lugar

        private void MoveToaNewLocat(Location NewLocation)
        {
            this.CurrentLocation = NewLocation;
            comboBox1.Items.Clear();
            if (CurrentLocation is IhasExteriorDoor)
            {
                btnGoDoor.Visible = true;
            }
            else
            {
                btnGoDoor.Visible = false;
            }
            for (int i = 0; i < this.CurrentLocation.Exits.Length; i++)
            {
                comboBox1.Items.Add(CurrentLocation.Exits[i].Nome);
                
            }
            comboBox1.SelectedIndex = 0;
            textBox1.Text = CurrentLocation.Description;            
        }



        private void iniciar()
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(150);
            ObjHidi = new Oponente() ;
            ObgEscondido = ObjHidi.Move(CurrentLocation);
            btnCheck.Visible = true;
            MessageBox.Show("Começou");
            
            

        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            MoveToaNewLocat(CurrentLocation.Exits[comboBox1.SelectedIndex]);
        }

        private void btnGoDoor_Click(object sender, EventArgs e)
        {
            IhasExteriorDoor hasDoor = CurrentLocation as IhasExteriorDoor;
            MoveToaNewLocat(hasDoor.DoorLocation);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            ObgEscondido = ObjHidi.Move(CurrentLocation);
            MessageBox.Show("Stared" );

            btnCheck.Visible = true;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            if (ObjHidi.Check(CurrentLocation))
            {
                MessageBox.Show("You won! It was in the " + ObgEscondido.Nome);
                btnCheck.Visible = false;
            }
            else
            {
                MessageBox.Show("try again");
            }
        }
    }
}
