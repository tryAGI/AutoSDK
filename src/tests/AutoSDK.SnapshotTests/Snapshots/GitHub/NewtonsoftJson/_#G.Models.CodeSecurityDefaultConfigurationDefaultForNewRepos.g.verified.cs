//HintName: G.Models.CodeSecurityDefaultConfigurationDefaultForNewRepos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of newly created repositories for which the code security configuration will be applied to by default
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityDefaultConfigurationDefaultForNewRepos
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private_and_internal")]
        PrivateAndInternal,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
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
                CodeSecurityDefaultConfigurationDefaultForNewRepos.Public => "public",
                CodeSecurityDefaultConfigurationDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecurityDefaultConfigurationDefaultForNewRepos.All => "all",
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
                "public" => CodeSecurityDefaultConfigurationDefaultForNewRepos.Public,
                "private_and_internal" => CodeSecurityDefaultConfigurationDefaultForNewRepos.PrivateAndInternal,
                "all" => CodeSecurityDefaultConfigurationDefaultForNewRepos.All,
                _ => null,
            };
        }
    }
}