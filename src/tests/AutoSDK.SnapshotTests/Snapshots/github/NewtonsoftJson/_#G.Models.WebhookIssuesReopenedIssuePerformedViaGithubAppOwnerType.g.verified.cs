//HintName: G.Models.WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssuesReopenedIssuePerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}