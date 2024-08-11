//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type
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
    public static class WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.Bot => "Bot",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.User => "User",
                WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.Bot,
                "User" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.User,
                "Organization" => WebhookPullRequestEnqueuedPullRequestRequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}