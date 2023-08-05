using System;
using Geometry;
using Geometry.Geometry;
namespace Graphics;

public class ColoredLine
{
    private readonly Line line;
    private readonly ConsoleColor color;

    public ColoredLine(Line line, ConsoleColor color)
    {
        this.line = line;
        this.color = color;
    }

    public void DrawLine()
    {
        var deltaX = this.line.EndPoint.X - this.line.StartPoint.X;
        var deltaY = this.line.StartPoint.Y - this.line.StartPoint.Y;

        var slope = (double)deltaY / deltaX;
        var currentY = (double)this.line.StartPoint.Y;

        Console.ForegroundColor = this.color;

        for (var x = this.line.StartPoint.X; x <= this.line.EndPoint.X; x++)
        {
            var roundedY = (int)Math.Round(currentY);
            Console.SetCursorPosition(x, roundedY);
            Console.Write("■");

            currentY += slope;
        }
    }
}