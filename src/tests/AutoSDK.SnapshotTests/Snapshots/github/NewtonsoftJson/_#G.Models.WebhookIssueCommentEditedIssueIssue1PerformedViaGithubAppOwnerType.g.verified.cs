//HintName: G.Models.WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentEditedIssueIssue1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}