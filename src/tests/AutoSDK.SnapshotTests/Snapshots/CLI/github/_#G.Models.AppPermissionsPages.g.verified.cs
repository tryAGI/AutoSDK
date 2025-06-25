﻿//HintName: G.Models.AppPermissionsPages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to retrieve Pages statuses, configuration, and builds, as well as create new builds.
    /// </summary>
    public enum AppPermissionsPages
    {
        /// <summary>
        /// 
        /// </summary>
        Read,
        /// <summary>
        /// 
        /// </summary>
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPermissionsPagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsPages value)
        {
            return value switch
            {
                AppPermissionsPages.Read => "read",
                AppPermissionsPages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsPages? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsPages.Read,
                "write" => AppPermissionsPages.Write,
                _ => null,
            };
        }
    }
}