namespace Study1
{
    class Program
    {
        private static void Main(string[] args)
        {
            // １．文字列と出力
            string str = "文字列";

            System.Console.WriteLine(str);

            // ２．数値と出力            
            int number1 = 1;

            string number1String = number1.ToString();

            System.Console.WriteLine(number1String);

            // ３．四則演算と出力            
            int number2 = 2;
            int sum = number1 + number2;

            System.Console.WriteLine(sum);

            // ４．引数なし・戻り値なし関数を呼び出し
            ShowHelloWorld();

            // ５．引数なし・戻り値あり関数を呼び出し            
            string message1 = GetHelloWorld();
            System.Console.WriteLine(message1);

            // ６．引数あり・戻り値あり関数を呼び出し            
            string message2 = ConvertMessage("AAA");
            System.Console.WriteLine(message2);
        }

        /// <summary>
        /// ハローワールドを表示する関数(メソッド)
        /// </summary>
        private static void ShowHelloWorld()
        {
            System.Console.WriteLine("Hello World!");
        }

        /// <summary>
        /// ハローワールドを返す関数(メソッド)
        /// </summary>
        private static string GetHelloWorld()
        {
            string message = "Hello World!";

            return message;
        }

        /// <summary>
        /// 渡された文字にBBBを付けて返す関数(メソッド)
        /// </summary>
        /// <returns></returns>
        private static string ConvertMessage(string message)
        {
            string result = message + "BBB";

            return result;
        }   
    }
}
