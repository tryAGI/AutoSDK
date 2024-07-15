//HintName: G.Models.WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType
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
    public static class WebhookPullRequestReviewCommentCreatedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Organization => "Organization",
                WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Organization,
                "Mannequin" => WebhookPullRequestReviewCommentCreatedPullRequestAssigneesType.Mannequin,
                _ => null,
            };
        }
    }
}