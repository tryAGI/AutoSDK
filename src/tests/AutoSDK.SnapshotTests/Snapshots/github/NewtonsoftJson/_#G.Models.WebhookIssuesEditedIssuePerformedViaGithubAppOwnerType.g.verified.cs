//HintName: G.Models.WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType
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
    public static class WebhookIssuesEditedIssuePerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.Bot,
                "Organization" => WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssuesEditedIssuePerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}