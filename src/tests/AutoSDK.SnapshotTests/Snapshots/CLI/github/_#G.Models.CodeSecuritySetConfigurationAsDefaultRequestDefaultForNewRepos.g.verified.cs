﻿//HintName: G.Models.CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specify which types of repository this security configuration should be applied to by default.
    /// </summary>
    public enum CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos
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
    public static class CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewReposExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos value)
        {
            return value switch
            {
                CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.All => "all",
                CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.None => "none",
                CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.PrivateAndInternal => "private_and_internal",
                CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos? ToEnum(string value)
        {
            return value switch
            {
                "all" => CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.All,
                "none" => CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.None,
                "private_and_internal" => CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.PrivateAndInternal,
                "public" => CodeSecuritySetConfigurationAsDefaultRequestDefaultForNewRepos.Public,
                _ => null,
            };
        }
    }
}