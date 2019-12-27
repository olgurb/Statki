namespace ConsoleApp4.Game
{
    public class ShipConfig
    {
        public int AmmountOfShips { get; set; }
        public int Lifes { get; set; }
        public ShipConfig(int ammount, int lifes)
        {
            AmmountOfShips = ammount;
            Lifes = lifes;
        }
    }
}
