//HintName: G.Models.WebhooksReviewersReviewerType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReviewersReviewerType
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
    public static class WebhooksReviewersReviewerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewersReviewerType value)
        {
            return value switch
            {
                WebhooksReviewersReviewerType.Bot => "Bot",
                WebhooksReviewersReviewerType.User => "User",
                WebhooksReviewersReviewerType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewersReviewerType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewersReviewerType.Bot,
                "User" => WebhooksReviewersReviewerType.User,
                "Organization" => WebhooksReviewersReviewerType.Organization,
                _ => null,
            };
        }
    }
}