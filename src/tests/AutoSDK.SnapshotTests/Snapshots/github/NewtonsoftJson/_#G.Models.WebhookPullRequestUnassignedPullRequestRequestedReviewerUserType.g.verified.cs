//HintName: G.Models.WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType
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
    public static class WebhookPullRequestUnassignedPullRequestRequestedReviewerUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType value)
        {
            return value switch
            {
                WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Bot => "Bot",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Mannequin => "Mannequin",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Organization => "Organization",
                WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Bot,
                "Mannequin" => WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Mannequin,
                "Organization" => WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.Organization,
                "User" => WebhookPullRequestUnassignedPullRequestRequestedReviewerUserType.User,
                _ => null,
            };
        }
    }
}