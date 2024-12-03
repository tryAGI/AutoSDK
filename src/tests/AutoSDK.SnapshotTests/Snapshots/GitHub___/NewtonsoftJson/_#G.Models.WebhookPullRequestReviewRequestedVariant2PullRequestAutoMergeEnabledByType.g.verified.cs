//HintName: G.Models.WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant2PullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}