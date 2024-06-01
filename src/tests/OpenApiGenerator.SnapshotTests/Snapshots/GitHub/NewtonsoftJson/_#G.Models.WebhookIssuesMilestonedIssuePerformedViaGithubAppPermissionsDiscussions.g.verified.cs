//HintName: G.Models.WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="read")]
        Read,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="write")]
        Write,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions value)
        {
            return value switch
            {
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions.Read => "read",
                WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions.Read,
                "write" => WebhookIssuesMilestonedIssuePerformedViaGithubAppPermissionsDiscussions.Write,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}