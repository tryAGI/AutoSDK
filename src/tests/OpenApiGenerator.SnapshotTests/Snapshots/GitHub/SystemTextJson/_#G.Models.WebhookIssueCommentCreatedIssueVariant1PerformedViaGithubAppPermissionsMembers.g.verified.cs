//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers
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
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers.Read => "read",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers.Read,
                "write" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppPermissionsMembers.Write,
                _ => null,
            };
        }
    }
}