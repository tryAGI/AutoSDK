//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlertExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert.Read => "read",
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert.Read,
                "write" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsSecurityScanningAlert.Write,
                _ => null,
            };
        }
    }
}