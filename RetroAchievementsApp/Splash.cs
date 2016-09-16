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
// Splash.cs - Application's load.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using RetroAchievementsApp.Model;
using Newtonsoft.Json;
using System.Net;
using RetroAchievementsApp.Converter;

namespace RetroAchievementsApp
{
    public partial class Splash : Form
    {
        /// <summary>
        /// You lost {0} rank position
        /// </summary>
        const string RANK_POSITION_LOST_MESSAGE = "You lost {0} rank position";

        /// <summary>
        /// You lost {0} rank positions
        /// </summary>
        const string RANK_POSITIONS_LOST_MESSAGE = "You lost {0} rank positions";

        /// <summary>
        /// You won {0} rank position
        /// </summary>
        const string RANK_POSITION_WON_MESSAGE = "You won {0} rank position";

        /// <summary>
        /// You won {0} rank positions
        /// </summary>
        const string RANK_POSITIONS_WON_MESSAGE = "You won {0} rank positions";

        /// <summary>
        /// Now your position is {0}
        /// </summary>
        const string NEW_RANK_POSITION_MESSAGE = "Now your position is {0}";

        /// <summary>
        /// Earned {0} of {1} achievements
        /// </summary>
        const string ACHIEVEMENTS_EARNED_MESSAGE = "Earned {0} of {1} achievements";

        /// <summary>
        /// Do you want to close Retro Achievements Application?
        /// </summary>
        const string CLOSE_APPLICATION_QUESTION_MESSAGE = "Do you want to close Retro Achievements Application?";

        /// <summary>
        /// 10000
        /// </summary>
        const int NOTIFY_BALLON_TIP_TIMEOUT = 10000;



        PlayedGamesModel playedGamesModel;

        public Splash()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the app load.
        /// </summary>
        /// <param name="sender">Splash form.</param>
        /// <param name="e">Event Arguments.</param>
        private void Splash_Shown(object sender, EventArgs e)
        {
            try
            {
                timerPositionChange.Enabled = false;
                timerAchievementEarned.Enabled = false;
                backgroundWorkerUser.RunWorkerAsync();
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
        /// Loads the app on a separate thread.
        /// </summary>
        /// <param name="sender">BackgroundWorker.</param>
        /// <param name="e">Event arguments.</param>
        private void backgroundWorkerUser_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorkerUser.ReportProgress(3);
                LoadLoginUser();

                backgroundWorkerUser.ReportProgress(3);
                LoadRank();

                backgroundWorkerUser.ReportProgress(3);
                timerPositionChange_Tick(null, null);

                backgroundWorkerUser.ReportProgress(1);
                LoadLastGameInfo();
            }
            catch (WebException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
                Application.Exit();
            }
            catch (JsonReaderException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
                Application.Exit();
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
                Application.Exit();
            }
        }

