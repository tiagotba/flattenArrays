using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUtils
{
    public static class DynamicFlattenArray
    {
        private static void Flatten(dynamic item, List<int> flattened)
        {
            Random random = new Random();
            dynamic array = new dynamic[random.Next(3, 10)];
            for (int i = 0; i < array.Length; i++)
            {
                if (random.NextBool())
                {
                    array[i] = new dynamic[random.Next(3, 10)];

                    for (int j = 0; j < array[i].Length; j++)
                    {
                        if (random.NextBool())
                        {
                            array[i][j] = random.Next(1, 100);
                        }
                        else
                        {
                            array[i][j] = new int[random.Next(3, 10)];

                            for (int k = 0; k < array[i][j].Length; k++)
                            {
                                array[i][j][k] = random.Next(1000);
                            }
                        }
                    }
                }
                else
                {
                    array[i] = random.Next(1, 100);
                }
            }
        }

        public static bool NextBool(this Random random)
        {
            return random.Next(0, 2) == 0;
        }

    }

    
}
