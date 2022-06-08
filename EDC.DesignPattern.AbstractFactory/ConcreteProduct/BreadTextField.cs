using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class BreadTextField : ITextField
    {
        public void Display()
        {
            Console.WriteLine("显示面包边框文本框...");
        }
    }
}
