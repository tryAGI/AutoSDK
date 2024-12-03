//HintName: G.Models.CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning push protection<br/>
    /// Default Value: disabled
    /// </summary>
    public enum CodeSecurityCreateConfigurationRequestSecretScanningPushProtection
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
    public static class CodeSecurityCreateConfigurationRequestSecretScanningPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityCreateConfigurationRequestSecretScanningPushProtection value)
        {
            return value switch
            {
                CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Enabled => "enabled",
                CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled => "disabled",
                CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityCreateConfigurationRequestSecretScanningPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Enabled,
                "disabled" => CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.Disabled,
                "not_set" => CodeSecurityCreateConfigurationRequestSecretScanningPushProtection.NotSet,
                _ => null,
            };
        }
    }
}