//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadResolvedPullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestUserType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestUserType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestUserType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestUserType.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedPullRequestUserType.Mannequin,
                _ => null,
            };
        }
    }
}