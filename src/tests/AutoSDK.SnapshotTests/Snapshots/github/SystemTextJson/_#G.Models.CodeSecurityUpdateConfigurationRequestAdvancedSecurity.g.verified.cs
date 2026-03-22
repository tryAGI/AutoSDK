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
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
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
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
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
                "disabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestAdvancedSecurity.Enabled,
                _ => null,
            };
        }
    }
}