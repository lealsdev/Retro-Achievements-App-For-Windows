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
// GameAPI.cs - Game Area: Calls the api model and gets the JSON results.
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

namespace RetroAchievementsApp.RAAPI
{
    public class GameAPI : APIBase
    {
        /// <summary>
        /// Gets the user progress of a game.
        /// </summary>
        /// <param name="gameID">The ID of the game.</param>
        /// <returns>The complete list of achievements of that game.</returns>
        public string GetGameInfoAndUserProgress(string gameID)
        {
            string url = String.Concat(Constants.RA_URL,
                Constants.METHOD_GET_GAME_INFO_AND_USER_PROGRESS,
                GetUserInfoQuerystring(),
                String.Format("&u={0}&g={1}", UserInfo.Login, gameID));

            return this.ProcessRequest(url);
        }
    }
}
