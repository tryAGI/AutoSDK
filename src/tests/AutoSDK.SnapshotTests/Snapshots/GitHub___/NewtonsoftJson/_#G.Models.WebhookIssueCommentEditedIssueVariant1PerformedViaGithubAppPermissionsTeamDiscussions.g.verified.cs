//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussionsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions.Read => "read",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions.Write => "write",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions? ToEnum(string value)
        {
            return value switch
            {
                "read" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions.Read,
                "write" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppPermissionsTeamDiscussions.Write,
                _ => null,
            };
        }
    }
}