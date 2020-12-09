using System.Configuration;

namespace SqlDataAccessUI.Helper
{
    public static class ConnectionHelper
    {
        public static string GetConStringValue(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
