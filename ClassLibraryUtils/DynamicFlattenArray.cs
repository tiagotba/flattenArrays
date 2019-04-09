using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassLibraryUtils
{
    public static class DynamicFlattenArray
    {
        //public static void Flatten(dynamic item, List<int> flattened)
        //{
        //    Random random = new Random();
        //    dynamic array = new dynamic[random.Next(3, 10)];
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (random.NextBool())
        //        {
        //            array[i] = new dynamic[random.Next(3, 10)];

        //            for (int j = 0; j < array[i].Length; j++)
        //            {
        //                if (random.NextBool())
        //                {
        //                    array[i][j] = random.Next(1, 100);
        //                }
        //                else
        //                {
        //                    array[i][j] = new int[random.Next(3, 10)];

        //                    for (int k = 0; k < array[i][j].Length; k++)
        //                    {
        //                        array[i][j][k] = random.Next(1000);
        //                    }
        //                }
        //            }
        //        }
        //        else
        //        {
        //            array[i] = random.Next(1, 100);
        //        }
        //    }
        //}

        //private static bool NextBool(this Random random)
        //{
        //    return random.Next(0, 2) == 0;
        //}

        public static void Merge(Object[] array, ArrayList list)
        {
            //  Move through the length of the array
            for (int i = 0; (i < array.Length); i++)
            {
                if ((array[i] is Object[]))
                {
                    Merge(((Object[])(array[i])), list);
                }

                if (list.Count == array.Length)
                {
                    break;
                }
                else
                {
                    //  Else if the value is an integer then add it to the list.
                    if ((array[i] is int))
                    {
                        list.Add(((int)(array[i])));
                    }
                    else
                    {
                        throw new InvalidTypeData("Invalid type of data. It only allows for Integers or Arrays");
                    }
                }
                

            }

        }

    }

    
}
