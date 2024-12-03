//HintName: G.Models.WebhookPullRequestAutoMergeEnabledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeEnabledAction
    {
        /// <summary>
        /// 
        /// </summary>
        AutoMergeEnabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeEnabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledAction value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledAction.AutoMergeEnabled => "auto_merge_enabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledAction? ToEnum(string value)
        {
            return value switch
            {
                "auto_merge_enabled" => WebhookPullRequestAutoMergeEnabledAction.AutoMergeEnabled,
                _ => null,
            };
        }
    }
}