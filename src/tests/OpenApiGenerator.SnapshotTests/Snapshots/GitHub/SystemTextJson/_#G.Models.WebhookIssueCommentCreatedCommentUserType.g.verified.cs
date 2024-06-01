//HintName: G.Models.WebhookIssueCommentCreatedCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookIssueCommentCreatedCommentUserType
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
    public static class WebhookIssueCommentCreatedCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedCommentUserType value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedCommentUserType.Bot => "Bot",
                WebhookIssueCommentCreatedCommentUserType.User => "User",
                WebhookIssueCommentCreatedCommentUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedCommentUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookIssueCommentCreatedCommentUserType.Bot,
                "User" => WebhookIssueCommentCreatedCommentUserType.User,
                "Organization" => WebhookIssueCommentCreatedCommentUserType.Organization,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}