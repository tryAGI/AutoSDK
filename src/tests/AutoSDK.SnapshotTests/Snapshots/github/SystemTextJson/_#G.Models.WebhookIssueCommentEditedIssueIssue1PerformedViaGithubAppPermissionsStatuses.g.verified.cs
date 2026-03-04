//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses
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
    public static class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatusesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses.Read => "read",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses.Read,
                "write" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppPermissionsStatuses.Write,
                _ => null,
            };
        }
    }
}