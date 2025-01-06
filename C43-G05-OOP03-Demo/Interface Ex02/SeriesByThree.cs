using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Interface_Ex02
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get; set ; }

        public void Next()
        {
            //throw new NotImplementedException();
            Current += 3;
        }

  
    }
}
