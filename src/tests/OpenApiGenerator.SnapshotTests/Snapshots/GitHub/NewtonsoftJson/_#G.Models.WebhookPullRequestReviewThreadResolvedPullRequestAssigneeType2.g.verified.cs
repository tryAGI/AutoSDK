//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2 value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestAssigneeType2.Organization,
                _ => null,
            };
        }
    }
}