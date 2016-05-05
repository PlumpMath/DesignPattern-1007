using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod {
    class StringDisplay : AbstractDisplay {

        private string str;
        private int width;
        public StringDisplay(string str) {
            this.str = str;
            Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
            this.width = sjisEnc.GetByteCount(str);
        }
        
        public override void close() {
            printLine();
        }

        public override void open() {
            printLine();
        }

        private void printLine() {
            Console.Write("+");
            for (int i = 0; i < width; i++) {
                Console.Write("-");
            }
            Console.WriteLine("+");
        }

        public override void print() {
            Console.WriteLine("|" + str + "|");
        }
    }
}
