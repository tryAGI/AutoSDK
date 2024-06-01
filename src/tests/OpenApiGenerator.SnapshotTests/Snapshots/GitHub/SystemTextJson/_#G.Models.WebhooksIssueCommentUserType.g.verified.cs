//HintName: G.Models.WebhooksIssueCommentUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhooksIssueCommentUserType
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
        /// <summary>
        /// 
        /// </summary>
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksIssueCommentUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueCommentUserType value)
        {
            return value switch
            {
                WebhooksIssueCommentUserType.Bot => "Bot",
                WebhooksIssueCommentUserType.User => "User",
                WebhooksIssueCommentUserType.Organization => "Organization",
                WebhooksIssueCommentUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueCommentUserType ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueCommentUserType.Bot,
                "User" => WebhooksIssueCommentUserType.User,
                "Organization" => WebhooksIssueCommentUserType.Organization,
                "Mannequin" => WebhooksIssueCommentUserType.Mannequin,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}