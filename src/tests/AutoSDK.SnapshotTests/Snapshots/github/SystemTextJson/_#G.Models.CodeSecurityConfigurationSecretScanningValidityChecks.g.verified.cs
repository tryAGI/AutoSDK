//HintName: G.Models.CodeSecurityConfigurationSecretScanningValidityChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning validity checks
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningValidityChecks
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
    public static class CodeSecurityConfigurationSecretScanningValidityChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningValidityChecks value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningValidityChecks.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningValidityChecks.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningValidityChecks? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanningValidityChecks.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanningValidityChecks.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}