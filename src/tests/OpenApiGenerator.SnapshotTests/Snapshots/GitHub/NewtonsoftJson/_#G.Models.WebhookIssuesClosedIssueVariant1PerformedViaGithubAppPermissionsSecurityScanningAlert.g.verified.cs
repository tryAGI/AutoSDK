//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlertExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert.Read => "read",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert.Read,
                "write" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsSecurityScanningAlert.Write,
                _ => null,
            };
        }
    }
}