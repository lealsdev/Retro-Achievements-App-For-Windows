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
// PlayedGameInfo.cs - Shows game information.
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
using RetroAchievementsApp.Converter;
using RetroAchievementsApp.Model;
using System.Net;
using Newtonsoft.Json;

namespace RetroAchievementsApp.UserControls
{
    public partial class PlayedGameInfo : UserControl
    {
        internal PlayedGamesModel.PlayedGame PlayedGame;
        private GameAchievements gameAchievements;

        private bool _achievementsListOpen = false;

        public PlayedGameInfo(PlayedGamesModel.PlayedGame playedGame)
        {
            this.PlayedGame = playedGame;
            InitializeComponent();
        }

        /// <summary>
        /// Sets the game and achievement information.
        /// </summary>
        /// <param name="sender">The user control.</param>
        /// <param name="e">Event arguments.</param>
        private void PlayedGameInfo_Load(object sender, EventArgs e)
        {
            try
            {
                lblConsole.Text = this.PlayedGame.ConsoleName;
                lblTitle.Text = this.PlayedGame.Title;
                lblPossibleAchievements.Text = this.PlayedGame.NumPossibleAchievements;
                lblPossibleScore.Text = this.PlayedGame.PossibleScore;
                lblAchievementsAchieved.Text = this.PlayedGame.NumAchieved;
                lblScoreAchieved.Text = this.PlayedGame.ScoreAchieved;
                lblLastTimePlayed.Text = this.PlayedGame.LastPlayed;

                picGameImage.ImageLocation = String.Concat("http://i.retroachievements.org", this.PlayedGame.ImageIcon);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Open or close the achievements list.
        /// </summary>
        /// <param name="sender">The game picturebox.</param>
        /// <param name="e">Event arguments.</param>
        private void picGameImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this._achievementsListOpen)
                {
                    GameInfoAndUserProgressModel model = GameConverter.GetGameInfoAndUserProgress(this.PlayedGame.GAMEID);

                    gameAchievements = new GameAchievements(model);
                    gameAchievements.Location = new Point(this.Location.X, this.Size.Height - 40);
                    this.Controls.Add(gameAchievements);
                }
                else
                {
                    this.Controls.Remove(gameAchievements);
                }

                this._achievementsListOpen = !this._achievementsListOpen;
                this.timerPlayedGameInfo.Enabled = this._achievementsListOpen;
            }
            catch (WebException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (JsonReaderException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Updates the game and achievements information.
        /// </summary>
        /// <param name="playedGame">The game content updated.</param>
        public void UpdatePlayedGameInfo(PlayedGamesModel.PlayedGame playedGame)
        {
            this.PlayedGame = playedGame;

            lblConsole.Text = this.PlayedGame.ConsoleName;
            lblTitle.Text = this.PlayedGame.Title;
            lblPossibleAchievements.Text = this.PlayedGame.NumPossibleAchievements;
            lblPossibleScore.Text = this.PlayedGame.PossibleScore;
            lblAchievementsAchieved.Text = this.PlayedGame.NumAchieved;
            lblScoreAchieved.Text = this.PlayedGame.ScoreAchieved;
            lblLastTimePlayed.Text = this.PlayedGame.LastPlayed;
        }

        /// <summary>
        /// If it is the currently played game, shows 
        /// new info about achievements and score.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerPlayedGameInfo_Tick(object sender, EventArgs e)
        {
            try
            {
                if (this.Parent == null || this.Parent.Controls.Count == 0)
                    return;

                if (this.Parent.Controls[0] == this)
                {
                    GameInfoAndUserProgressModel model = GameConverter.GetGameInfoAndUserProgress(this.PlayedGame.GAMEID);

                    bool achievementUpdate = false;
                    if (gameAchievements._gameInfoAndUserProgressModel.Achievements.Count != model.Achievements.Count)
                        return;

                    achievementUpdate = this.FindUpdatedAchievements(model);

                    if (achievementUpdate)
                    {
                        this.Controls.Remove(gameAchievements);

                        gameAchievements = new GameAchievements(model);
                        gameAchievements.Location = new Point(this.Location.X, this.Size.Height - 40);

                        this.Controls.Add(gameAchievements);
                    }
                }
            }
            catch (WebException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (JsonReaderException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Look for updated achievements.
        /// </summary>
        /// <param name="model">Achievements returned from RA's server.</param>
        /// <returns>Indicates that an achievement needs to be updated.</returns>
        private bool FindUpdatedAchievements(GameInfoAndUserProgressModel model)
        {
            bool achievementsUpdate = false;

            for (int i = 0; i < gameAchievements._gameInfoAndUserProgressModel.Achievements.Count; ++i)
            {
                int updatedAchievements = model.Achievements.Count(a => a.ID == gameAchievements._gameInfoAndUserProgressModel.Achievements[i].ID
                    &&
                    (gameAchievements._gameInfoAndUserProgressModel.Achievements[i].DateEarned != model.Achievements[i].DateEarned ||
                    gameAchievements._gameInfoAndUserProgressModel.Achievements[i].DateEarnedHardcore != model.Achievements[i].DateEarnedHardcore));

                if (updatedAchievements > 0)
                {
                    achievementsUpdate = true;
                    break;
                }
            }

            return achievementsUpdate;
        }
    }
}
