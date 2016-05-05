using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public class Director {
        private Builder builder;

        public Director(Builder builder) {
            this.builder = builder;
        }

        public void construct() {
            builder.makeTitle("Greeting");
            builder.makeString("朝から夜にかけて");
            builder.makeItems(new String[] {
                "おはようございます。",
                "こんにちは。",
            });
            builder.makeString("夜に");
            builder.makeItems(new String[] {
                "こんばんは。",
                "おやすみなさい。",
                "さようなら。",
            });
            builder.close();
        }
    }
}
