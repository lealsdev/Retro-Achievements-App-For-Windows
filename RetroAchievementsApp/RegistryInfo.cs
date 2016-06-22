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
        /// Save the new rank value on regedit.
        /// </summary>
        /// <param name="rank">The current user's rank.</param>
        public static void SaveRankRegistry(string rank)
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            RegistryKey retroAchievements = software.CreateSubKey("RetroAchievements");
            retroAchievements.SetValue("Rank", rank);
        }

        /// <summary>
        /// Get the current users rank
        /// </summary>
        /// <returns>The rank saved on registry.</returns>
        public static string GetRankRegistry()
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey("SOFTWARE");
            RegistryKey retroAchievements = software.OpenSubKey("RetroAchievements");

            if (retroAchievements == null)
                return null;

            Object rank = retroAchievements.GetValue("Rank");

            if (rank == null)
                return null;

            return rank.ToString();
        }

        /// <summary>
        /// Save the user in registry.
        /// </summary>
        public static void SaveUserRegistry(string user)
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            RegistryKey retroAchievements = software.CreateSubKey("RetroAchievements");
            retroAchievements.SetValue("User", user.Trim());

            UserInfo.Login = user.Trim();
        }

        /// <summary>
        /// Update the current user on registry.
        /// </summary>
        public static void ChangeUserRegistry(string user)
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            RegistryKey retroAchievements = software.CreateSubKey("RetroAchievements");
            retroAchievements.SetValue("User", user.Trim());

            UserInfo.Login = user.Trim();

            UserRankAndScoreModel model = UserConverter.GetUserRankAndScore();
            SaveRankRegistry(model.Rank);
        }

        /// <summary>
        /// Get the current user.
        /// </summary>
        /// <returns>Return the current user's username</returns>
        public static string GetUserRegistry()
        {
            RegistryKey software = Registry.CurrentUser.OpenSubKey("SOFTWARE");
            RegistryKey retroAchievements = software.OpenSubKey("RetroAchievements");

            if (retroAchievements == null)
                return null;

            Object user = retroAchievements.GetValue("User");

            if (user == null)
                return null;

            return user.ToString();
        }
    }
}
