using System;

namespace NullObjectPattern
{
    public class Program
    {
        static void Main()
        {
            var shapeService = new ShapeService();
            var shape = shapeService.GetShapeById(3);

            shape.Draw();
        }
    }
}
