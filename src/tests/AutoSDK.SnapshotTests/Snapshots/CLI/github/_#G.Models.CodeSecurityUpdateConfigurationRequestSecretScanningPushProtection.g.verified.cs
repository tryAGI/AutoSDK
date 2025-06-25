//HintName: G.Models.CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning push protection
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanningPushProtection.NotSet,
                _ => null,
            };
        }
    }
}