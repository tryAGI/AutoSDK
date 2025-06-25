﻿//HintName: G.Models.CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityCreateConfigurationRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}