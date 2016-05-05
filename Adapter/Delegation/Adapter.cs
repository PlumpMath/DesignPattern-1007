using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Delegation {
    class Adapter : ITarget {

        private Adaptee adaptee;

        public Adapter() {
            this.adaptee = new Adaptee();
        }

        public void targetMethod1() {
            this.adaptee.method1();
        }

        public void targetMethod2() {
            this.adaptee.method2();
        }
    }
}
