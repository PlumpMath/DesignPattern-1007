using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public class TextBuilder : Builder {

        private StringBuilder buffer = new StringBuilder();

        public override void makeTitle( string title ) {
            buffer.Append("==============================\n");
            buffer.Append("『" + title + "』");
            buffer.Append("\n");
        }

        public override void makeString( string str ) {
            buffer.Append('■' + str + "\n");
            buffer.Append("\n");
        }

        public override void makeItems( string[] items ) {
            foreach (string item in items){
                buffer.Append(" ・" + item + "\n");
            }
        }

        public override void close() {
            buffer.Append("==============================\n");
        }

        public string getResult() {
            return buffer.ToString();
        }
    }
}
