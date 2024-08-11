//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlertsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts.Read => "read",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts.Read,
                "write" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsSecretScanningAlerts.Write,
                _ => null,
            };
        }
    }
}