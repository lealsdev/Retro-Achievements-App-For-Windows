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
// GameAchievements.cs - Shows game achievements.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RetroAchievementsApp.Model;

namespace RetroAchievementsApp.UserControls
{
    public partial class GameAchievements : UserControl
    {
        internal GameInfoAndUserProgressModel _gameInfoAndUserProgressModel;

        public GameAchievements(GameInfoAndUserProgressModel model)
        {
            this._gameInfoAndUserProgressModel = model;
            InitializeComponent();
        }

        /// <summary>
        /// Loads the achievements.
        /// </summary>
        /// <param name="sender">This form.</param>
        /// <param name="e">Event arguments.</param>
        private void GameAchievements_Load(object sender, EventArgs e)
        {

            try
            {
                if (!Utils.IsConnectedToInternet())
                    return;

                for (int i = 0; i < this._gameInfoAndUserProgressModel.Achievements.Count; ++i)
                {
                    PictureBox badge = this.LoadBadge(this._gameInfoAndUserProgressModel.Achievements[i]);

                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(badge, this.LoadToolTipContent(this._gameInfoAndUserProgressModel.Achievements[i]));
                    toolTip.InitialDelay = 1;

                    pnlAchievements.Controls.Add(badge);
                }
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Verify if is time to start a new line.
        /// </summary>
        /// <param name="sender">The achievement's panel.</param>
        /// <param name="e">Event arguments.</param>
        private void pnlAchievements_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                if (pnlAchievements.Controls.Count % 10 == 0)
                    pnlAchievements.SetFlowBreak(e.Control as Control, true);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Sets the PictureBox and loads the badge into it.
        /// </summary>
        /// <param name="achievement">Achievement info.</param>
        /// <returns>The formatted picturebox.</returns>
        private PictureBox LoadBadge(GameInfoAndUserProgressModel.Achievement achievement)
        {
            PictureBox badge = new PictureBox();

            if (String.IsNullOrWhiteSpace(achievement.DateEarnedHardcore) &&
                    String.IsNullOrWhiteSpace(achievement.DateEarned))
            {
                badge.ImageLocation =
                    String.Format("http://retroachievements.org/Badge/{0}_lock.png", achievement.BadgeName);
            }
            else
            {
                badge.ImageLocation =
                    String.Format("http://retroachievements.org/Badge/{0}.png", achievement.BadgeName);
            }

            badge.Size = new Size(50, 50);
            badge.SizeMode = PictureBoxSizeMode.StretchImage;

            return badge;
        }

        /// <summary>
        /// Loads the text content of the achievement tooltip.
        /// </summary>
        /// <param name="achievement">Achievement information.</param>
        /// <returns>The text formatted.</returns>
        private string LoadToolTipContent(GameInfoAndUserProgressModel.Achievement achievement)
        {
            StringBuilder toolTipContent = new StringBuilder();
            toolTipContent.AppendLine(achievement.Title);
            toolTipContent.AppendLine(achievement.Description);
            toolTipContent.Append("Date Earned: ");
            toolTipContent.AppendLine(achievement.DateEarned);
            toolTipContent.Append("Date Earned Hardcore: ");
            toolTipContent.AppendLine(achievement.DateEarnedHardcore);

            return toolTipContent.ToString();
        }
    }
}
