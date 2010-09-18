using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisGameTests
{
    [TestClass]
    public class TennisGameTest
    {
        [TestMethod]
        public void When_Both_Players_Have_No_Points_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();
            Assert.IsFalse(game.IsOver);
        }

        [TestMethod]
        public void When_Player_One_Scores_And_Player_Two_Has_One_Point_Less_Then_Game_Is_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 30

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); // game

            Assert.IsTrue(game.IsOver);
        }

        [TestMethod]
        public void When_Both_Players_Have_Same_Score_And_Player_One_Scores_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 40

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); // adv

            Assert.IsFalse(game.IsOver);
        }

        [TestMethod]
        public void When_Both_Players_Have_40_Score_And_Player_One_Scores_Two_Times_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 40

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); // adv
            game.Score(TennisPlayer.One); // game

            Assert.IsTrue(game.IsOver);
        }

        [TestMethod]
        public void When_Both_Players_Have_40_Score_And_Player_Two_Scores_Two_Times_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); //40

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 40
            game.Score(TennisPlayer.Two); // adv
            game.Score(TennisPlayer.Two); // game

            Assert.IsTrue(game.IsOver);
        }

        [TestMethod]
        public void When_Player_Two_Has_Advantage_And_Player_One_Scores_Three_Times_Game_Is_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 40
            game.Score(TennisPlayer.Two); // adv

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); //40

            game.Score(TennisPlayer.One); //deuce
            game.Score(TennisPlayer.One); //adv 
            game.Score(TennisPlayer.One); //game 

            Assert.IsTrue(game.IsOver);
        }

        [TestMethod]
        public void When_Player_Two_Has_Advantage_And_Player_One_Scores_One_Time_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two);
            game.Score(TennisPlayer.Two); // 40
            game.Score(TennisPlayer.Two); // adv

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One); //40
            game.Score(TennisPlayer.One); 

            Assert.IsFalse(game.IsOver);
        }

        [TestMethod]
        public void When_Player_One_Scores_Two_Times_And_Player_Two_Does_Not_Score_Then_Game_Is_Not_Over()
        {
            TennisGame game = new TennisGame();

            game.Score(TennisPlayer.One);
            game.Score(TennisPlayer.One);

            Assert.IsFalse(game.IsOver);
        }
    }
}
