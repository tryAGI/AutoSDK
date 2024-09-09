//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestMilestoneCreatorType.Mannequin,
                _ => null,
            };
        }
    }
}