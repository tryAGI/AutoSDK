//HintName: G.Models.WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions
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
    public static class WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions.Read => "read",
                WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions.Read,
                "write" => WebhookIssueCommentEditedIssuePerformedViaGithubAppPermissionsDiscussions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}