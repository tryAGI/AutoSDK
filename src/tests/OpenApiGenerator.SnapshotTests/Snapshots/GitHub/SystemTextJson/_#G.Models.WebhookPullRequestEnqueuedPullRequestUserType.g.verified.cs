//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestUserType.User => "User",
                WebhookPullRequestEnqueuedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestEnqueuedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestUserType.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestUserType.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestEnqueuedPullRequestUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}