//HintName: G.Models.WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestLabeledPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}