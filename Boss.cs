namespace Study2
{
    class Boss1
    {
        public string name = "";

        public int hp = 0;

        public void ShowDetail()
        {
            System.Console.WriteLine($"ボスの名前：{name} HP：{hp}");
        }
    }

    class Boss2
    {
        private string name = "";

        private int hp = 0;

        public  Boss2(string name, int hp)
        {
            this.name = name;
            this.hp = hp;
        }

        public void ShowDetail()
        {
            System.Console.WriteLine($"ボスの名前：{this.name} HP：{this.hp}");
        }
    }

    class Boss3
    {
        public string Name { private get; set; }

        public int Hp { private get; set; }

        public void ShowDetail()
        {
            System.Console.WriteLine($"ボスの名前：{this.Name} HP：{this.Hp}");
        }
    }
}