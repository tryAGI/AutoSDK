//HintName: G.Models.WebhookCommitCommentCreatedCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookCommitCommentCreatedCommentUserType
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
    public static class WebhookCommitCommentCreatedCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookCommitCommentCreatedCommentUserType value)
        {
            return value switch
            {
                WebhookCommitCommentCreatedCommentUserType.Bot => "Bot",
                WebhookCommitCommentCreatedCommentUserType.User => "User",
                WebhookCommitCommentCreatedCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookCommitCommentCreatedCommentUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookCommitCommentCreatedCommentUserType.Bot,
                "User" => WebhookCommitCommentCreatedCommentUserType.User,
                "Organization" => WebhookCommitCommentCreatedCommentUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}