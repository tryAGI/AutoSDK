//HintName: G.Models.WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration
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
    public static class WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration value)
        {
            return value switch
            {
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration.Read => "read",
                WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration.Read,
                "write" => WebhookCheckSuiteRequestedCheckSuiteAppPermissionsOrganizationAdministration.Write,
                _ => null,
            };
        }
    }
}