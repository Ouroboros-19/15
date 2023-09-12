class Program
{
    static void Main()
    {
        Random r = new Random();
        int a = 20;
        bool flag;
        int[] array = new int[a];
        for (int i = 0; i < array.Length; i++)
            Console.Write("{0,3}", i);
        Console.WriteLine("   - индексы");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = r.Next(1, 10);
            Console.Write("{0,3}", array[i]);
        }
        Console.WriteLine("   - исходный массив");
        for (int i = 0; i < array.Length; i++)
        {
            flag = true;
            for (int j = 0; j < i; j++)
                if (array[i] == array[j])
                {
                    array[i] *= i;
                    i--;
                    flag = false;
                    break;
                }
            if (flag)
            {
                if (array[i] > 99)
                    Console.Write("  ");
                Console.Write("{0,3}", array[i]);
            }
        }
        Console.WriteLine("   - изменённый массив");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("");
        Console.WriteLine("Повтор?( enter - да; люб. др. клавиша - нет )");
        Console.ForegroundColor = ConsoleColor.White;
        string povtor = Convert.ToString(Console.ReadLine());
        if (povtor == "")
            Main();
    }
}