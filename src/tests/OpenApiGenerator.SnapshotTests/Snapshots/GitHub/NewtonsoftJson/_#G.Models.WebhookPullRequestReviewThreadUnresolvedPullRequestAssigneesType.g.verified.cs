//HintName: G.Models.WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.Bot => "Bot",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.User => "User",
                WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.Bot,
                "User" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.User,
                "Organization" => WebhookPullRequestReviewThreadUnresolvedPullRequestAssigneesType.Organization,
                _ => null,
            };
        }
    }
}