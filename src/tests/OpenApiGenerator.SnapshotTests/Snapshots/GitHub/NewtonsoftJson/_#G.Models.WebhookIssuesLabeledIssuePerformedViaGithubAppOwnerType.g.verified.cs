//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.User => "User",
                WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Bot,
                "User" => WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.User,
                "Organization" => WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}