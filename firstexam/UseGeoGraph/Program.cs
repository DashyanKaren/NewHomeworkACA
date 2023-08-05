using Graphics;

namespace UseGeoGraph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = new ColoredLine(new Geometry.Geometry.Line(new Geometry.Geometry.Point(5,8),
                                            new Geometry.Geometry.Point(10,10)), ConsoleColor.Red );

            x.DrawLine();

            
        }
    }
}