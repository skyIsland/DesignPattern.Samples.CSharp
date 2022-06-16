using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDC.DesignPatterm.Decorator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Component component = new Window();

            //// 一次装饰
            //Component componentSB = new ScrollBarDecorator(component);
            //componentSB.Display();
            //Console.WriteLine();

            //// 二次装饰
            //Component componentBB = new BlackBorderDecorator(componentSB);
            //componentBB.Display();
            //Console.WriteLine();

            Component componentBread = new Bread();

            Component componentSB1 = new ScrollBarDecorator(componentBread);
            componentSB1.Display();
            Console.WriteLine();

            Component componentBB1 = new BlackBorderDecorator(componentSB1);
            componentBB1.Display();
            Console.WriteLine();

            Component componentBgColor = new BgColorDecorator(componentBB1);
            componentBgColor.Display();

            Console.ReadKey();
        }
    }
}
