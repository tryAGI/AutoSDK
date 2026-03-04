//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails
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
    public static class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmailsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails.Read => "read",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails.Read,
                "write" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsEmails.Write,
                _ => null,
            };
        }
    }
}