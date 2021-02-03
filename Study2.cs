namespace Study2
{
    class Program
    {
        private static void Main(string[] args)
        {
            Boss1 boss1 = new Boss1();
            boss1.name = "エイリアン";
            boss1.hp = 10;

            boss1.ShowDetail();

            Boss2 boss2 = new Boss2("プレデター", 10);

            boss2.ShowDetail();

            Boss3 boss3 = new Boss3();
            boss3.Name = "さだこ";
            boss3.Hp = 1000;

            boss3.ShowDetail();

        }
    }
}