//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType
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
    public static class WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssueCommentCreatedIssueVariant1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}