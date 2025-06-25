﻿//HintName: G.Models.SecretScanningListAlertsForOrgDirection.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: desc
    /// </summary>
    public enum SecretScanningListAlertsForOrgDirection
    {
        /// <summary>
        /// 
        /// </summary>
        Asc,
        /// <summary>
        /// 
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretScanningListAlertsForOrgDirectionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretScanningListAlertsForOrgDirection value)
        {
            return value switch
            {
                SecretScanningListAlertsForOrgDirection.Asc => "asc",
                SecretScanningListAlertsForOrgDirection.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretScanningListAlertsForOrgDirection? ToEnum(string value)
        {
            return value switch
            {
                "asc" => SecretScanningListAlertsForOrgDirection.Asc,
                "desc" => SecretScanningListAlertsForOrgDirection.Desc,
                _ => null,
            };
        }
    }
}