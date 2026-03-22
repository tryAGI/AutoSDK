//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestAutoMergeDisabledPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}