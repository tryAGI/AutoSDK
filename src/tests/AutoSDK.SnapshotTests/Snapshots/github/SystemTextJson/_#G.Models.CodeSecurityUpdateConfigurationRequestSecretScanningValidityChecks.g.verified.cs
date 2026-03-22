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
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Enabled,
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
                CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Enabled => "enabled",
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
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Disabled,
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.Enabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningValidityChecks.NotSet,
                _ => null,
            };
        }
    }
}