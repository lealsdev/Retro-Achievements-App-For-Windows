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
// Splash.cs - Initial application load.
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
        /// Do the load on a separate thread.
        /// </summary>
        /// <param name="sender">BackgroundWorker.</param>
        /// <param name="e">Event arguments.</param>
        private void backgroundWorkerUser_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                backgroundWorkerUser.ReportProgress(2);
                LoadLoginUser();

                backgroundWorkerUser.ReportProgress(2);
                LoadRank();

                backgroundWorkerUser.ReportProgress(4);
                timerPositionChange_Tick(null, null);

                backgroundWorkerUser.ReportProgress(2);
                LoadLastGameInfo();
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
        /// Change the progress bar value.
        /// </summary>
        /// <param name="sender">BackgroundWorker.</param>
        /// <param name="e">Event arguments.</param>
        private void backgroundWorkerUser_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Increment(e.ProgressPercentage);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
        }

        /// <summary>
        /// Inform the main thread that the background process complete his work.
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
                Container c = new Container(this);
                c.ShowDialog();
            }
            catch (WebException ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
                this.Close();
            }
            catch (JsonReaderException ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
                this.Close();
            }
            catch (Exception ex)
            {
                timerPositionChange.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
                this.Close();
            }
        }

        /// <summary>
        /// Verify the current user position in rank.
        /// If the user position has changed, show a baloon tip
        /// with that information.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerPositionChange_Tick(object sender, EventArgs e)
        {
            try
            {
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
        /// Closes the container form.
        /// </summary>
        /// <param name="sender">Notify icon's menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void closeToolStripMenuClose_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Do you want to close Retro Achievements Application?", "Retro Achievements", MessageBoxButtons.YesNo);

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
                PlayedGamesModel model = UserConverter.GetLastUserPlayedGame();

                if (model.PlayedGames == null || model.PlayedGames.Count == 0 || this.playedGamesModel.PlayedGames.Count == 0)
                {
                    this.playedGamesModel = model;
                    return;
                }

                if (model.PlayedGames[0].GAMEID == this.playedGamesModel.PlayedGames[0].GAMEID &&
                    model.PlayedGames[0].NumAchieved != this.playedGamesModel.PlayedGames[0].NumAchieved)
                {

                    String rankPositionChangedMessage = String.Format("Earned {0} of {1} achievements",
                        model.PlayedGames[0].NumAchieved, model.PlayedGames[0].NumPossibleAchievements);

                    notifyIconRA.ShowBalloonTip(10000, model.PlayedGames[0].Title, rankPositionChangedMessage, ToolTipIcon.Info);
                }

                this.playedGamesModel = model;
            }
            catch (Exception ex)
            {
                timerAchievementEarned.Enabled = false;
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
        /// Show the about form.
        /// </summary>
        /// <param name="sender">About menu item.</param>
        /// <param name="e">Event arguments.</param>
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }       

        /// <summary>
        /// Load the user registered from windows registry.
        /// </summary>
        private void LoadLoginUser()
        {
            string user = RegistryInfo.GetUserRegistry();

            if (user != null)
            {
                UserInfo.Login = user;
            }
        }

        /// <summary>
        /// load the user's rank in from windows registry.
        /// </summary>
        private void LoadRank()
        {
            string rank = RegistryInfo.GetRankRegistry();

            if (rank == null)
            {
                UserInfo.Rank = null;
                return;
            }

            UserInfo.Rank = rank.ToString();
        }

        /// <summary>
        /// Load information about the last played game
        /// </summary>
        private void LoadLastGameInfo()
        {
            this.playedGamesModel = UserConverter.GetLastUserPlayedGame();
        }
  
        /// <summary>
        /// Shows a notifyicon's balloontip informing a won or lost rank position
        /// </summary>
        /// <param name="model">Rank and Score model.</param>
        private void ShowRankPositionChanged(UserRankAndScoreModel model)
        {
            int oldRank = int.Parse(UserInfo.Rank);
            int newRank = int.Parse(model.Rank);

            String rankPositionChangedMessage = "";
            String rankNewPositionMessage = "";

            if (oldRank < newRank)
            {
                int positionsLost = newRank - oldRank;

                if (positionsLost == 1)
                    rankPositionChangedMessage = String.Format("You lost {0} rank position", positionsLost);
                else
                    rankPositionChangedMessage = String.Format("You lost {0} rank positions", positionsLost);

                rankNewPositionMessage = String.Format("Now your position is {0}", model.Rank);
            }
            else
            {
                int positionsWon = oldRank - newRank;

                if (positionsWon == 1)
                    rankPositionChangedMessage = String.Format("You won {0} rank position", positionsWon);
                else
                    rankPositionChangedMessage = String.Format("You won {0} rank positions", positionsWon);

                rankNewPositionMessage = String.Format("Now your position is {0}", model.Rank);
            }

            notifyIconRA.ShowBalloonTip(10000, rankPositionChangedMessage, rankNewPositionMessage, ToolTipIcon.Info);
        }
    }
}
