//HintName: G.Models.CodeSecurityConfigurationAdvancedSecurity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of GitHub Advanced Security
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationAdvancedSecurity
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
                CodeSecurityConfigurationAdvancedSecurity.Disabled => "disabled",
                CodeSecurityConfigurationAdvancedSecurity.Enabled => "enabled",
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
                "disabled" => CodeSecurityConfigurationAdvancedSecurity.Disabled,
                "enabled" => CodeSecurityConfigurationAdvancedSecurity.Enabled,
                _ => null,
            };
        }
    }
}