﻿//HintName: G.Models.WebhookInstallationSuspendAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookInstallationSuspendAction
    {
        /// <summary>
        /// 
        /// </summary>
        Suspend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookInstallationSuspendActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookInstallationSuspendAction value)
        {
            return value switch
            {
                WebhookInstallationSuspendAction.Suspend => "suspend",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookInstallationSuspendAction? ToEnum(string value)
        {
            return value switch
            {
                "suspend" => WebhookInstallationSuspendAction.Suspend,
                _ => null,
            };
        }
    }
}