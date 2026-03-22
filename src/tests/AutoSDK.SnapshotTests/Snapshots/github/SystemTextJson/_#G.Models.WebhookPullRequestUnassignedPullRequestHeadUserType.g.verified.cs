//HintName: G.Models.WebhookPullRequestUnassignedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestHeadUserType
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
    public static class WebhookPullRequestUnassignedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestUnassignedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}