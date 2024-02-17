using MyOrganization.Debugging;

namespace MyOrganization
{
    public class MyOrganizationConsts
    {
        public const string LocalizationSourceName = "MyOrganization";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "a673c4979af646d2bac74963b96ad34f";
    }
}
