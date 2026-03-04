//HintName: G.Models.WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys
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
    public static class WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeysExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys.Read => "read",
                WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys.Read,
                "write" => WebhookIssueCommentCreatedIssueIssue1PerformedViaGithubAppPermissionsKeys.Write,
                _ => null,
            };
        }
    }
}