//HintName: G.Models.WebhookPullRequestDequeuedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestDequeuedPullRequestAssigneeType
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
    public static class WebhookPullRequestDequeuedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestDequeuedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestDequeuedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestDequeuedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestDequeuedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestDequeuedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestDequeuedPullRequestAssigneeType.Bot,
                "Organization" => WebhookPullRequestDequeuedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestDequeuedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}