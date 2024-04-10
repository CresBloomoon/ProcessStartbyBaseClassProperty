using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessStartをベースクラスのプロパティで {
    internal abstract class BaseClass {
        public abstract void Execute();

        public BaseClass() {
            Process = new ProcessStarter();
        }

        public ProcessStarter Process { get; protected set; }
    }
}
