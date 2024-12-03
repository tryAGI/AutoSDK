//HintName: G.Models.WebhookPullRequestAssignedPullRequestHeadUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestHeadUserType
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
    public static class WebhookPullRequestAssignedPullRequestHeadUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestHeadUserType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestHeadUserType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestHeadUserType.User => "User",
                WebhookPullRequestAssignedPullRequestHeadUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestHeadUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestHeadUserType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestHeadUserType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestHeadUserType.Organization,
                _ => null,
            };
        }
    }
}