//HintName: G.Models.WebhooksReviewUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReviewUserType
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
    public static class WebhooksReviewUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewUserType value)
        {
            return value switch
            {
                WebhooksReviewUserType.Bot => "Bot",
                WebhooksReviewUserType.Organization => "Organization",
                WebhooksReviewUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewUserType.Bot,
                "Organization" => WebhooksReviewUserType.Organization,
                "User" => WebhooksReviewUserType.User,
                _ => null,
            };
        }
    }
}