//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType
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
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant2PullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}