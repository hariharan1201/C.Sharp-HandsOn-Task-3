using HandsOn3;
using System.Collections;


//Function
static void returnMethod()
{
    Data data = new Data();
    List<int> list = new List<int>();
    //method associate with object data
    list = data.arrayFunc(10);
    foreach (int i in list)
    {
       Console.WriteLine("Elements in list:"+i);
    }
    Console.WriteLine("List Count:" + list.Count);
    list.Reverse();
    foreach (int i in list)
    {
        Console.WriteLine("Elements in Reverse list:" + i);
    }
    list.Clear();
    Console.WriteLine(list.Count);
}

//Function doesn't need object
returnMethod();
//Collections HashTable
Console.WriteLine("\nCollections HashTable");
Hashtable hashtbl = new Hashtable();

hashtbl.Add(0, "Hello");

ICollection kkey = hashtbl.Keys;
Console.WriteLine(hashtbl[0]);
//Collection Stach
Console.WriteLine("\nCollection Stach");
Stack stack = new Stack();  
stack.Push('i');
stack.Push('r');
stack.Push('a');
stack.Push('h');
Console.WriteLine("Before Pop");
foreach (char i in stack)
{
    Console.Write(i+" ");
}
stack.Pop();
Console.WriteLine("\nAfter pop");
foreach (char i in stack)
{
    Console.Write(i+" ");
}
Console.WriteLine();
//Collection queue
Console.WriteLine("\nCollection queue");
Queue q = new Queue();
q.Enqueue("M");
q.Enqueue("A");
q.Enqueue("U");
q.Enqueue("I");

foreach(string j in q)
{
    Console.WriteLine(j);
}