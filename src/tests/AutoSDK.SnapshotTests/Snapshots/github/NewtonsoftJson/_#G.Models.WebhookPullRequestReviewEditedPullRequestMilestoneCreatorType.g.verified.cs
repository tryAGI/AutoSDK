//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType
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
    public static class WebhookPullRequestReviewEditedPullRequestMilestoneCreatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Mannequin => "Mannequin",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Bot,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Mannequin,
                "Organization" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.Organization,
                "User" => WebhookPullRequestReviewEditedPullRequestMilestoneCreatorType.User,
                _ => null,
            };
        }
    }
}