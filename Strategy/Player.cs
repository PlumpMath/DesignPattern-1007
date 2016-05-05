using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy {
    class Player {
        private string name;
        private IStrategy strategy;
        private int winCount;
        private int loseCount;
        private int gameCount;
        public Player(string name, IStrategy strategy) {
            this.name = name;
            this.strategy = strategy;
        }

        public Hand nextHand() {
            return strategy.nextHand();
        }

        public void win() {
            strategy.study(true);
            winCount++;
            gameCount++;
        }

        public void lose() {
            strategy.study(false);
            loseCount++;
            gameCount++;
        }

        public void even() {
            gameCount++;
        }

        public string toString() {
            return "[" + name + ":" + gameCount + " games, " + winCount + " win, " + loseCount + " lose]"; 
        }
    }
}
