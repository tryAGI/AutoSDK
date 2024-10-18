//HintName: G.Models.CodeSecurityCreateConfigurationRequestDependabotAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot alerts<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityCreateConfigurationRequestDependabotAlerts
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
    public static class CodeSecurityCreateConfigurationRequestDependabotAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestDependabotAlerts value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestDependabotAlerts.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestDependabotAlerts.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestDependabotAlerts? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestDependabotAlerts.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestDependabotAlerts.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestDependabotAlerts.NotSet,
                _ => null,
            };
        }
    }
}