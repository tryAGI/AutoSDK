//HintName: G.Models.WebhookPullRequestReviewSubmittedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewSubmittedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewSubmittedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewSubmittedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewSubmittedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Organization,
                "Mannequin" => WebhookPullRequestReviewSubmittedPullRequestAssigneeType.Mannequin,
                _ => null,
            };
        }
    }
}