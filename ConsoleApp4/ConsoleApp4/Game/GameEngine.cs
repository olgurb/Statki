using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.Player;

namespace ConsoleApp4.Game
{
    public class GameEngine
    {
        private PlayerBase PlayerOne { get; set; }
        private PlayerBase PlayerTwo { get; set; }

        private GameEngine(PlayerBase playerOne, PlayerBase playerTwo)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
        }

        public static GameEngine CreateGameWithAI(PlayerBase player)
        {
            return new GameEngine(player, new AIPlayer());
        }

        public static GameEngine CreateGamePvP(PlayerBase playerOne, PlayerBase playerTwo)
        {
            if (playerOne == null || playerTwo == null)
                throw new Exception("Player can not be null!");
            return new GameEngine(playerOne, playerTwo);
        }

        public void StartGame()
        {
            PlayerOne.SetupShips();
            PlayerTwo.SetupShips();
            // TODO: finish this next time
           
        }

        private bool isPlayerOneFirst()
        {
            var random = new Random();
            return random.Next(1, 10) % 2 == 0;
        }
    }
}
