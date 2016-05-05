using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    class Program {
        static void Main( string[] args ) {
            if (args.Length != 1) {
                usage();
                return;
            }

            if (args[0].Equals("plain")) {
                TextBuilder textBuilder = new TextBuilder();
                Director director = new Director(textBuilder);
                director.construct();
                string result = textBuilder.getResult();
                Console.WriteLine(result);
            } else if (args[0].Equals("html")) {
                HTMLBuilder htmlBuilder = new HTMLBuilder();
                Director director = new Director(htmlBuilder);
                director.construct();
                string fileName = htmlBuilder.getResult();
                Console.WriteLine(fileName + "が作成されました。");
            } else {
                usage();
                return;
            }


#if DEBUG
            Console.ReadKey();
#endif
        }

        public static void usage() {
            Console.WriteLine("Usage: Builder plain プレーンテキストで文書作成");
            Console.WriteLine("Usage: Builder html  HTMLファイルで文書作成");
        }

    }
}
