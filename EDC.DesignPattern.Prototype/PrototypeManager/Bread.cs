using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.Prototype
{
    public class Bread : OfficeDocument
    {
        public OfficeDocument Clone()
        {
            return new Bread();
        }

        public void Display()
        {
            Console.WriteLine("<<凤凰单丛冲泡方式之见解>>");
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }
    }
}
