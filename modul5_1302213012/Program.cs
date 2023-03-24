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

            return angka1 + angka2 + angka3;
        }

        public class SimpleDataBase<T>
        {
            private List<T> storedData;
            private List<DateTime> inputDates = new List<DateTime>();

            public SimpleDataBase()
            {
                storedData = new List<T>();
            }

            public void addNewData(T data)
            {
                storedData.Add(data);
                inputDates.Add(DateTime.Now);
            }

            public void printAllData()
            {
                for (int i = 0; i < storedData.Count; i++)
                {
                    Console.WriteLine("Data " + (i + 1) + " berisi " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
                }
            }
        }

        public static void Main(string[] args)
        {

            Penjumlahan num = new Penjumlahan();
            Console.WriteLine("===== Penjumlahan =====");
            Console.WriteLine(num.JumlahTigaAngka<float>(13, 02, 21));
            Console.WriteLine("===== SIMPLE DATABASE =====");
            SimpleDataBase<float> data = new SimpleDataBase<float>();
            data.addNewData(13);
            data.addNewData(02);
            data.addNewData(21);
            data.printAllData();
        }
    }
}
