//HintName: G.Models.CodeSecurityConfigurationDependabotSecurityUpdates.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of Dependabot security updates
    /// </summary>
    public enum CodeSecurityConfigurationDependabotSecurityUpdates
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
    public static class CodeSecurityConfigurationDependabotSecurityUpdatesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationDependabotSecurityUpdates value)
        {
            return value switch
            {
                CodeSecurityConfigurationDependabotSecurityUpdates.Enabled => "enabled",
                CodeSecurityConfigurationDependabotSecurityUpdates.Disabled => "disabled",
                CodeSecurityConfigurationDependabotSecurityUpdates.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationDependabotSecurityUpdates? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationDependabotSecurityUpdates.Enabled,
                "disabled" => CodeSecurityConfigurationDependabotSecurityUpdates.Disabled,
                "not_set" => CodeSecurityConfigurationDependabotSecurityUpdates.NotSet,
                _ => null,
            };
        }
    }
}