﻿//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecretsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecrets.Write,
                _ => null,
            };
        }
    }
}