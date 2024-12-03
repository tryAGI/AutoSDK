//HintName: G.Models.WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert
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
    public static class WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlertExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert value)
        {
            return value switch
            {
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert.Read => "read",
                WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert.Read,
                "write" => WebhookCheckSuiteCompletedCheckSuiteAppPermissionsSecurityScanningAlert.Write,
                _ => null,
            };
        }
    }
}