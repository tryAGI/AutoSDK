//HintName: G.Models.WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssuesUnlockedIssuePerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}