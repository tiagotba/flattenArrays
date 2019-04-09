using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryUtils
{
  public  class InvalidTypeData : Exception
    {
        public InvalidTypeData(string message) : base(message)
        {
            
        }

        public String toString()
        {
            return "The array sent contains data from invalid types. "
                    + "Remember that the array can contain only Integers or other arrays";
        }
    }
}
