using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessStartをベースクラスのプロパティで {
    internal sealed class SuperClass1 : BaseClass {

        public SuperClass1() {
            base.Process.FileName = "notepad.exe";
        }

        public override void Execute() {
            base.Process.Start();
        }
    }
}
