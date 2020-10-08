using System;
using System.Configuration;

namespace Saucedemo_Automation
{
    public static class AppConfigReader
    {
        public static readonly string BaseUrl = ConfigurationManager.AppSettings["base_url"];
        //public static readonly string SignInPageUrl = ConfigurationManager.AppSettings["signin_url"];
        public static readonly string ProductsPageUrl = ConfigurationManager.AppSettings["productspage_url"];
        public static readonly string CartPageUrl = ConfigurationManager.AppSettings["cartpage_url"];
    }
}
