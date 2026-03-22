//HintName: G.Models.WebhookPullRequestUnlockedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnlockedPullRequestAssigneeType
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
    public static class WebhookPullRequestUnlockedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestUnlockedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestAssigneeType.Bot,
                "Organization" => WebhookPullRequestUnlockedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestUnlockedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}