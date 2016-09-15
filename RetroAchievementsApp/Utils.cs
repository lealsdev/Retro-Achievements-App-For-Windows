using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace RetroAchievementsApp
{
    public static class Utils
    {
        /// <summary>
        /// Checks if the computer is connected.
        /// </summary>
        /// <returns>Connected or not?</returns>
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int description, int reserved);
        public static bool IsConnectedToInternet()
        {
            int description;
            return InternetGetConnectedState(out description, 0);
        }
    }
}
