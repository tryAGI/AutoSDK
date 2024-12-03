//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestBaseUserType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestBaseUserType
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
    public static class WebhookPullRequestReviewEditedPullRequestBaseUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestBaseUserType value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestBaseUserType.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestBaseUserType.User => "User",
                WebhookPullRequestReviewEditedPullRequestBaseUserType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestBaseUserType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestBaseUserType.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestBaseUserType.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestBaseUserType.Organization,
                _ => null,
            };
        }
    }
}