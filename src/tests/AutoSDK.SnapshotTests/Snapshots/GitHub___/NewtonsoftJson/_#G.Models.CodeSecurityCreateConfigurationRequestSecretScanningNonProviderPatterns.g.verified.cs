//HintName: G.Models.CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning non provider patterns<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatternsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningNonProviderPatterns.NotSet,
                _ => null,
            };
        }
    }
}