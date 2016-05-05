using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Entends {
    class Adapter : Adaptee, ITarget {

        public void targetMethod1() {
            method1();
        }

        public void targetMethod2() {
            method2();
        }
    }
}
