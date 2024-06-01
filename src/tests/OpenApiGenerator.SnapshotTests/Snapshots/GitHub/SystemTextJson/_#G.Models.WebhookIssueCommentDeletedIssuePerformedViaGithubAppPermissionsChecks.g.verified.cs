//HintName: G.Models.WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsChecks.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}