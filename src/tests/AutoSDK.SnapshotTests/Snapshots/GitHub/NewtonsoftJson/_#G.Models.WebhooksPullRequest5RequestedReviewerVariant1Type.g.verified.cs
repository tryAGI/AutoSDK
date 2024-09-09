//HintName: G.Models.WebhooksPullRequest5RequestedReviewerVariant1Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5RequestedReviewerVariant1Type
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
    public static class WebhooksPullRequest5RequestedReviewerVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5RequestedReviewerVariant1Type value)
        {
            return value switch
            {
                WebhooksPullRequest5RequestedReviewerVariant1Type.Bot => "Bot",
                WebhooksPullRequest5RequestedReviewerVariant1Type.User => "User",
                WebhooksPullRequest5RequestedReviewerVariant1Type.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5RequestedReviewerVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhooksPullRequest5RequestedReviewerVariant1Type.Bot,
                "User" => WebhooksPullRequest5RequestedReviewerVariant1Type.User,
                "Organization" => WebhooksPullRequest5RequestedReviewerVariant1Type.Organization,
                _ => null,
            };
        }
    }
}