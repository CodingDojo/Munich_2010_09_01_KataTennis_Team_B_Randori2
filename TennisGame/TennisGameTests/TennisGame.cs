using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TennisGameTests
{
    public class TennisGame
    {
        private Dictionary<TennisPlayer, int> scores = new Dictionary<TennisPlayer, int>()
            {
                { TennisPlayer.One, 0 },
                { TennisPlayer.Two, 0 }
            };

        public bool IsOver 
        {
            get
            {
                return 
                    PlayersHaveTwoPointsDifference() && 
                    AnyPlayerHasAtMoreThenPoints();
            }
        }

        public void Score(TennisPlayer tennisPlayer)
        {
            scores[tennisPlayer]++;
        }

        private bool PlayersHaveTwoPointsDifference()
        {
            return Math.Abs(scores[TennisPlayer.One] - scores[TennisPlayer.Two]) > 1;
        }

        private bool AnyPlayerHasAtMoreThenPoints()
        {
            return scores[TennisPlayer.One] > 3 || scores[TennisPlayer.Two] > 3;
        }
    }
}
