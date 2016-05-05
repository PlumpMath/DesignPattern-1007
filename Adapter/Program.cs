using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    /// <summary>
    /// ・Adapterパターン
    ///   ２つの異なる互換性のないクラスを、連携させるパターン
    ///   既存クラス(Adapteeクラス)のインターフェースとは、異なるインターフェースを提供させる。
    ///   「Wrapper」クラスと呼ばれたりもする。
    ///   既存クラス(Adapteeクラス)を修正することなく、インターフェースを変更することができる。
    ///   (例)
    ///     アメリカの電源プラグ(ITargetインターフェース)
    ///     変換アダプタ(Adapterクラス)
    ///     ヨーロッパのコンセント(Adapteeクラス)
    /// </summary>
    class Program {
        static void Main(string[] args) {

            // 継承を利用した方法
            ITarget target1 = new Entends.Adapter();
            target1.targetMethod1();
            target1.targetMethod2();

            // 委譲を利用した方法
            ITarget target2 = new Delegation.Adapter();
            target2.targetMethod1();
            target2.targetMethod2();

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
