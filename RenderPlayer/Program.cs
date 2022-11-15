namespace MyProgramm
{
    class Programm
    {
        static void Main()
        {
            Player player = new Player();
            Renderer draw = new Renderer();
            draw.DrawPlayerIcon(player);
        }
    }

    class Player
    {
        public char PlayerChar { get; private set; }
        private int _health;
        private int _damage;
        public int PlayerPositionX { get; private set; }
        public int PlayerPositionY { get; private set; }

        public Player(char playerChar, int health, int damage, int playerPositionX, int playerPositionY)
        {
            PlayerChar = playerChar;
            _health = health;
            _damage = damage;
            PlayerPositionX = playerPositionX;
            PlayerPositionY = playerPositionY;
        }

        public Player()
        {
            PlayerChar = (char)02;
            _health = 100;
            _damage = 20;
            PlayerPositionX = 5;
            PlayerPositionY = 5;
        }
    }

    class Renderer
    {
        public void DrawPlayerIcon(Player player)
        {
            Console.SetCursorPosition(player.PlayerPositionX, player.PlayerPositionY);
            Console.Write(player.PlayerChar);
        }
    }
}