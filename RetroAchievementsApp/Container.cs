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
// Container.cs - Shows the application's main form.
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
using RetroAchievementsApp.Model;
using Newtonsoft.Json;
using RetroAchievementsApp.Converter;
using Microsoft.Win32;
using System.Net;
using System.Security;
using RetroAchievementsApp.UserControls;

namespace RetroAchievementsApp
{
    public partial class Container : Form
    {
        Splash _splash;

        public Container(Splash splash)
        {
            this._splash = splash;

            InitializeComponent();
        }
        
        /// <summary>
        /// The Container loads the tabs, user controls
        /// that contains the RA's information and user rank.
        /// </summary>
        /// <param name="sender">The Container Form</param>
        /// <param name="e">Event Arguments</param>
        private void Container_Load(object sender, EventArgs e)
        {
            try
            {
                this._splash.toolStripMenuItemOpen.Enabled = false;

                string user = RegistryInfo.GetUserRegistry();
                if (user != null)
                {
                    UserInfo.Login = user;
                    txtChangeUser.Text = user;
                    grbLogin.Visible = false;
                    grbChangeUser.Visible = true;

                    this.LoadUserControls();

                    lblRankPosition.Text = UserInfo.Rank;
                }
                else
                {
                    grbLogin.Visible = true;
                    grbChangeUser.Visible = false;
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
        /// Updates the rank position label.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerContainer_Tick(object sender, EventArgs e)
        {
            lblRankPosition.Text = UserInfo.Rank;
            lblRankPosition.Invalidate();
        }

        /// <summary>
        /// Saves the user.
        /// </summary>
        /// <param name="sender">The save button.</param>
        /// <param name="e">Event arguments.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this._splash.timerPositionChange.Enabled = false;

                btnSave.Text = "wait...";
                grbLogin.Enabled = false;

                UserInfo.Login = txtUser.Text.Trim();
                UserRankAndScoreModel userRankAndScoreModel = UserConverter.GetUserRankAndScore();

                if (userRankAndScoreModel.Rank == "1" && userRankAndScoreModel.Score == "0")
                {
                    txtUser.Text = UserInfo.Login = String.Empty;
                    MessageBox.Show("Invalid user.", "RetroAchievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RegistryInfo.SaveUserRegistry(txtUser.Text);
                this.LoadUserControls();

                txtChangeUser.Text = txtUser.Text;
                txtUser.Text = String.Empty;
                grbLogin.Visible = false;
                grbChangeUser.Visible = true;
            }
            catch (SecurityException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            finally 
            {
                this._splash.timerPositionChange.Enabled = true;
                btnSave.Text = "Save";
                grbLogin.Enabled = true;
            }
        }

        /// <summary>
        /// Change the current user.
        /// </summary>
        /// <param name="sender">The change button.</param>
        /// <param name="e">Event arguments.</param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                this._splash.timerPositionChange.Enabled = false;

                btnChange.Text = "wait...";
                grbChangeUser.Enabled = false;

                UserInfo.Login = txtChangeUser.Text.Trim();
                UserRankAndScoreModel userRankAndScoreModel = UserConverter.GetUserRankAndScore();

                if (userRankAndScoreModel.Rank == "1" && userRankAndScoreModel.Score == "0")
                {
                    txtChangeUser.Text = UserInfo.Login = RegistryInfo.GetUserRegistry();
                    MessageBox.Show("Invalid user.", "RetroAchievements", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RegistryInfo.SaveRankRegistry(userRankAndScoreModel.Rank);
                UserInfo.Rank = userRankAndScoreModel.Rank;
                lblRankPosition.Text = UserInfo.Rank;

                RegistryInfo.ChangeUserRegistry(txtChangeUser.Text.Trim());

                this.LoadUserControls();
            }
            catch (SecurityException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            finally
            {
                this._splash.timerPositionChange.Enabled = true;
                btnChange.Text = "Change";
                grbChangeUser.Enabled = true;
            }
        }

        /// <summary>
        /// Closes the container form.
        /// </summary>
        /// <param name="sender">Container form.</param>
        /// <param name="e">Event arguments.</param>
        private void Container_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                this.Close();
        }

        /// <summary>
        /// Enables the Open menu item.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            this._splash.toolStripMenuItemOpen.Enabled = true;

            base.OnClosing(e);
        }

        /// <summary>
        /// Loads all app's user controls.
        /// </summary>
        private void LoadUserControls()
        {
            tabControlRA.Visible = true;

            UserControls.TopTenUsers t = new UserControls.TopTenUsers();
            tabTopTenUsers.Controls.Add(t);
            t.Location = new Point(20, 20);

            tabPlayedGames.Controls.Clear();
            PlayedGamesInfo playedGamesInfo = new PlayedGamesInfo();
            tabPlayedGames.Controls.Add(playedGamesInfo);
        }

    }
}
