//HintName: G.Models.CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates
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
    public static class CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Disabled => "disabled",
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
                "enabled" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}