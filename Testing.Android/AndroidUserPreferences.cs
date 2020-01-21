using System;
namespace Testing.Droid
{
    public class AndroidUserPreferences : IUserPreferences
    {

        public string GetString()
        {
            return "This is Android";
        }

    }
}
