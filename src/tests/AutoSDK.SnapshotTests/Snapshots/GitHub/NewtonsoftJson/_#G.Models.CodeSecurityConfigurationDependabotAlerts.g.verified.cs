//HintName: G.Models.CodeSecurityConfigurationDependabotAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot alerts
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationDependabotAlerts
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
    public static class CodeSecurityConfigurationDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityConfigurationDependabotAlerts.Enabled => "enabled",
                CodeSecurityConfigurationDependabotAlerts.Disabled => "disabled",
                CodeSecurityConfigurationDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationDependabotAlerts.Enabled,
                "disabled" => CodeSecurityConfigurationDependabotAlerts.Disabled,
                "not_set" => CodeSecurityConfigurationDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}