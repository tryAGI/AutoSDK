//HintName: G.Models.WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers
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
    public static class WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers value)
        {
            return value switch
            {
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers.Read => "read",
                WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers.Read,
                "write" => WebhookIssuesOpenedIssuePerformedViaGithubAppPermissionsMembers.Write,
                _ => null,
            };
        }
    }
}