        /// <summary>
        /// Changes the progress bar value.
        /// </summary>
        /// <param name="sender">BackgroundWorker.</param>
        /// <param name="e">Event arguments.</param>
        private void backgroundWorkerUser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                pgbLoad.Increment(e.ProgressPercentage);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Informs the main thread that the background process completes his work.
        /// </summary>
        /// <param name="sender">BackgroundWorker.</param>
        /// <param name="e">Event arguments.</param>
        private void backgroundWorkerUser_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                timerPositionChange.Enabled = true;
                timerAchievementEarned.Enabled = true;
                this.Visible = false;
                Container container = new Container(this);
                container.ShowDialog();
            }
            catch (WebException ex)
            {
                timerPositionChange.Enabled = false;
                timerAchievementEarned.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (JsonReaderException ex)
            {
                timerPositionChange.Enabled = false;
                timerAchievementEarned.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                timerPositionChange.Enabled = false;
                timerAchievementEarned.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Verify the current user position in rank.
        /// If the user position has changed, shows a baloon tip
        /// with that information.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerPositionChange_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.IsConnectedToInternet())
                    return;

                if (!string.IsNullOrWhiteSpace(UserInfo.Login))
                {
                    UserRankAndScoreModel model = UserConverter.GetUserRankAndScore();

                    if (UserInfo.Rank == null)
                    {
                        RegistryInfo.SaveRankRegistry(model.Rank);
                        UserInfo.Rank = model.Rank;
                    }
                    else if (UserInfo.Rank != model.Rank)
                    {
                        this.ShowRankPositionChanged(model);

                        RegistryInfo.SaveRankRegistry(model.Rank);
                        UserInfo.Rank = model.Rank;
                    }
                }
            }
            catch (WebException ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (JsonReaderException ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Opens the Container form.
        /// </summary>
        /// <param name="sender">Notify icon's menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                Container container = new Container(this);
                container.ShowDialog();
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Closes the app.
        /// </summary>
        /// <param name="sender">Notify icon's menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void closeToolStripMenuClose_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(CLOSE_APPLICATION_QUESTION_MESSAGE, this.Text, MessageBoxButtons.YesNo);

            if (result == System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        /// <summary>
        /// Shows up a baloon informing the number of achievements 
        /// earned for the current game.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerAchievementEarned_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.IsConnectedToInternet())
                    return;

                PlayedGamesModel model = UserConverter.GetLastUserPlayedGame();

                if (model.PlayedGames == null || model.PlayedGames.Count == 0 || this.playedGamesModel.PlayedGames.Count == 0)
                {
                    this.playedGamesModel = model;
                    return;
                }

                if (model.PlayedGames[0].GAMEID == this.playedGamesModel.PlayedGames[0].GAMEID &&
                    model.PlayedGames[0].NumAchieved != this.playedGamesModel.PlayedGames[0].NumAchieved)
                {

                    String rankPositionChangedMessage = String.Format(ACHIEVEMENTS_EARNED_MESSAGE,
                        model.PlayedGames[0].NumAchieved, model.PlayedGames[0].NumPossibleAchievements);

                    notifyIconRA.ShowBalloonTip(NOTIFY_BALLON_TIP_TIMEOUT, model.PlayedGames[0].Title, rankPositionChangedMessage, ToolTipIcon.Info);
                }

                this.playedGamesModel = model;
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Opens the help file.
        /// </summary>
        /// <param name="sender">Help menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void toolStripMenuItemHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, String.Concat(Environment.CurrentDirectory, @"\RetroAchievements.chm"));
        }

        /// <summary>
        /// Shows the about form.
        /// </summary>
        /// <param name="sender">About menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }       

        /// <summary>
        /// Load the user from windows registry.
        /// </summary>
        private void LoadLoginUser()
        {
            string user = RegistryInfo.GetUserRegistry();

            if (user != null)
                UserInfo.Login = user;
        }

        /// <summary>
        /// load the user's rank from windows registry.
        /// </summary>
        private void LoadRank()
        {
            UserInfo.Rank = RegistryInfo.GetRankRegistry();
        }

        /// <summary>
        /// Load information about the last played game.
        /// </summary>
        private void LoadLastGameInfo()
        {
            this.playedGamesModel = UserConverter.GetLastUserPlayedGame();
        }
  
        /// <summary>
        /// Shows a notifyicon's balloontip informing the new position.
        /// </summary>
        /// <param name="model">Rank and Score model.</param>
        private void ShowRankPositionChanged(UserRankAndScoreModel model)
        {
            int oldRank = int.Parse(UserInfo.Rank);
            int newRank = int.Parse(model.Rank);

            string rankPositionChangedMessage = String.Empty;
            string rankNewPositionMessage = String.Empty;

            if (oldRank < newRank)
            {
                int positionsLost = newRank - oldRank;

                rankPositionChangedMessage = positionsLost == 1
                    ? string.Format(RANK_POSITION_LOST_MESSAGE, positionsLost)
                    : string.Format(RANK_POSITIONS_LOST_MESSAGE, positionsLost);
            }
            else
            {
                int positionsWon = oldRank - newRank;

                rankPositionChangedMessage = positionsWon == 1
                    ? string.Format(RANK_POSITION_WON_MESSAGE, positionsWon)
                    : string.Format(RANK_POSITIONS_WON_MESSAGE, positionsWon);
            }

            rankNewPositionMessage = string.Format(NEW_RANK_POSITION_MESSAGE, model.Rank);
            notifyIconRA.ShowBalloonTip(NOTIFY_BALLON_TIP_TIMEOUT, rankPositionChangedMessage, rankNewPositionMessage, ToolTipIcon.Info);
        }
    }
}
