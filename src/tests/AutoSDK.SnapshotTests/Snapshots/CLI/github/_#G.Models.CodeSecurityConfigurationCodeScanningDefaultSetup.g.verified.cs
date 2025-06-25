﻿//HintName: G.Models.CodeSecurityConfigurationCodeScanningDefaultSetup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The enablement status of code scanning default setup
    /// </summary>
    public enum CodeSecurityConfigurationCodeScanningDefaultSetup
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
    public static class CodeSecurityConfigurationCodeScanningDefaultSetupExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CodeSecurityConfigurationCodeScanningDefaultSetup value)
        {
            return value switch
            {
                CodeSecurityConfigurationCodeScanningDefaultSetup.Enabled => "enabled",
                CodeSecurityConfigurationCodeScanningDefaultSetup.Disabled => "disabled",
                CodeSecurityConfigurationCodeScanningDefaultSetup.NotSet => "not_set",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CodeSecurityConfigurationCodeScanningDefaultSetup? ToEnum(string value)
        {
            return value switch
            {
                "enabled" => CodeSecurityConfigurationCodeScanningDefaultSetup.Enabled,
                "disabled" => CodeSecurityConfigurationCodeScanningDefaultSetup.Disabled,
                "not_set" => CodeSecurityConfigurationCodeScanningDefaultSetup.NotSet,
                _ => null,
            };
        }
    }
}