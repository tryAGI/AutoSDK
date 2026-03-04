//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}