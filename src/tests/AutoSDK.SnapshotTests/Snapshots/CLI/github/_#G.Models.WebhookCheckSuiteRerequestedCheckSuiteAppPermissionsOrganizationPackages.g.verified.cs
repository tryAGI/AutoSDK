﻿//HintName: G.Models.WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages
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
    public static class WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackagesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages value)
        {
            return value switch
            {
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages.Read => "read",
                WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages.Read,
                "write" => WebhookCheckSuiteRerequestedCheckSuiteAppPermissionsOrganizationPackages.Write,
                _ => null,
            };
        }
    }
}