// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>(T in1, T in2, T in3)
        {
            dynamic angka1 = in1;
            dynamic angka2 = in2;
            dynamic angka3 = in3;

            return angka1+ angka2 + angka3;
        }
    }

    public static void Main(string[] args)
    {
        Penjumlahan num = new Penjumlahan();
        Console.WriteLine(num.JumlahTigaAngka<float>(13, 02, 21));
    }
}
