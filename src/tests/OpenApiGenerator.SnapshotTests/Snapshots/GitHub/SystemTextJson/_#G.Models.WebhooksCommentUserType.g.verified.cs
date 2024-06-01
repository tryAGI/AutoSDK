//HintName: G.Models.WebhooksCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksCommentUserType
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
    public static class WebhooksCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksCommentUserType value)
        {
            return value switch
            {
                WebhooksCommentUserType.Bot => "Bot",
                WebhooksCommentUserType.User => "User",
                WebhooksCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksCommentUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksCommentUserType.Bot,
                "User" => WebhooksCommentUserType.User,
                "Organization" => WebhooksCommentUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}