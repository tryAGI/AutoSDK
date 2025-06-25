﻿//HintName: G.Models.SecretScanningAlertValidity.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The token status as of the latest validity check.
    /// </summary>
    public enum SecretScanningAlertValidity
    {
        /// <summary>
        /// 
        /// </summary>
        Active,
        /// <summary>
        /// 
        /// </summary>
        Inactive,
        /// <summary>
        /// 
        /// </summary>
        Unknown,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningAlertValidityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningAlertValidity value)
        {
            return value switch
            {
                SecretScanningAlertValidity.Active => "active",
                SecretScanningAlertValidity.Inactive => "inactive",
                SecretScanningAlertValidity.Unknown => "unknown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningAlertValidity? ToEnum(string value)
        {
            return value switch
            {
                "active" => SecretScanningAlertValidity.Active,
                "inactive" => SecretScanningAlertValidity.Inactive,
                "unknown" => SecretScanningAlertValidity.Unknown,
                _ => null,
            };
        }
    }
}