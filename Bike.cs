using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    internal class Bike
    {
        //fields
        public enum TypeOfBike { Mountain, Electric, Unicycle }
        string _brand;
        TypeOfBike _type;
        string _Color;
        int _wheels;

        //properties
        public string Brand { get => _brand; set => _brand = value; }
        public string Color { get => _Color; set => _Color = value; }
        public int Wheels { get => _wheels; set => _wheels = value; }
        public TypeOfBike Type { get => _type; set => _type = value; }
    }
}
