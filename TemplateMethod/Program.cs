using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ・TempleMethodパターン
/// 　アルゴリズムの具体的な実装はサブクラスに任せる
/// 　システムのフレームワークを構築する手段としてよく使用される
/// 　一連の処理の手続きを関数にまとめることができるので、関数の抽象度が高まる
/// 　関数を継承によって差し替えるだけでいいので、拡張性が高まる
/// </summary>
namespace TemplateMethod {
    class Program {
        static void Main(string[] args) {
            AbstractDisplay d1 = new CharDisplay('H');
            AbstractDisplay d2 = new StringDisplay("Hello World!");
            AbstractDisplay d3 = new StringDisplay("こんにちは。");

            d1.display();
            d2.display();
            d3.display();

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
