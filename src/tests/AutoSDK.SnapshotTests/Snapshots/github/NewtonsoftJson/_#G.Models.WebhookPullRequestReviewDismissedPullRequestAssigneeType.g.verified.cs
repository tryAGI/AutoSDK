//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewDismissedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}