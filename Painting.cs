using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClasses
{
    internal class Painting
    {

        //fields
       public enum TypeOfPaint { Oil,Acrylic,Watercolor}
        public enum TypeOfPaintSurface { WoodBoard,Canvas,WaterColorPaper}
        public enum TypeOfBrush { OilBrush,AcrylicBrush,WCBrush}
        TypeOfPaint _paint;
        TypeOfPaintSurface _surface;
        TypeOfBrush _brush;

        //Properties
        internal TypeOfPaint Paint { get => _paint; set => _paint = value; }
        internal TypeOfPaintSurface Surface { get => _surface; set => _surface = value; }
       internal TypeOfBrush Brush { get => _brush; set => _brush = value; }
    }
}
