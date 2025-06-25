﻿//HintName: G.Models.WebhookMemberAddedChangesPermissionTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookMemberAddedChangesPermissionTo
    {
        /// <summary>
        /// 
        /// </summary>
        Write,
        /// <summary>
        /// 
        /// </summary>
        Admin,
        /// <summary>
        /// 
        /// </summary>
        Read,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookMemberAddedChangesPermissionToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookMemberAddedChangesPermissionTo value)
        {
            return value switch
            {
                WebhookMemberAddedChangesPermissionTo.Write => "write",
                WebhookMemberAddedChangesPermissionTo.Admin => "admin",
                WebhookMemberAddedChangesPermissionTo.Read => "read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookMemberAddedChangesPermissionTo? ToEnum(string value)
        {
            return value switch
            {
                "write" => WebhookMemberAddedChangesPermissionTo.Write,
                "admin" => WebhookMemberAddedChangesPermissionTo.Admin,
                "read" => WebhookMemberAddedChangesPermissionTo.Read,
                _ => null,
            };
        }
    }
}