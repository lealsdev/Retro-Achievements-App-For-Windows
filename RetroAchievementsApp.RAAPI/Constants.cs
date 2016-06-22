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
// Constants.cs - Contains the constants used for all api classes.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetroAchievementsApp.RAAPI
{
    /// <summary>
    /// Contains the constants used for all api classes.
    /// </summary>
    internal static class Constants
    {
        /// <summary>
        /// The API url.
        /// </summary>
        internal const string RA_URL = "http://retroachievements.org/API/";

        /// <summary>
        /// String that contains the TopTenUsers Method.
        /// </summary>
        internal const string METHOD_GET_TOP_TEN_USERS = "API_GetTopTenUsers.php";

        /// <summary>
        /// String that contains the GetUserRankAndScore Method.
        /// </summary>
        internal const string METHOD_GET_USER_RANK_AND_SCORE = "API_GetUserRankAndScore.php";

        /// <summary>
        /// String that contains the GetUserRecentlyPlayedGames Method.
        /// </summary>
        internal const string METHOD_GET_USER_RECENTLY_PLAYED_GAMES = "API_GetUserRecentlyPlayedGames.php";

        /// <summary>
        /// String that contains the GetGameInfoAndUserProgress Method.
        /// </summary>
        internal const string METHOD_GET_GAME_INFO_AND_USER_PROGRESS = "API_GetGameInfoAndUserProgress.php";

    }
}
