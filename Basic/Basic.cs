

public class Basic
{
    public void Test()
    {
        // 1. Input / Output
        // int a = int.Parse(Console.ReadLine());
        // Console.WriteLine(a);

        // 2. Variables
        long l = 1000000000;
        double d = 10.5;
        float f = 10.5f;
        char c = 'A';
        string s = "Ajit";
        bool flag = true;

        // 3. Arrays
        int[] arrays = { 0, 1, 2, 3 };
        Console.WriteLine(arrays[0]);

        // Loops
        foreach (int x in arrays)
        {
            Console.WriteLine(x);
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i={i}");
        }

        // List
        List<int> ls = new List<int>();
        ls.Add(5);
        ls.Add(6);
        ls.Add(7);
        ls.Add(8);
        ls.Add(1);
        
        // ls.Remove(5);

        // ls.RemoveAt(4);

        ls.Insert(1, 100);

        // Console.WriteLine(ls.Contains(20));

        // Console.WriteLine(ls.Count);

        //  ls.Sort();

        // ls.Reverse();

   
        foreach (int i in ls)
        {
            Console.WriteLine(i);
        }

        ls.Clear();
    }
}