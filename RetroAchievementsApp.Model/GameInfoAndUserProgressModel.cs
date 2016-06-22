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
// GameInfoAndUserProgressModel.cs - Game info and user progress model.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RetroAchievementsApp.Model
{
    [JsonObjectAttribute()]
    public class GameInfoAndUserProgressModel
    {
        public string ID { get; set; }

        public string Title { get; set; }

        public string ConsoleID { get; set; }

        public string ForumTopicID { get; set; }

        public string Flags { get; set; }

        public string ImageIcon { get; set; }

        public string ImageTitle { get; set; }

        public string ImageIngame { get; set; }

        public string ImageBoxArt { get; set; }

        public string Publisher { get; set; }

        public string Developer { get; set; }

        public string Genre { get; set; }

        public string Released { get; set; }

        public string IsFinal { get; set; }

        public string ConsoleName { get; set; }

        public string RichPresencePatch { get; set; }

        public string NumAchievements { get; set; }

        public string NumDistinctPlayersCasual { get; set; }

        public string NumDistinctPlayersHardcore { get; set; }


        public List<Achievement> Achievements = new List<Achievement>();
        
        public class Achievement
        {
            public string ID { get; set; }

            public string NumAwarded { get; set; }

            public string NumAwardedHardcore { get; set; }

            public string Title { get; set; }

            public string Description { get; set; }

            public string Points { get; set; }

            public string TrueRatio { get; set; }

            public string Author { get; set; }

            public string DateModified { get; set; }

            public string DateCreated { get; set; }

            public string BadgeName { get; set; }

            public string DisplayOrder { get; set; }

            public string MemAddr { get; set; }

            public string DateEarned { get; set; }

            public string DateEarnedHardcore { get; set; }
        }
    }
}
