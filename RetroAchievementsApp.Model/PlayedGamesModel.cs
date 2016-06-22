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
// PlayedGamesModel.cs - played game's list model.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RetroAchievementsApp.Model
{
    public class PlayedGamesModel
    {
        public List<PlayedGame> PlayedGames = new List<PlayedGame>();

        public class PlayedGame
        {
            public string GAMEID { get; set; }

            public string ConsoleID { get; set; }

            public string ConsoleName { get; set; }

            public string Title { get; set; }

            public string ImageIcon { get; set; }

            public string LastPlayed { get; set; }

            public string MyVote { get; set; }

            public string NumPossibleAchievements { get; set; }

            public string PossibleScore { get; set; }

            public string NumAchieved { get; set; }

            public string ScoreAchieved { get; set; }
        }
    }
}
