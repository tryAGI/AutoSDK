//HintName: G.Models.CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies which types of repository this security configuration is applied to by default.
    /// </summary>
    public enum CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos
    {
        /// <summary>
        /// 
        /// </summary>
        All,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        PrivateAndInternal,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewReposExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos value)
        {
            return value switch
            {
                CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.All => "all",
                CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.None => "none",
                CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.All,
                "none" => CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.None,
                "private_and_internal" => CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.PrivateAndInternal,
                "public" => CodeSecuritySetConfigurationAsDefaultResponseDefaultForNewRepos.Public,
                _ => null,
            };
        }
    }
}