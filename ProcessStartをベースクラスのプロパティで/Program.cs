using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessStartをベースクラスのプロパティで {
    internal class Program {
        static void Main(string[] args) {
            var steps = new List<BaseClass>() { new SuperClass1() };

            foreach (var step in steps) {
                step.Execute();
            }

            Console.WriteLine("終わり");
            Console.ReadKey();
        }
    }
}
