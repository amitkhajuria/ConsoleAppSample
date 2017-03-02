using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_ConApp
{
    class C6_ExceptionFilter
    {
        static void MainEF(string[] args)
        {
            int n = 0;
            
            try
            {
                n = int.Parse(Console.ReadLine());
               // Console.ReadKey();
            }
            catch(Exception ex) when (n==0)//C# Feature
            {
                //Console.WriteLine(0);
            }
            catch (Exception ex) 
            {
                //Console.WriteLine(ex.Message);
            }

        }

    }
}