using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    class HTMLBuilder : Builder {

        private string fileName;
        private StreamWriter sw;

        public override void makeTitle( string title ) {
            fileName = title + ".html";
            try {
                sw = new StreamWriter(fileName, false);
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            // タイトルを出力
            // タイトルを出力
            sw.WriteLine("<html><head><title>" + title + "</title></head><body>");
            sw.WriteLine("<meta http-equiv=\"Content-Type\" " +
                                           "content=\"text/html; charset=UTF-8\" />");
            sw.WriteLine("<h1>" + title + "</h1>");
        }

        public override void makeString( string str ) {
            sw.WriteLine("<p>" + str + "</p>");
        }

        public override void makeItems( string[] items ) {
            sw.WriteLine("<ul>");                       // <ul>と<li>で出力
            foreach ( string item in items){
                sw.WriteLine("<li>" + item + "</li>");
            }
            sw.WriteLine("</ul>");
        }

        public override void close() {
            sw.WriteLine("</body></html>");             
            sw.Close();      
        }

        public string getResult() {
            return fileName;
        }
    }
}
