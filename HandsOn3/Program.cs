using HandsOn3;


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
  
}

//Function doesn't need object
returnMethod();