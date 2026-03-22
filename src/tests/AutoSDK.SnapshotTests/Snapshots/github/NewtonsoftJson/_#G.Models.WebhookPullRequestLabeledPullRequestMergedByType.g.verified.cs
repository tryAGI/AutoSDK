//HintName: G.Models.WebhookPullRequestLabeledPullRequestMergedByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestLabeledPullRequestMergedByType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Bot")]
        Bot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Mannequin")]
        Mannequin,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Organization")]
        Organization,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="User")]
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestMergedByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestMergedByType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestMergedByType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestMergedByType.Mannequin => "Mannequin",
                WebhookPullRequestLabeledPullRequestMergedByType.Organization => "Organization",
                WebhookPullRequestLabeledPullRequestMergedByType.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestMergedByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestMergedByType.Bot,
                "Mannequin" => WebhookPullRequestLabeledPullRequestMergedByType.Mannequin,
                "Organization" => WebhookPullRequestLabeledPullRequestMergedByType.Organization,
                "User" => WebhookPullRequestLabeledPullRequestMergedByType.User,
                _ => null,
            };
        }
    }
}