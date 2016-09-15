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
// UserAPI.cs - User Area: Calls the api model and gets the JSON results.
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
    public class UserAPI : APIBase
    {
        /// <summary>
        /// Gets the rank and score of the connected user.
        /// </summary>
        /// <returns>Rank and score json.</returns>
        public string GetUserRankAndScore()
        {
            string url = String.Concat(Constants.RA_URL,
                Constants.METHOD_GET_USER_RANK_AND_SCORE,
                GetUserInfoQuerystring(),
                String.Concat("&u=", UserInfo.Login));

            return this.ProcessRequest(url);
        }

        /// <summary>
        /// Gets the list of games played by the current user.
        /// </summary>
        /// <returns>The list of games played.</returns>
        public string GetAllUserPlayedGames()
        {
            return this.GetUserPlayedGames(UInt32.MaxValue);
        }

        /// <summary>
        /// Gets the last game played by the current user.
        /// </summary>
        /// <returns>The last game played by the user.</returns>
        public string GetLastUserPlayedGame()
        {
            return this.GetUserPlayedGames(1);
        }

        /// <summary>
        /// Gets the list of games played by the current user
        /// limited by the number of games to recover variable.
        /// (desc)
        /// </summary>
        /// <param name="numberOfGamesToRecover">The number of games to recover.</param>
        /// <returns>The list of games played.</returns>
        private string GetUserPlayedGames(UInt32 numberOfGamesToRecover)
        {
            string url = String.Concat(Constants.RA_URL,
                Constants.METHOD_GET_USER_RECENTLY_PLAYED_GAMES,
                GetUserInfoQuerystring(),
                String.Format("&u={0}&c={1}", UserInfo.Login, numberOfGamesToRecover));

            return this.ProcessRequest(url);
        }
    }
}
