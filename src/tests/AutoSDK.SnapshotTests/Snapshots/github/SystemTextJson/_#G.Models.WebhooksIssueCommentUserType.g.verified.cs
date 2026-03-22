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
        Mannequin,
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
                WebhooksIssueCommentUserType.Mannequin => "Mannequin",
                WebhooksIssueCommentUserType.Organization => "Organization",
                WebhooksIssueCommentUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueCommentUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksIssueCommentUserType.Bot,
                "Mannequin" => WebhooksIssueCommentUserType.Mannequin,
                "Organization" => WebhooksIssueCommentUserType.Organization,
                "User" => WebhooksIssueCommentUserType.User,
                _ => null,
            };
        }
    }
}