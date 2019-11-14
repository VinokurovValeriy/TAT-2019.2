using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.hw1
{ 
   class OutOfRange : Exception
    {
        public OutOfRange(string message) : base(message)
        {

        }
    }

}
