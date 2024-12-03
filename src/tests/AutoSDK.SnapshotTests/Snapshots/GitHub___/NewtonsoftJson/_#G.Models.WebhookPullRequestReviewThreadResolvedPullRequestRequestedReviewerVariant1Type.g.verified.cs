//HintName: G.Models.WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestReviewThreadResolvedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}