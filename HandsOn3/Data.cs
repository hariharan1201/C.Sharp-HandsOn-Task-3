using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOn3
{
    internal class Data
    {
        //Method declare inside the class
        public dynamic arrayFunc(int a)
        {
            List<int> list = new List<int>();
            for(int i=1;i<=a;i++)
            {
                if(i%2 == 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
