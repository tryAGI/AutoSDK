//HintName: G.Models.WebhookPullRequestUnassignedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestUnassignedPullRequestBaseUserType
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
    public static class WebhookPullRequestUnassignedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestBaseUserType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestBaseUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestBaseUserType.Bot,
                "Organization" => WebhookPullRequestUnassignedPullRequestBaseUserType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestBaseUserType.User,
                _ => null,
            };
        }
    }
}