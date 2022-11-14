/*
 * このプログラムの目的
 * 再帰による処理の流れを理解し、同時にパラメーターの値についても理解を深めることで
 * プログラム自体に対する理解を深める
 * 
 * ※繰り返し構文使用禁止（for,while）
 * ※入力ミスはない前提
 * 
 * このプログラムの仕様
 * 半角数字を入力しその数字に応じた＊を出力する。
 * 
 * 以下実行時の流れ
 * 
 * 例１
 * 入力値↓
 * 5
 * 
 * 出力値↓
 * *
 * **
 * ***
 * ****
 * *****
 * ****
 * ***
 * **
 * *
 * 
 * 例２
 * 入力値↓
 * 10
 * 
 * 出力値↓
 * *
 * **
 * ***
 * ****
 * *****
 * ******
 * *******
 * ********
 * *********
 * **********
 * *********
 * ********
 * *******
 * ******
 * *****
 * ****
 * ***
 * **
 * *
 * 
 */


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("任意の数値を入力");
            int maxnum = int.Parse(Console.ReadLine());//＊の最大数
            int counter = 0;//行の＊数
            int raw = 1;//行
            Console.WriteLine("以下、出力結果\n");
            RepeatMethod(raw, counter, maxnum);
        }


        static void RepeatMethod(int raw, int counter, int maxnum)
        {
            //その行における＊最大数に達したら改行
            if (counter == raw)
            {
                Console.WriteLine();
                raw++;
                counter = 0;
            }
            //行数が＊の最大数値以下なら実行
            if (raw <= maxnum)
            {
                Console.Write("*");
                counter++;
                RepeatMethod(raw, counter, maxnum);//自分を呼び出す
            }


            //--------下記処理は上記で自分を呼び出し終了後に実行　※パラメーターは再帰前の値が入ってる。----------------
            //これが再帰


            //そのまま出力すると＊が多すぎるので１行分見送る
            if(raw < maxnum)
            {
                Console.Write("*");
            }
            //そのまま出力すると＊が多すぎるので１行分見送る＆行の終わりに改行
            if (--counter == 0 && raw <maxnum )
            {
                Console.WriteLine();
            }  

        }

    }
}