using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var jatinder = new newClass();
            jatinder.newMethod();
        }
    }

    
    class newClass
    {

        public void newMethod()
        {
	    		int i = 0, sum = 0;
		while(i < 5){
			int num;
			Console.WriteLine("Enter any number to add");
			num = int.Parse(Console.ReadLine());
			sum += num;
			i++;
		}
	    Console.WriteLine("The sum of five number is {0}", sum);
            Console.ReadLine();
        }
        
    }
}