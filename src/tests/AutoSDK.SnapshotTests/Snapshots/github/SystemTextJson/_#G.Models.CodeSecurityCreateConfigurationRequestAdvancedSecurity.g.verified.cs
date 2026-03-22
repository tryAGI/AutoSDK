//HintName: G.Models.CodeSecurityCreateConfigurationRequestAdvancedSecurity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestAdvancedSecurity
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
    public static class CodeSecurityCreateConfigurationRequestAdvancedSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestAdvancedSecurity value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestAdvancedSecurity.Enabled => "enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestAdvancedSecurity? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityCreateConfigurationRequestAdvancedSecurity.Enabled,
                _ => null,
            };
        }
    }
}