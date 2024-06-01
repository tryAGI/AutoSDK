//HintName: G.Models.WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts value)
        {
            return value switch
            {
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.Read => "read",
                WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.Read,
                "write" => WebhookIssuesClosedIssuePerformedViaGithubAppPermissionsSecretScanningAlerts.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}