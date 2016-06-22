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
// DefaultMessageAlerts.cs - Contains methods for default message alerts.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.Security;

namespace RetroAchievementsApp
{
    public static class DefaultMessageAlerts
    {
        /// <summary>
        /// Show a WebException error.
        /// </summary>
        /// <param name="ex">WebException exception.</param>
        public static void ShowErrorMessage(WebException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine("Could not get RetroAchievement data on server.");
            errorMessage.AppendLine();
            errorMessage.AppendLine("Error details:");
            errorMessage.Append(ex.Message);

            MessageBox.Show(errorMessage.ToString(), "Retro Achievements", MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        /// <summary>
        /// Show a JsonReaderException error.
        /// </summary>
        /// <param name="ex">JsonReaderException exception.</param>
        public static void ShowErrorMessage(JsonReaderException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine("The data is in wrong format. Verify that the APIKEY is set correctly.");
            errorMessage.AppendLine();
            errorMessage.AppendLine("Error details:");
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), "Retro Achievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show a SecurityException error.
        /// </summary>
        /// <param name="ex">SecurityException exception.</param>
        public static void ShowErrorMessage(SecurityException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine("You don't have permission to write or read windows registry.");
            errorMessage.AppendLine();
            errorMessage.AppendLine("Error details:");
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), "Retro Achievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show an UnauthorizedAccessException error.
        /// </summary>
        /// <param name="ex">UnauthorizedAccessException exception.</param>
        public static void ShowErrorMessage(UnauthorizedAccessException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine("You don't have permission to write or read windows registry.");
            errorMessage.AppendLine();
            errorMessage.AppendLine("Error details:");
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), "Retro Achievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Show a generic Exception error.
        /// </summary>
        /// <param name="ex">Exception exception.</param>
        public static void ShowErrorMessage(Exception ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine("An unexpected error ocurred.");
            errorMessage.AppendLine();
            errorMessage.AppendLine("Error details:");
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), "Retro Achievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
