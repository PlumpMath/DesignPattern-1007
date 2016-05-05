using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    class WinningStrategy : IStrategy {

        private Random random;
        private Boolean won = false;
        private Hand preHand;
        public WinningStrategy(int seed) {
            random = new Random(seed);
        }

        Hand IStrategy.nextHand() {
            if (!won) {
                preHand = Hand.getHand(random.Next(3));
            }
            return preHand;
        }

        void IStrategy.study(bool win) {
            won = win;
        }
    }
}
