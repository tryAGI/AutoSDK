//HintName: G.Models.WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType
    {
        /// <summary>
        /// 
        /// </summary>
        Bot,
        /// <summary>
        /// 
        /// </summary>
        User,
        /// <summary>
        /// 
        /// </summary>
        Organization,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestLabeledPullRequestAutoMergeEnabledByTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType value)
        {
            return value switch
            {
                WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.Bot => "Bot",
                WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.User => "User",
                WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.Organization => "Organization",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType? ToEnum(string value)
        {
            return value switch
            {
                "Bot" => WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.Bot,
                "User" => WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.User,
                "Organization" => WebhookPullRequestLabeledPullRequestAutoMergeEnabledByType.Organization,
                _ => null,
            };
        }
    }
}