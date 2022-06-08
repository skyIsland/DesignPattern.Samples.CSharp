using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPattern.AbstractFactory
{
    public class BreadSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new BreadButton();
        }

        public IComboBox CreateComboBox()
        {
            return new BreadComboBox();
        }

        public ITextField CreateTextField()
        {
            return new BreadTextField();
        }
    }
}
