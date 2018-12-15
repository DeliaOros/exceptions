using System;
using System.Collections.Generic;
using System.Text;

namespace Collections

{
   
    class DressCodeException:ApplicationException
    {
        string message = "You are not wearing an Elf costume and you are under age!";
        public DressCodeException()
        {
            Console.WriteLine(message);
        }
        

    }
}
