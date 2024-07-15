//HintName: G.Models.WebhookPullRequestLabeledPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestBaseUserType
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
    public static class WebhookPullRequestLabeledPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestBaseUserType.User => "User",
                WebhookPullRequestLabeledPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}