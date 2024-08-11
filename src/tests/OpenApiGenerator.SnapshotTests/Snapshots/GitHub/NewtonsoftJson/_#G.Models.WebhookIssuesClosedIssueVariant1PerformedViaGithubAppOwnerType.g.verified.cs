//HintName: G.Models.WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesClosedIssueVariant1PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}