//HintName: G.Models.WebhookPullRequestLockedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLockedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestLockedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLockedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestLockedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLockedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestLockedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestLockedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}