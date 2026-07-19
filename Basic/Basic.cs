using System.Collections.Generic;
using System.Text;

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
        char ch = 'A';
        string st1 = "Ajit";
        bool flag = true;

        // 3. Arrays
        int[] arrays = { 0,1,-2, 3,-3};
        Console.WriteLine(arrays[0]);

        // Sorting Array
        Array.Sort(arrays);        
        for(int i=0; i<arrays.Length; i++)
        {
            Console.Write(arrays[i]+" ");
        }
        // Descending Order Arrays
            Array.Reverse(arrays);
            for(int i=0; i<arrays.Length; i++)
            {
                Console.Write(arrays[i]+" ");
            }
        

        // Loops
            foreach (int x in arrays)
            {
                Console.WriteLine(x);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"i={i}");
            }

        // String
            string s="hello";
            Console.WriteLine(s.Length);
            Console.WriteLine(s.Substring(1));
            Console.WriteLine(s.Contains("el"));
            s.StartsWith("he");
            s.EndsWith("lo");
            s.Replace("l","x");
            s.ToUpper();
            s.ToLower();

        //StringBuilder      
            StringBuilder sb = new();
            sb.Append("Hello");
            sb.Append(" World");
            Console.WriteLine(sb.ToString());
            sb.Clear();

        //Char
            char c='A';
            char.IsDigit(c);
            char.IsLetter(c);
            char.IsLetterOrDigit(c);
            Console.WriteLine(char.ToUpper(c));
            Console.WriteLine(char.ToLower(c));

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


        //LINQ (Frequently Used)
            // nums.Max();

            // nums.Min();

            // nums.Sum();

            // nums.Average();

            // nums.Count();

            // nums.Distinct();

            // nums.OrderBy(x=>x);

            // nums.OrderByDescending(x=>x);

            // nums.Where(x=>x%2==0);

            // nums.Select(x=>x*x);

            // nums.First();

            // nums.Last();

            // nums.Any();

            // nums.All(x=>x>0);

            // nums.ToList();

            // nums.ToArray();
            // 15. Math
            // Math.Max(a,b);

            // Math.Min(a,b);

            // Math.Abs(x);

            // Math.Sqrt(25);

            // Math.Pow(2,3);

            // Math.Ceiling(2.2);

            // Math.Floor(2.9);

            // Math.Round(2.5);
            // 16. Tuple
            // (int x,int y) point=(5,10);

            // Console.WriteLine(point.x);
            // 17. 2D Array
            // int[,] grid =
            // {
            //     {1,2},
            //     {3,4}
            // };

            // grid[0,1];
            // 18. Jagged Array
            // int[][] graph=new int[3][];

            // graph[0]=new int[]{1,2};
            // graph[1]=new int[]{3};
            // graph[2]=new int[]{4,5};
            // 19. Common Loops
            // foreach(var item in list)
            // {

            // }
            // for(int i=0;i<n;i++)
            // {

            // }
            // while(left<right)
            // {

            // }
            // 20. Useful One-Liners

            // Reverse Array

            // Array.Reverse(arr);

            // Clone

            // int[] copy=(int[])arr.Clone();

            // Copy

            // Array.Copy(arr,copy,arr.Length);

            // Fill

            // Array.Fill(arr,-1);
            // 21. Common DSA Templates
            // Frequency Map
            // Dictionary<int,int> freq=new();

            // foreach(var x in nums)
            // {
            //     freq[x]=freq.GetValueOrDefault(x,0)+1;
            // }
            // Visited Set
            // HashSet<int> visited=new();
            // BFS
            // Queue<int> q=new();

            // q.Enqueue(start);

            // while(q.Count>0)
            // {
            //     int node=q.Dequeue();
            // }
            // DFS Stack
            // Stack<int> stack=new();

            // stack.Push(start);

            // while(stack.Count>0)
            // {
            //     int node=stack.Pop();
            // }


        // Time Complexity (Must Remember)
        // Collection	Search	Insert	Delete
        // Array	O(n)	O(n)	O(n)
        // List	O(n)	O(1)*	O(n)
        // Dictionary	O(1) Avg	O(1) Avg	O(1) Avg
        // HashSet	O(1) Avg	O(1) Avg	O(1) Avg
        // Queue	O(1)	O(1)	O(1)
        // Stack	O(1)	O(1)	O(1)
        // PriorityQueue	O(n) to find arbitrary	O(log n)	O(log n)
        // Interview Tip

        // In DSA interviews, you'll use these collections over and over:

        // ✅ List<T> – Dynamic arrays
        // ✅ Dictionary<TKey, TValue> – Hash maps / frequency counting
        // ✅ HashSet<T> – Fast lookup and duplicate detection
        // ✅ Queue<T> – BFS
        // ✅ Stack<T> – DFS, parentheses, monotonic stack
        // ✅ PriorityQueue<TElement, TPriority> – Heap problems (Dijkstra, Top-K, Merge K Lists)
        // ✅ Arrays and strings – Core of most coding problems

        // A strong grasp of these collections and their common methods is enough to solve the majority of LeetCode and interview DSA questions in C#.
    }
}