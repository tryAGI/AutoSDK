//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAssigneeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType.Organization,
                _ => null,
            };
        }
    }
}