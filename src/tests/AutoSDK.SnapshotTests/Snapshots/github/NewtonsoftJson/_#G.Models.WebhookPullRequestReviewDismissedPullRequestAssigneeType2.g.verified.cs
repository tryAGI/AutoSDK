//HintName: G.Models.WebhookPullRequestReviewDismissedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewDismissedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewDismissedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewDismissedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Mannequin => "Mannequin",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Organization => "Organization",
                WebhookPullRequestReviewDismissedPullRequestAssigneeType2.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewDismissedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Bot,
                "Mannequin" => WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Mannequin,
                "Organization" => WebhookPullRequestReviewDismissedPullRequestAssigneeType2.Organization,
                "User" => WebhookPullRequestReviewDismissedPullRequestAssigneeType2.User,
                _ => null,
            };
        }
    }
}