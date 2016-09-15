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
// APIBase.cs - The base class for all api classes.
// 
// Email: lealves_82@yahoo.com.br
// RetroAchievements username: FitaOuCartucho
// --------------------------------------------------------------------------------------------------------------------

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace RetroAchievementsApp.RAAPI
{
    public class APIBase
    {
        /// <summary>
        /// API Login
        /// </summary>
        internal static string Login { get; set; }

        /// <summary>
        /// API Key
        /// </summary>
        internal static string APIKEY { get; set; }

        /// <summary>
        /// String formatted to receive username and the api key.
        /// </summary>
        private const string USER_AND_KEY_QUERYSTRING_PARAMS = "?z={0}&y={1}";

        /// <summary>
        /// Connects to the server and get the data.
        /// </summary>
        /// <param name="url">Url including querystring parameters.</param>
        /// <returns>Json returned by the server.</returns>
        protected string ProcessRequest(string url)
        {
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            WebResponse myResponse = myRequest.GetResponse();

            StreamReader sr = new StreamReader(myResponse.GetResponseStream(), System.Text.Encoding.UTF8);
            string result = sr.ReadToEnd();

            sr.Close();
            myResponse.Close();

            return result;
        }

        /// <summary>
        /// Returns a querystring formatted with Login and APIKEY info.
        /// </summary>
        /// <returns>Querystring.</returns>
        public static string GetUserInfoQuerystring()
        {
            Login = "";
            APIKEY = "";

            return String.Format(USER_AND_KEY_QUERYSTRING_PARAMS, Login, APIKEY);
        }
    }
}
