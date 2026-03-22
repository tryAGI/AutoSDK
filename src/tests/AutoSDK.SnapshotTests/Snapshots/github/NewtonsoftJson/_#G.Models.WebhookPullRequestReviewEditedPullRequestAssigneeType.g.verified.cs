//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewEditedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestAssigneeType.Mannequin => "Mannequin",
                WebhookPullRequestReviewEditedPullRequestAssigneeType.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestAssigneeType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestAssigneeType.Bot,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestAssigneeType.Mannequin,
                "Organization" => WebhookPullRequestReviewEditedPullRequestAssigneeType.Organization,
                "User" => WebhookPullRequestReviewEditedPullRequestAssigneeType.User,
                _ => null,
            };
        }
    }
}