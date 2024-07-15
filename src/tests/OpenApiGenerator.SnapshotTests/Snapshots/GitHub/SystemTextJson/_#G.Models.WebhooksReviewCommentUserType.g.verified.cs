//HintName: G.Models.WebhooksReviewCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksReviewCommentUserType
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
    public static class WebhooksReviewCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksReviewCommentUserType value)
        {
            return value switch
            {
                WebhooksReviewCommentUserType.Bot => "Bot",
                WebhooksReviewCommentUserType.User => "User",
                WebhooksReviewCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksReviewCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksReviewCommentUserType.Bot,
                "User" => WebhooksReviewCommentUserType.User,
                "Organization" => WebhooksReviewCommentUserType.Organization,
                _ => null,
            };
        }
    }
}