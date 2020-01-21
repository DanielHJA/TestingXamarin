using System;
using Foundation;

namespace Testing.iOS
{
    public class iOSUserPreferences : IUserPreferences
    {

        public string GetString()
        {
            return "This is iOS";
        }

    }
}
