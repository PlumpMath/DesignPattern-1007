using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    public class Hand {
        public static readonly int HANDHAVLUE_GUU = 0;
        public static readonly int HANDHAVLUE_CHO = 1;
        public static readonly int HANDHAVLUE_PAA = 2;
        public static readonly Hand[] hand = {
            new Hand(HANDHAVLUE_GUU),
            new Hand(HANDHAVLUE_CHO),
            new Hand(HANDHAVLUE_PAA),
        };

        public static readonly string[] name = {
            "グー","チョキ","パー",
        };

        private int handValue;
        public Hand(int handValue) {
            this.handValue = handValue;
        }

        /// <summary>
        /// 値からインスタンスを得る
        /// </summary>
        /// <param name="handValue"></param>
        /// <returns></returns>
        public static Hand getHand(int handValue) {
            return hand[handValue];
        }

        public Boolean isStrongerThan (Hand h) {
            return fight(h) == 1;
        }

        public Boolean isWeakerThan(Hand h) {
            return fight(h) == -1;
        }

        /// <summary>
        /// 引き分けは0、thisの勝ちなら1、hの勝ちなら-1
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        private int fight(Hand h) {
            if (this == h) {
                return 0;
            } else if ((this.handValue + 1) % 3 == h.handValue) {
                return 1;
            } else {
                return -1;
            }
        }

        public string toString() {
            return name[handValue];
        }
    }
}
