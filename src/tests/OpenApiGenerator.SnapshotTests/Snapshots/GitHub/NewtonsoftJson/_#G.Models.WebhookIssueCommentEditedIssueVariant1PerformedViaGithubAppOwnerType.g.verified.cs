//HintName: G.Models.WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentEditedIssueVariant1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}