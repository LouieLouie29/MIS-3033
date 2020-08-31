using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ClassesFilesDateTime
{
    public class Rectangle
    {
        public int width { get; set; }

        public int height { get; set; }

        public DateTime creationDate { get; set; }

        /*
        public int getWidth()
        {
            return width;
        }

        public void setWidth(int width)
        {
            _width = width;
        }

        //This is the default/empty constructor 
        */
        public Rectangle()
        {
            width = 0;
            height = 0;
            creationDate = DateTime.Now;
        }
        
        public Rectangle(int width, int height) : this()
        {
            this.width = width;
            this.height = height;
            // ": this()
            //creationDate = DateTime.Now;
        }

        //Calculate the area of the rectangle
        public double area()
        {
            return width * height;
        }
        public override string ToString()
        {
            var diff = DateTime.Now - creationDate;
            string output = "";
            return output;
        }
    }
}
