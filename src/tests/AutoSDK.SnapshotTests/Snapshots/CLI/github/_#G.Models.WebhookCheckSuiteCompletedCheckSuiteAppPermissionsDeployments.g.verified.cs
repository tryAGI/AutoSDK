﻿//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeploymentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsDeployments.Write,
                _ => null,
            };
        }
    }
}