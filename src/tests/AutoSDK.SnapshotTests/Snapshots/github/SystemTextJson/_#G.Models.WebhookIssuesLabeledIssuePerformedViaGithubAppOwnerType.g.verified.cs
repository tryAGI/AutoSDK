//HintName: G.Models.WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Organization => "Organization",
                WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.User => "User",
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
                "Organization" => WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.Organization,
                "User" => WebhookIssuesLabeledIssuePerformedViaGithubAppOwnerType.User,
                _ => null,
            };
        }
    }
}