//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.Read => "read",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.Read,
                "write" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppPermissionsDiscussions.Write,
                _ => null,
            };
        }
    }
}