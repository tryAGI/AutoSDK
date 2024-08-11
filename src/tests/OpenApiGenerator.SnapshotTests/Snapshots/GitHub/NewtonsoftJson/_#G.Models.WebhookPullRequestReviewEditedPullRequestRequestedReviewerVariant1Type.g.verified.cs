//HintName: G.Models.WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestReviewEditedPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}