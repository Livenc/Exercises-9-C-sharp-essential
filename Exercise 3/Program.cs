namespace Exercise_3;
class Program
{
    public delegate int MyDelegate();
    static void Main(string[] args)
    {
        MyDelegate[] myDelegate = new MyDelegate[]
        {
            () =>  3,
            () => 5,
            ()=>3
        };
        double sum = 0;
        foreach (var item in myDelegate)
        {
            sum += item();

        }
        Console.WriteLine(sum/myDelegate.Length);
        Console.ReadKey();
    }
}

