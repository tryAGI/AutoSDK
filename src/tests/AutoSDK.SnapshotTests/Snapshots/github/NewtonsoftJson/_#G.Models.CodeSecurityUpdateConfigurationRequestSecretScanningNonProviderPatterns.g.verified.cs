//HintName: G.Models.CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning non-provider patterns
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}