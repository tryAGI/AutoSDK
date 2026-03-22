//HintName: G.Models.CodeSecurityConfigurationSecretScanningNonProviderPatterns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning non-provider patterns
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityConfigurationSecretScanningNonProviderPatterns
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
    public static class CodeSecurityConfigurationSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => CodeSecurityConfigurationSecretScanningNonProviderPatterns.Disabled,
                "enabled" => CodeSecurityConfigurationSecretScanningNonProviderPatterns.Enabled,
                "not_set" => CodeSecurityConfigurationSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}