//HintName: G.Models.WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestUnlockedPullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}