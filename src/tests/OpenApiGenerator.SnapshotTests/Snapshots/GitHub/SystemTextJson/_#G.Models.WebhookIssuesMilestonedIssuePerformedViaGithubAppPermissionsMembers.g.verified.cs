//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers
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
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembersExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers.Read => "read",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers.Read,
                "write" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsMembers.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}