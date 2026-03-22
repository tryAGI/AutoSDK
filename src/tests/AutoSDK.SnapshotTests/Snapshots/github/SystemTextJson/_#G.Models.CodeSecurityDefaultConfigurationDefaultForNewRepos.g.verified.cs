//HintName: G.Models.CodeSecurityDefaultConfigurationDefaultForNewRepos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of newly created repositories for which the code security configuration will be applied to by default
    /// </summary>
    public enum CodeSecurityDefaultConfigurationDefaultForNewRepos
    {
        /// <summary>
        /// 
        /// </summary>
        All,
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
    public static class CodeSecurityDefaultConfigurationDefaultForNewReposExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityDefaultConfigurationDefaultForNewRepos value)
        {
            return value switch
            {
                CodeSecurityDefaultConfigurationDefaultForNewRepos.All => "all",
                CodeSecurityDefaultConfigurationDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecurityDefaultConfigurationDefaultForNewRepos.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityDefaultConfigurationDefaultForNewRepos? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecurityDefaultConfigurationDefaultForNewRepos.All,
                "private_and_internal" => CodeSecurityDefaultConfigurationDefaultForNewRepos.PrivateAndInternal,
                "public" => CodeSecurityDefaultConfigurationDefaultForNewRepos.Public,
                _ => null,
            };
        }
    }
}