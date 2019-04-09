using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryUtils;

namespace ConsoleAppFlattenArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Object[] array = new Object[2];

            array[0] = new object[2];
            ((Object[])array[0])[0] = 1;
            ((Object[])array[0])[1] = 2;
            array[1] = 4;


            ArrayList result = new ArrayList();


            try
            {
                DynamicFlattenArray.Merge(array, result);

                //Show the result
                foreach (var item in result)
                {
                    Console.WriteLine("Result:" + item.ToString());
                    Console.ReadKey();
                }
                
            }
            catch (InvalidTypeData ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            catch(Exception ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.ReadKey();
            }
        }
    }
}
