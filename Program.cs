public class Program
{
    public static void Main(string[] args)
    {
        /*PhanSo a = new PhanSo(1, 2); //1/2
        PhanSo b = new PhanSo(3, 4); //3/4
        Console.WriteLine(a + "+" + b + "= " + (a + b));
        Console.WriteLine(-a);*/
        SoPhuc a = new SoPhuc(1, 2); //1+2*i
        SoPhuc b = new SoPhuc(3, 4); //3+4*i
        Console.WriteLine(a + "+" + b + "= " + (a + b));
        Console.WriteLine(++a);
    }
}