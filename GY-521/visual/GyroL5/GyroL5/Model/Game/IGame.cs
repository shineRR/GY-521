using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroL5.Model.Game
{
    public interface IGame
    {
        void Start();
        void Stop();
        void Update();
        bool isCorrectResult(GYModel model);
        bool IsActiveGame();
    }
}
