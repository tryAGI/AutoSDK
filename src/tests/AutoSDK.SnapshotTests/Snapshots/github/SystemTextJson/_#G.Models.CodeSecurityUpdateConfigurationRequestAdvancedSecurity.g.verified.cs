//HintName: G.Models.CodeSecurityUpdateConfigurationRequestAdvancedSecurity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestAdvancedSecurity
    {
        /// <summary>
        /// 
        /// </summary>
        Enabled,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CodeSecurityUpdateConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled,
                _ => null,
            };
        }
    }
}