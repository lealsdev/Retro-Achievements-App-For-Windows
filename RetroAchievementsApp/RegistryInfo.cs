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
// RegistryInfo.cs - Methods to control the windows registry.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using RetroAchievementsApp.Model;
using RetroAchievementsApp.Converter;

namespace RetroAchievementsApp
{
    public static class RegistryInfo
    {
        /// <summary>
        /// SOFTWARE
        /// </summary>
        const string REGISTRY_KEY_SOFTWARE = "SOFTWARE";

        /// <summary>
        /// RetroAchievements
        /// </summary>
        const string REGISTRY_KEY_RETRO_ACHIEVEMENTS = "RetroAchievements";

        /// <summary>
        /// User
        /// </summary>
        const string REGISTRY_VALUE_USER = "User";

        /// <summary>
        /// Rank
        /// </summary>
        const string REGISTRY_VALUE_RANK = "Rank";


        /// <summary>
        /// Saves the new rank value on regedit.
        /// </summary>
        /// <param name="rank">The current user's rank.</param>
        public static void SaveRankRegistry(string rank)
        {
            RegistryKey retroAchievements = GetRetroAchievementsRegistry();
            retroAchievements.SetValue(REGISTRY_VALUE_RANK, rank);
        }

        /// <summary>
        /// Gets the current users rank
        /// </summary>
        /// <returns>The rank saved on registry.</returns>
        public static string GetRankRegistry()
        {
            RegistryKey retroAchievements = GetRetroAchievementsRegistry();

            if (retroAchievements == null)
                return null;

            Object rank = retroAchievements.GetValue(REGISTRY_VALUE_RANK);

            return rank == null ? null : rank.ToString();
        }

        /// <summary>
        /// Saves the user in registry.
        /// </summary>
        public static void SaveUserRegistry(string user)
        {
            RegistryKey retroAchievements = GetRetroAchievementsRegistry();
            retroAchievements.SetValue(REGISTRY_VALUE_USER, user.Trim());

            UserInfo.Login = user.Trim();
        }

        /// <summary>
        /// Updates the current user on registry.
        /// </summary>
        public static void ChangeUserRegistry(string user)
        {
            RegistryKey retroAchievements = GetRetroAchievementsRegistry();
            retroAchievements.SetValue(REGISTRY_VALUE_USER, user.Trim());

            UserInfo.Login = user.Trim();

            UserRankAndScoreModel model = UserConverter.GetUserRankAndScore();
            SaveRankRegistry(model.Rank);
        }

        /// <summary>
        /// Gets the current user.
        /// </summary>
        /// <returns>Return the current user's username</returns>
        public static string GetUserRegistry()
        {
            RegistryKey retroAchievements = GetRetroAchievementsRegistry();

            if (retroAchievements == null)
                return null;

            Object user = retroAchievements.GetValue(REGISTRY_VALUE_USER);

            return user == null ? null : user.ToString();
        }

        /// <summary>
        /// Returns the RetroAchievements Registry Key.
        /// </summary>
        /// <returns>RA's registry.</returns>
        private static RegistryKey GetRetroAchievementsRegistry()
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey(REGISTRY_KEY_SOFTWARE, true);
            RegistryKey retroAchievements = software.CreateSubKey(REGISTRY_KEY_RETRO_ACHIEVEMENTS);

            return retroAchievements;
        }
    }
}
