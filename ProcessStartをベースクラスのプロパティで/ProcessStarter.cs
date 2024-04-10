using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessStartをベースクラスのプロパティで {
    internal sealed class ProcessStarter {

        private readonly Process _process;
        public string FileName {
            set { _process.StartInfo.FileName = value; }
        }
        public string Arguments {
            set { _process.StartInfo.Arguments = value; }
        }

        public ProcessStarter() {
            _process = new Process();
            _process.StartInfo.CreateNoWindow = true;
        }
        

        public void Start() {
            _process.Start();
            _process.WaitForExit();
        }
    }
}
