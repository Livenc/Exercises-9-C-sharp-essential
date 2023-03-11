namespace Exercise_2;
class Program
{
    public delegate int Operation(int x, int y);
    //public delegate int Sub(int x, int y);
    //public delegate int Mul(int x, int y);
    //public delegate int Div(int x, int y);
    static void Main(string[] args)
    {
        int x = 9, y = 0;
        Operation add = delegate (int x, int y) { return x + y; };
        Operation sub = delegate (int x, int y) { return x - y; };
        Operation mul = delegate (int x, int y) { return x * y; };
        Operation div = delegate (int x, int y)
        {  if(y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;
            };
        };
        Console.WriteLine(add(x,y));
        Console.WriteLine(sub(x, y));
        Console.WriteLine(mul(x, y));
        Console.WriteLine(div(x, y));
        Console.ReadKey();
      
    }
}

