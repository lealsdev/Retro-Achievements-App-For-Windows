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
// PlayedGamesInfo.cs - Shows a played games list.
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
using RetroAchievementsApp.Converter;
using System.Collections;
using System.Net;
using Newtonsoft.Json;

namespace RetroAchievementsApp.UserControls
{
    /// <summary>
    /// Played Games info.
    /// </summary>
    public partial class PlayedGamesInfo : UserControl
    {
        public PlayedGamesInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads the games played.
        /// </summary>
        /// <param name="sender">The user control.</param>
        /// <param name="e">Event arguments.</param>
        private void PlayedGamesInfo_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.IsConnectedToInternet())
                    return;

                timerPlayedGamesInfo.Enabled = false;

                pnlPlayedGames.Controls.Clear();
                PlayedGamesModel model = UserConverter.GetAllUserPlayedGames();
                UserControls.PlayedGameInfo p;
                foreach (PlayedGamesModel.PlayedGame playedGame in model.PlayedGames)
                {
                    p = new UserControls.PlayedGameInfo(playedGame);
                    pnlPlayedGames.Controls.Add(p);
                }

                timerPlayedGamesInfo.Enabled = true;
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
        /// Updates the played games list.
        /// </summary>
        /// <param name="sender">The timer.</param>
        /// <param name="e">Event arguments.</param>
        private void timerPlayedGamesInfo_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!Utils.IsConnectedToInternet())
                    return;

                PlayedGamesModel model = UserConverter.GetLastUserPlayedGame();

                if (model.PlayedGames.Count > 0 && pnlPlayedGames.Controls.Count > 0)
                {
                    if ((pnlPlayedGames.Controls[0] as UserControls.PlayedGameInfo).PlayedGame.GAMEID != model.PlayedGames[0].GAMEID ||
                        (pnlPlayedGames.Controls[0] as UserControls.PlayedGameInfo).PlayedGame.LastPlayed != model.PlayedGames[0].LastPlayed)
                    {
                        Array temporaryPlayedGames = Array.CreateInstance(typeof(UserControls.PlayedGameInfo), pnlPlayedGames.Controls.Count);
                        pnlPlayedGames.Controls.CopyTo(temporaryPlayedGames, 0);

                        pnlPlayedGames.Controls.Clear();

                        UserControls.PlayedGameInfo newPlayedGameInfo = new UserControls.PlayedGameInfo(model.PlayedGames[0]);
                        pnlPlayedGames.Controls.Add(newPlayedGameInfo);
                        foreach (UserControls.PlayedGameInfo p in temporaryPlayedGames)
                        {
                            if (newPlayedGameInfo.PlayedGame.GAMEID != p.PlayedGame.GAMEID)
                                pnlPlayedGames.Controls.Add(p);
                        }
                    }
                    else
                        (pnlPlayedGames.Controls[0] as PlayedGameInfo).UpdatePlayedGameInfo(model.PlayedGames[0]);
                }
                else if (model.PlayedGames.Count > 0 && pnlPlayedGames.Controls.Count == 0) //new user
                {
                    pnlPlayedGames.Controls.Add(new UserControls.PlayedGameInfo(model.PlayedGames[0]));
                }
            }
            catch (WebException ex)
            {
                this.timerPlayedGamesInfo.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (JsonReaderException ex)
            {
                this.timerPlayedGamesInfo.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            catch (Exception ex)
            {
                this.timerPlayedGamesInfo.Enabled = false;
                DefaultMessageAlerts.ShowErrorMessage(ex);
            }
            
        }
    }
}
