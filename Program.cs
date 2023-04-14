namespace PracticeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                Make = "Volkswagen",
                Model = "Jetta",
                Mileage = 12000,
                Color = "white",
                Year = 2009
            };
            Console.WriteLine($"Make:{car.Make}  Model:{car.Model}  Color:{car.Color}  Year:{car.Year}  Mileage:{car.Mileage}");

            Console.WriteLine("---Start of BIKE---");

            //bike
            Bike bike = new Bike()
            {
                Brand = "Huffy",
                Type = Bike.TypeOfBike.Mountain,
                Color = "blue",
                Wheels = 2
            };
            Console.WriteLine($"Brand:{bike.Brand}   Type:{bike.Type}   Color:{bike.Color}  Number of Wheels:{bike.Wheels}");


            Console.WriteLine("---Start Of PAINTING---");

            Painting painting = new Painting()
            {
                Paint=Painting.TypeOfPaint.Oil,
                Surface=Painting.TypeOfPaintSurface.Canvas,
                Brush=Painting.TypeOfBrush.OilBrush

            };
            Console.WriteLine($"Type of Paint:{painting.Paint}  Type of Surface:{painting.Surface}  Type of Brush:{painting.Brush}");

        }
    }
}