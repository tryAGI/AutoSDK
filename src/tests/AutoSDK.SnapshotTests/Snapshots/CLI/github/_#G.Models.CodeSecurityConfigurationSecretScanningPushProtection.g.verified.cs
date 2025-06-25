﻿//HintName: G.Models.CodeSecurityConfigurationSecretScanningPushProtection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning push protection
    /// </summary>
    public enum CodeSecurityConfigurationSecretScanningPushProtection
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
    public static class CodeSecurityConfigurationSecretScanningPushProtectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationSecretScanningPushProtection value)
        {
            return value switch
            {
                CodeSecurityConfigurationSecretScanningPushProtection.Enabled => "enabled",
                CodeSecurityConfigurationSecretScanningPushProtection.Disabled => "disabled",
                CodeSecurityConfigurationSecretScanningPushProtection.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationSecretScanningPushProtection? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationSecretScanningPushProtection.Enabled,
                "disabled" => CodeSecurityConfigurationSecretScanningPushProtection.Disabled,
                "not_set" => CodeSecurityConfigurationSecretScanningPushProtection.NotSet,
                _ => null,
            };
        }
    }
}