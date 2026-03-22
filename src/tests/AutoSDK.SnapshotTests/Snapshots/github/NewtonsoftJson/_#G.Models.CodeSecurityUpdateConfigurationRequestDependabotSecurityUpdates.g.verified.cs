//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="disabled")]
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enabled")]
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_set")]
        NotSet,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}