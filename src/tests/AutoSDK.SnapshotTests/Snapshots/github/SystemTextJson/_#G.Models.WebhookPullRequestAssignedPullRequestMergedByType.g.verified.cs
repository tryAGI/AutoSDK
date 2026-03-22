//HintName: G.Models.WebhookPullRequestAssignedPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestMergedByType
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
    public static class WebhookPullRequestAssignedPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestAssignedPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestMergedByType.Bot,
                "Organization" => WebhookPullRequestAssignedPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestAssignedPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}