//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestAssigneesType
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
    public static class WebhookPullRequestEnqueuedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestAssigneesType.User => "User",
                WebhookPullRequestEnqueuedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestAssigneesType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestAssigneesType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}