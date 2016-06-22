To run this project, you have to set the username and the APIKey to make connection to the
RA API.

The code file is RetroAchievementsApp.RAAPI/APIBase.cs

And that is the method where you have to do theses configurations:

public static string GetUserInfoQuerystring()
{
      Login = "";
      APIKEY = "";

      return String.Format(USER_AND_KEY_QUERYSTRING_PARAMS, Login, APIKEY);
}

Also, to work with the installer, you will have to set some files to your correctly directories. The errors in Visual Studio will help you to adjust these file paths.