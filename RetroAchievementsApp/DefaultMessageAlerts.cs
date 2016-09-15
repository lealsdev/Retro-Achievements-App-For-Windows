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
        /// Error details:
        /// </summary>
        const string ERROR_DETAILS_MESSAGE = "Error details:";

        /// <summary>
        /// Retro Achievements
        /// </summary>
        const string RETRO_ACHIEVEMENTS_MESSAGE = "Retro Achievements";

        /// <summary>
        /// Could not get RetroAchievement data on server.
        /// </summary>
        const string WEB_EXCEPTION_MESSAGE = "Could not get RetroAchievement data on server.";

        /// <summary>
        /// The data is in wrong format. Verify that the APIKEY is set correctly.
        /// </summary>
        const string JSON_EXCEPTION_MESSAGE = "The data is in wrong format. Verify that the APIKEY is set correctly.";

        /// <summary>
        /// You don't have permission to write or read windows registry.
        /// </summary>
        const string SECURITY_UNAUTHORIZED_EXCEPTION_MESSAGE = "You don't have permission to write or read windows registry.";

        /// <summary>
        /// An unexpected error ocurred.
        /// </summary>
        const string GENERIC_EXCEPTION_MESSAGE = "An unexpected error ocurred.";


        /// <summary>
        /// Shows a WebException error.
        /// </summary>
        /// <param name="ex">WebException exception.</param>
        public static void ShowErrorMessage(WebException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine(WEB_EXCEPTION_MESSAGE);
            errorMessage.AppendLine();
            errorMessage.AppendLine(ERROR_DETAILS_MESSAGE);
            errorMessage.Append(ex.Message);

            MessageBox.Show(errorMessage.ToString(), RETRO_ACHIEVEMENTS_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error); 
        }

        /// <summary>
        /// Shows a JsonReaderException error.
        /// </summary>
        /// <param name="ex">JsonReaderException exception.</param>
        public static void ShowErrorMessage(JsonReaderException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine(JSON_EXCEPTION_MESSAGE);
            errorMessage.AppendLine();
            errorMessage.AppendLine(ERROR_DETAILS_MESSAGE);
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), RETRO_ACHIEVEMENTS_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a SecurityException error.
        /// </summary>
        /// <param name="ex">SecurityException exception.</param>
        public static void ShowErrorMessage(SecurityException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine(SECURITY_UNAUTHORIZED_EXCEPTION_MESSAGE);
            errorMessage.AppendLine();
            errorMessage.AppendLine(ERROR_DETAILS_MESSAGE);
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), RETRO_ACHIEVEMENTS_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows an UnauthorizedAccessException error.
        /// </summary>
        /// <param name="ex">UnauthorizedAccessException exception.</param>
        public static void ShowErrorMessage(UnauthorizedAccessException ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine(SECURITY_UNAUTHORIZED_EXCEPTION_MESSAGE);
            errorMessage.AppendLine();
            errorMessage.AppendLine(ERROR_DETAILS_MESSAGE);
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), RETRO_ACHIEVEMENTS_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a generic Exception error.
        /// </summary>
        /// <param name="ex">Exception exception.</param>
        public static void ShowErrorMessage(Exception ex)
        {
            StringBuilder errorMessage = new StringBuilder();
            errorMessage.AppendLine(GENERIC_EXCEPTION_MESSAGE);
            errorMessage.AppendLine();
            errorMessage.AppendLine(ERROR_DETAILS_MESSAGE);
            errorMessage.AppendLine(ex.Message);

            MessageBox.Show(errorMessage.ToString(), RETRO_ACHIEVEMENTS_MESSAGE, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
