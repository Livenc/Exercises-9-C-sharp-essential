namespace Exercise_5;
class Program
{
    public delegate double Operation(double x, double y, double z);
    static void Main(string[] args)
    {
        int x = 9, y = 3,z = 9;
        
        Operation average = delegate (double x, double y, double z) { return (x + y + z) / 3; };

        Func<int, int, int, double> averageFunc = delegate (int x, int y, int z)
        {
            return (x + y + z) / 3.0;
        };
        Console.WriteLine(averageFunc(x,y,z));
        Console.WriteLine(average(x,y,z));
        Console.ReadKey();
    }
}

