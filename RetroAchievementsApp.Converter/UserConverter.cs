#region copyright

// --------------------------------------------------------------------------------------------------------------------
// Copyright (C) 2016 L.A.S - LAS Soft
//
// This program is free software: you can redistribute it and/or modify
// it under the +terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
//
// UserConverter.cs - User Area: Parse the API results to a App Model.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RetroAchievementsApp.Model;
using RetroAchievementsApp.RAAPI;
using Newtonsoft.Json;

namespace RetroAchievementsApp.Converter
{
    /// <summary>
    /// User API Methods
    /// </summary>
    public class UserConverter
    {
        /// <summary>
        /// Gets the rank and score of the connected user.
        /// </summary>
        /// <returns>Rank and Score model.</returns>
        public static UserRankAndScoreModel GetUserRankAndScore()
        {
            UserAPI user = new UserAPI();

            string jsonInput = user.GetUserRankAndScore();

            UserRankAndScoreModel userRankAndScoreModel = new UserRankAndScoreModel();
            userRankAndScoreModel = JsonConvert.DeserializeObject<UserRankAndScoreModel>(jsonInput);

            return userRankAndScoreModel;
        }

        /// <summary>
        /// Gets the list of games played by the current user.
        /// </summary>
        /// <returns>The list of games played.</returns>
        public static PlayedGamesModel GetAllUserPlayedGames()
        {
            UserAPI user = new UserAPI();

            string jsonInput = user.GetAllUserPlayedGames();

            PlayedGamesModel playedGamesModel = new PlayedGamesModel();
            playedGamesModel.PlayedGames = JsonConvert.DeserializeObject<List<PlayedGamesModel.PlayedGame>>(jsonInput);

            return playedGamesModel;
        }

        /// <summary>
        /// Gets the last game played by the current user.
        /// </summary>
        /// <returns>The last game played by the user.</returns>
        public static PlayedGamesModel GetLastUserPlayedGame()
        {
            UserAPI user = new UserAPI();

            string jsonInput = user.GetAllUserPlayedGames();

            PlayedGamesModel playedGamesModel = new PlayedGamesModel();
            playedGamesModel.PlayedGames = JsonConvert.DeserializeObject<List<PlayedGamesModel.PlayedGame>>(jsonInput);

            return playedGamesModel;
        }
    }
}
