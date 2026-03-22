//HintName: G.Models.WebhookPullRequestUnlabeledPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlabeledPullRequestHeadUserType
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
    public static class WebhookPullRequestUnlabeledPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlabeledPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnlabeledPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestUnlabeledPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestUnlabeledPullRequestHeadUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlabeledPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlabeledPullRequestHeadUserType.Bot,
                "Organization" => WebhookPullRequestUnlabeledPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestUnlabeledPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}