using System.Numerics;
using System.Data.Common;
using System;
using System.Drawing;

namespace GraphicsProgrammingTask3_.Net_Framework_
{
    public class Mover
    {
        static Random rnd = new Random();
        Vector2 location;
        Vector2 velocity;

        public Mover(int width, int height)
        {
            location = new Vector2(width/2,height/2); //locates it in the middle of the screen
            velocity = new Vector2(3, 2);  //ratio of horizontal to verticle movement
        }

        public void Update()
        {
            velocity.X = rnd.Next(-5, 5);
            velocity.Y = rnd.Next(-5, 5);
            location = Vector2.Add(location, velocity);


        }

        public void Display(Graphics e)
        {
            e.FillEllipse(Brushes.BlueViolet, location.X, location.Y, 100, 100);
        }


    }

}