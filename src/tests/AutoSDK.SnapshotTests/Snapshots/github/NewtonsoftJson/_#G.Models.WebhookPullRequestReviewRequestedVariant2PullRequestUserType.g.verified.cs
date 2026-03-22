//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestUserType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Mannequin => "Mannequin",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Bot,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Mannequin,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.Organization,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestUserType.User,
                _ => null,
            };
        }
    }
}