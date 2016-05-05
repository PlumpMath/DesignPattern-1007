using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Strategyパターン
/// ・アルゴリズムをクラス化する
///   使用するクラスとは無関係に切り替えを簡単に行える
///   戦略の部分を意識して別クラスにすることによって
///   メソッドの中に溶け込んだアルゴリズムより柔軟でメンテナブルとなる
/// </summary>
namespace Strategy {
    class Program {
        static void Main(string[] args) {
            if (args.Length != 2) {
                Console.WriteLine("Usage: Strategy randomseed1 randomseed2");
                return;
            }

            int seed1 = int.Parse(args[0]);
            int seed2 = int.Parse(args[1]);
            Player player1 = new Player("Taro", new WinningStrategy(seed1));
            Player player2 = new Player("Hana", new ProbStrategy(seed2));
            for (int i = 0; i < 10000; i++) {
                Hand nextHand1 = player1.nextHand();
                Hand nextHand2 = player2.nextHand();
                if (nextHand1.isStrongerThan(nextHand2)) {
                    Console.WriteLine("Winner:" + player1.toString());
                    player1.win();
                    player2.lose();
                } else if (nextHand2.isStrongerThan(nextHand1)) {
                    Console.WriteLine("Winner:" + player2.toString());
                    player1.lose();
                    player2.win();
                } else {
                    Console.WriteLine("Even...");
                    player1.even();
                    player2.even();
                }
            }

            Console.WriteLine("Total result:");
            Console.WriteLine(player1.toString());
            Console.WriteLine(player2.toString());

#if DEBUG
            Console.ReadKey();
#endif

        }
    }
}
