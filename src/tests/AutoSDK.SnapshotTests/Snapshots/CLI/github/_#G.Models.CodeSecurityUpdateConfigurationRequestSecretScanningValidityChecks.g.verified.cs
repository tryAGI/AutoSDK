//HintName: G.Models.CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning validity checks
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}