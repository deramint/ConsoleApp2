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