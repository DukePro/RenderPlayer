namespace MyProgramm
{
    class Programm
    {
        static void Main()
        {
            Player player = new Player();
            Renderer render = new Renderer();
            render.DrawPlayer(player);
        }
    }

    class Player
    {
        private int _health;
        private int _damage;

        public char Symbol { get; private set; }
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(char playerChar, int health, int damage, int playerPositionX, int playerPositionY)
        {
            Symbol = playerChar;
            _health = health;
            _damage = damage;
            PositionX = playerPositionX;
            PositionY = playerPositionY;
        }

        public Player()
        {
            Symbol = (char)02;
            _health = 100;
            _damage = 20;
            PositionX = 5;
            PositionY = 5;
        }
    }

    class Renderer
    {
        public void DrawPlayer(Player player)
        {
            Console.SetCursorPosition(player.PositionX, player.PositionY);
            Console.Write(player.Symbol);
        }
    }
}