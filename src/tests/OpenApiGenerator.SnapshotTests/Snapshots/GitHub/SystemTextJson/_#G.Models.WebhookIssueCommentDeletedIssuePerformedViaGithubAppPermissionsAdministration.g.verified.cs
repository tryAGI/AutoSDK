//HintName: G.Models.WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration
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
    public static class WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministrationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration value)
        {
            return value switch
            {
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration.Read => "read",
                WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration.Read,
                "write" => WebhookIssueCommentDeletedIssuePerformedViaGithubAppPermissionsAdministration.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}