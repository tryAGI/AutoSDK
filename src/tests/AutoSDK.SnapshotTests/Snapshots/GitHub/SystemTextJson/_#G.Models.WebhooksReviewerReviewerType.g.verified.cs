//HintName: G.Models.WebhooksReviewerReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReviewerReviewerType
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
    public static class WebhooksReviewerReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewerReviewerType value)
        {
            return value switch
            {
                WebhooksReviewerReviewerType.Bot => "Bot",
                WebhooksReviewerReviewerType.User => "User",
                WebhooksReviewerReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewerReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewerReviewerType.Bot,
                "User" => WebhooksReviewerReviewerType.User,
                "Organization" => WebhooksReviewerReviewerType.Organization,
                _ => null,
            };
        }
    }
}