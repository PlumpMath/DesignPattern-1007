using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder {
    public abstract class Builder {
        public abstract void makeTitle( String title );
        public abstract void makeString( String str );
        public abstract void makeItems( String[] items );
        public abstract void close();
    }
}
