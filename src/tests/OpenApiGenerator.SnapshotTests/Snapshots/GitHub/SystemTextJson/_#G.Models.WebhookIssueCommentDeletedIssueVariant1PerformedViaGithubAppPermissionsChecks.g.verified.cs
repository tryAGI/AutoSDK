//HintName: G.Models.WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks
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
    public static class WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecksExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks.Read => "read",
                WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks.Read,
                "write" => WebhookIssueCommentDeletedIssueVariant1PerformedViaGithubAppPermissionsChecks.Write,
                _ => null,
            };
        }
    }
}