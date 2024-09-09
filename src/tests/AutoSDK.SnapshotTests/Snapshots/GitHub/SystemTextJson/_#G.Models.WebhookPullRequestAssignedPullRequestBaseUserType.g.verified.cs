//HintName: G.Models.WebhookPullRequestAssignedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestBaseUserType
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
    public static class WebhookPullRequestAssignedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestAssignedPullRequestBaseUserType.User => "User",
                WebhookPullRequestAssignedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAssignedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestAssignedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestAssignedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}