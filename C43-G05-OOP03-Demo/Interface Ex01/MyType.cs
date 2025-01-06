using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G05_OOP03.Interface_Ex01
{
    internal class MyType : IMyType
    {
        public double Salary {
            get;set;
        }

        public void MyFun()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Hello");
        }

        
    }
}
