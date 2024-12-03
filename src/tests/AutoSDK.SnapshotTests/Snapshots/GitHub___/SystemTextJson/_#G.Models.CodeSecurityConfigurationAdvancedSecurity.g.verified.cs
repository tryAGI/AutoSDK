//HintName: G.Models.CodeSecurityConfigurationAdvancedSecurity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security
    /// </summary>
    public enum CodeSecurityConfigurationAdvancedSecurity
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
    public static class CodeSecurityConfigurationAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityConfigurationAdvancedSecurity.Enabled => "enabled",
                CodeSecurityConfigurationAdvancedSecurity.Disabled => "disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationAdvancedSecurity.Enabled,
                "disabled" => CodeSecurityConfigurationAdvancedSecurity.Disabled,
                _ => null,
            };
        }
    }
}