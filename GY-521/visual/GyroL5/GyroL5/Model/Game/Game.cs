using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroL5.Model.Game
{
    enum GameState
    {
        active,
        inactive
    }

    public class Game : IGame
    {
        private int x;
        private int y;
        private int z;
        private GameState gameState = GameState.inactive;

        public void Start()
        {
            Random r = new Random();
            x = r.Next(-500, 500);
            y = r.Next(-500, 500);
            z = r.Next(-500, 500);
            gameState = GameState.active;
        }

        public void Stop()
        {
            gameState = GameState.inactive;
        }

        public void Update()
        {
            Start();
        }

        public bool IsActiveGame()
        {
            return gameState == GameState.active;
        }

        public bool isCorrectResult(GYModel model)
        {
            if (gameState == GameState.inactive) { return false; }
            return Enumerable.Range(x - 50, x + 50).Contains(model.gx) &&
                   Enumerable.Range(y - 50, y + 50).Contains(model.gy) &&
                   Enumerable.Range(z - 50, z + 50).Contains(model.gz);
        }
    }
}
