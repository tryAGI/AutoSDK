//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType
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
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewRequestedVariant1PullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}