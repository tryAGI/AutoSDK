﻿//HintName: G.Models.AppPermissionsOrganizationHooks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The level of permission to grant the access token to manage the post-receive hooks for an organization.
    /// </summary>
    public enum AppPermissionsOrganizationHooks
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
    public static class AppPermissionsOrganizationHooksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPermissionsOrganizationHooks value)
        {
            return value switch
            {
                AppPermissionsOrganizationHooks.Read => "read",
                AppPermissionsOrganizationHooks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPermissionsOrganizationHooks? ToEnum(string value)
        {
            return value switch
            {
                "read" => AppPermissionsOrganizationHooks.Read,
                "write" => AppPermissionsOrganizationHooks.Write,
                _ => null,
            };
        }
    }
}