//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAssigneeType2
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
    public static class WebhookPullRequestEnqueuedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestEnqueuedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}