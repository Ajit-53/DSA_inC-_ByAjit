using System.Collections.Generic;

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
        
        ls.Remove(5);

        ls.RemoveAt(0);

        ls.Insert(1, 100);

        Console.WriteLine(ls.Contains(20));

        Console.WriteLine(ls.Count);

        ls.Sort();

        ls.Reverse();

   
        foreach (int i in ls)
        {
            Console.WriteLine(i);
        }

        ls.Clear();

        //Dictionary
        Dictionary<int,int> dt= new ();
        dt[0]=100;
        dt.Add(1,200);
        dt.Add(2,300);
        Console.WriteLine(dt.ContainsKey(0));
        Console.WriteLine(dt.ContainsValue(100));
        dt.Remove(1);
        Console.WriteLine(dt.Count);
        //Access
        Console.WriteLine(dt[0]);
        foreach(var i in dt)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }
        if(dt.TryGetValue(1,out int value))
        {
         Console.WriteLine(value);
        }

        int[] nums={1,2,3,4,5,1};
        
        foreach(int num in nums)
        {
           dt[num]=dt.GetValueOrDefault(num,0)+1;
        }
        foreach(var i in dt)
        {
            Console.WriteLine(i.Key+" "+i.Value);
        }

        // HashSet<T>

        HashSet<int> hs= new();
        hs.Add(1);
        hs.Remove(1);
       hs.Add(2);
        Console.WriteLine(hs.Contains(2));
        Console.WriteLine(hs.Count);

        if(hs.Contains(2))
        {
            Console.WriteLine("Duplicate");
        }

        //Stack<T>
        // LIFO DFS

        Stack<int> st= new ();
        st.Push(5);
        st.Push(1);
        st.Push(2);
        st.Pop();
        Console.WriteLine($"Peek is {st.Peek()}");
        Console.WriteLine(st.Count);
        // for(int i=0; i<=st.Count; i++)
        // {
        //     Console.WriteLine(st.Pop());
        // }
        // foreach(var i in st)
        // {
        //     Console.WriteLine(i);
        // }
        while(st.Count >0)
        {
            Console.WriteLine(st.Pop());
        }

        // Queue<T>

        // FIFO, BFS

        Queue<int> q = new();

        q.Enqueue(10);
        q.Enqueue(11);
        q.Enqueue(20);

        Console.WriteLine(q.Dequeue());

        Console.WriteLine(q.Peek());

        Console.WriteLine(q.Count);

        while(q.Count >0)
        {
            Console.WriteLine(q.Dequeue());
        }

        // PriorityQueue<TElement,TPriority>

        //     .NET 6+

        //     Min Heap

            PriorityQueue<int,int> pq = new();

            pq.Enqueue(10,10);

            pq.Enqueue(3,5);

            pq.Enqueue(20,20);
            Console.WriteLine(pq.Dequeue());

            pq.Peek();

            Console.WriteLine(pq.Count);

        //     while(pq.Count >0)
        // {
        //     Console.WriteLine(pq.Dequeue());
        // }

           while (pq.TryDequeue(out int element, out int priority))
            {
            Console.WriteLine($"Element: {element}, Priority: {priority}");
            }   

        //Max Heap
        PriorityQueue<int,int> qq = new();

        qq.Enqueue(10,-10); // make minheap just invert with -so that biggest number can come first.
    
        qq.Enqueue(5,-5);
        qq.Enqueue(20,-20);    
            
         Console.WriteLine(qq.Dequeue());
         Console.WriteLine(qq.Count);    
         while (qq.TryDequeue(out int element, out int priority))
            {
            Console.WriteLine($"Element: {element}, Priority: {-priority}");  
            }
    }
}