using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class CharDisplay : AbstractDisplay {

        private Char c;
        public CharDisplay(Char c) {
            this.c = c;
        }
           
        public override void close() {
            Console.WriteLine(">>");
        }

        public override void open() {
            Console.Write("<<");
        }

        public override void print() {
            Console.Write(c.ToString());
        }
    }
}
