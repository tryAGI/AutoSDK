//HintName: G.Models.WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestLabeledPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.User => "User",
                WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestRequestedReviewerUserType.Mannequin,
                _ => null,
            };
        }
    }
}