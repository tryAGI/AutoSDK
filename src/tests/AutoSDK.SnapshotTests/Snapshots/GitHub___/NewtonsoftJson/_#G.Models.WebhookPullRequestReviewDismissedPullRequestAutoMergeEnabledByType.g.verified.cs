//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType
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
    public static class WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}