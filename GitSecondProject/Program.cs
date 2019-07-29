using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Added a console
            Console.WriteLine("Hello world");
            //Added a comment from github
            //Updated
            int[] NumOfArray=new int[]{1,2,3,4,5,6,7};
            int sum=0;
            foreach (var item in NumOfArray)
            {
                sum += item;
            }
            Console.WriteLine(sum);
            //Code was updated by Green
        }
    }
}
