//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAssigneeType
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
    public static class WebhookPullRequestEnqueuedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestAssigneeType.Bot,
                "Organization" => WebhookPullRequestEnqueuedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestEnqueuedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}