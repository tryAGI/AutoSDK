//HintName: G.Models.CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning validity checks<br/>
    /// Default Value: disabled
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningValidityChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}