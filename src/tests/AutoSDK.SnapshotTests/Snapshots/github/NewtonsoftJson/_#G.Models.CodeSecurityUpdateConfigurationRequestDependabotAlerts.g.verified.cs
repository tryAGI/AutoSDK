﻿//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependabotAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot alerts
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestDependabotAlerts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependabotAlerts.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependabotAlerts.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestDependabotAlerts.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestDependabotAlerts.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}