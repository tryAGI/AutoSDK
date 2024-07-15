//HintName: G.Models.WebhooksIssue2PerformedViaGithubAppOwnerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssue2PerformedViaGithubAppOwnerType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssue2PerformedViaGithubAppOwnerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssue2PerformedViaGithubAppOwnerType value)
        {
            return value switch
            {
                WebhooksIssue2PerformedViaGithubAppOwnerType.Bot => "Bot",
                WebhooksIssue2PerformedViaGithubAppOwnerType.User => "User",
                WebhooksIssue2PerformedViaGithubAppOwnerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssue2PerformedViaGithubAppOwnerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssue2PerformedViaGithubAppOwnerType.Bot,
                "User" => WebhooksIssue2PerformedViaGithubAppOwnerType.User,
                "Organization" => WebhooksIssue2PerformedViaGithubAppOwnerType.Organization,
                _ => null,
            };
        }
    }
}