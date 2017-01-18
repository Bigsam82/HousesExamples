using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace housesExample
{
    class House//class
    {
        private string color;//field
        private int rooms;//field
        private int size;//field
        private int doors;//field

        public House(string color, int rooms, int size, int doors)//constructor// class and constructor have to have the same name
        {
            this.color = color;//varibles
            this.rooms = rooms;//varibles
            this.size = size;//varibles
            this.doors = doors;//varibles

        }

        
        public void Paint(string color)//method 
            
        {
            this.color = color;
        }
        public string CurrentColor()//
        {
            return color;
        }
        public void DisplayHouseInfo()
        {
            Console.Write("House Color: " + color);
            Console.Write(" ,  Rooms: " + rooms);
            Console.Write(" , Size is: " + size + " sq/ft ");
            Console.Write(" , with: " + doors + " "+ "doors ");
        }

       
        
    }

    }

