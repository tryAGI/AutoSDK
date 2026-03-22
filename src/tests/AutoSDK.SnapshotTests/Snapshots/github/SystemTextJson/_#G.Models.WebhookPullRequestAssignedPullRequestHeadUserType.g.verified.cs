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
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
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
                WebhookPullRequestAssignedPullRequestHeadUserType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestHeadUserType.User => "User",
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
                "Organization" => WebhookPullRequestAssignedPullRequestHeadUserType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestHeadUserType.User,
                _ => null,
            };
        }
    }
}