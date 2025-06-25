﻿//HintName: G.Models.CodeSecurityUpdateConfigurationRequestSecretScanning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of secret scanning
    /// </summary>
    public enum CodeSecurityUpdateConfigurationRequestSecretScanning
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
    public static class CodeSecurityUpdateConfigurationRequestSecretScanningExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityUpdateConfigurationRequestSecretScanning value)
        {
            return value switch
            {
                CodeSecurityUpdateConfigurationRequestSecretScanning.Enabled => "enabled",
                CodeSecurityUpdateConfigurationRequestSecretScanning.Disabled => "disabled",
                CodeSecurityUpdateConfigurationRequestSecretScanning.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityUpdateConfigurationRequestSecretScanning? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityUpdateConfigurationRequestSecretScanning.Enabled,
                "disabled" => CodeSecurityUpdateConfigurationRequestSecretScanning.Disabled,
                "not_set" => CodeSecurityUpdateConfigurationRequestSecretScanning.NotSet,
                _ => null,
            };
        }
    }
}