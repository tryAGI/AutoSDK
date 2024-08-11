//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions
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
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions.Read => "read",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions.Read,
                "write" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsActions.Write,
                _ => null,
            };
        }
    }
}