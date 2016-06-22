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
// GameConverter.cs - Game Area: Parse the API results to a App Model.
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
using Newtonsoft.Json.Linq;

namespace RetroAchievementsApp.Converter
{
    public class GameConverter
    {
        /// <summary>
        /// Get the user progress of a game.
        /// </summary>
        /// <param name="gameID">The ID of the game.</param>
        /// <returns>The complete list of achievements of that game.</returns>
        public static GameInfoAndUserProgressModel GetGameInfoAndUserProgress(string gameID)
        {
            GameAPI game = new GameAPI();
            string jsonInput = game.GetGameInfoAndUserProgress(gameID);

            JObject jOb = JObject.Parse(jsonInput);
            IList<JToken> results = jOb["Achievements"].Children().Children().ToList();

            IList<GameInfoAndUserProgressModel.Achievement> achievementsList = new List<GameInfoAndUserProgressModel.Achievement>();
            foreach (JToken result in results)
            {
                GameInfoAndUserProgressModel.Achievement searchResult = 
                    JsonConvert.DeserializeObject<GameInfoAndUserProgressModel.Achievement>(result.ToString());

                achievementsList.Add(searchResult);
            }

            GameInfoAndUserProgressModel gameInfoAndUserProgressModel = new GameInfoAndUserProgressModel();
            gameInfoAndUserProgressModel.Achievements = achievementsList.ToList();

            return gameInfoAndUserProgressModel;
        }
    }
}
