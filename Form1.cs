using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HouseGame
{
    public partial class Form1 : Form
    {
        int Moves;
        Bitmap LivingRoom;
        Bitmap DiningRoom;
        Bitmap Kitchen;
        Bitmap Stairs;
        Bitmap Hallway;
        Bitmap Bathroom;
        Bitmap MasterBedroom;
        Bitmap SecondBedroom;

        Bitmap FrontYard;
        Bitmap BackYard;
        Bitmap Garden;
        Bitmap Driveway;

        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace drivway;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(stairs);
            ResetGame(false);
        }

        private void MoveToANewLocation(Location newLocation)
        {
            Moves++;
            currentLocation = newLocation;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
                exits.Items.Add(currentLocation.Exits[i].Name);
            exits.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n(move #" + Moves + ")";
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace hidingPlace = currentLocation as IHidingPlace;
                check.Text = "Check " + hidingPlace.HidingPlaceName;
                check.Visible = true;
            }
            else
                check.Visible = false;
            if (currentLocation is IHasExteriorDoor)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
            try
            {
                picHolder.Image = (currentLocation.Picture);

            }
            catch (Exception)
            {
                throw new ApplicationException("Failed to load the iamge");
            }
        }

        private void CreateObjects()
        {
            LivingRoom = new Bitmap(Properties.Resources.Livingroom);
            DiningRoom = new Bitmap(Properties.Resources.Diningroom);
            Kitchen = new Bitmap(Properties.Resources.Kitchen);
            Stairs = new Bitmap(Properties.Resources.Stairs);
            Hallway = new Bitmap(Properties.Resources.hallway);
            Bathroom = new Bitmap(Properties.Resources.bathroom);
            MasterBedroom = new Bitmap(Properties.Resources.MasterBed);
            SecondBedroom = new Bitmap(Properties.Resources.SecondBed);

            FrontYard = new Bitmap(Properties.Resources.FrontYard);
            BackYard = new Bitmap(Properties.Resources.Backyard);
            Garden = new Bitmap(Properties.Resources.Garden);
            Driveway = new Bitmap(Properties.Resources.Driveway);

            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass door knob", "inside the closest", LivingRoom);
            diningRoom = new RoomWithHidingPlace("Dinning Room", "a crystal chandelier", "in the tall armoire", DiningRoom);
            kitchen = new RoomWithDoor("Kitchen", "stainless steal appliances", "screen door", "in the cabinet", Kitchen);
            stairs = new Room("Stairs", "a wooden bannister", Stairs);
            hallway = new RoomWithHidingPlace("Upstairs HallWay", "a picture of a dog", "in the closet", Hallway);
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilte", "in the shower", Bathroom);
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed", MasterBedroom);
            secondBedroom = new RoomWithHidingPlace("Guest bedroom", "a small bed", "under the bed", SecondBedroom);

            frontYard = new OutsideWithDoor("Front Yard", false, "a heavy looking door", FrontYard);
            backYard = new OutsideWithDoor("Back yard", true, "a screen door", BackYard);
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed", Garden);
            drivway = new OutsideWithHidingPlace("Driveway", true, "in the garage", Driveway);

            diningRoom.Exits = new Location[] { livingRoom, kitchen};
            livingRoom.Exits = new Location[] { diningRoom, stairs};
            kitchen.Exits = new Location[] { diningRoom};
            stairs.Exits = new Location[] { livingRoom, hallway};
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom};
            bathroom.Exits = new Location[] { hallway};
            masterBedroom.Exits = new Location[] { hallway};
            secondBedroom.Exits = new Location[] { hallway};
            frontYard.Exits = new Location[] { backYard, garden, drivway};
            garden.Exits = new Location[] { frontYard, backYard};
            backYard.Exits = new Location[] { frontYard, garden, drivway};
            drivway.Exits = new Location[] { backYard, frontYard};

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("You found me in " + Moves + " moves!");
                IHidingPlace foundLocation = currentLocation as IHidingPlace;
                description.Text = "You found your opponent in " + Moves + " Moves! He was hiding" + foundLocation.HidingPlaceName + ".";
 
            }

            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;

        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor hasDoor = currentLocation as IHasExteriorDoor;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (opponent.Check(currentLocation))
                ResetGame(true);
            else
                RedrawForm();
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 0; i <= 10; i++)
            {
                opponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Ready or not here i come";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
            Console.Write(opponent.Place());
        }
    }
}
