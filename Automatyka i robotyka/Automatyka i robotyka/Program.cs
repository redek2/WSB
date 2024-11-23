using System;

class Program
{
    static void Main(string[] args)
    {
        int steps = 90;
        double maxPosition = 90;
        double[] positions = new double[steps + 1];

        for (int k = 0; k <= steps; k++)
        {
            double position = maxPosition * Math.Sin((Math.PI / 2) * k / steps);
            positions[k] = position;
            position = Math.Round(positions[k],2);
            Console.WriteLine(position);
        }
    }
}
