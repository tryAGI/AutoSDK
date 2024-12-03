//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Mannequin => "Mannequin",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Organization,
                "Mannequin" => WebhookPullRequestAutoMergeEnabledPullRequestRequestedReviewerVariant1Type.Mannequin,
                _ => null,
            };
        }
    }
}