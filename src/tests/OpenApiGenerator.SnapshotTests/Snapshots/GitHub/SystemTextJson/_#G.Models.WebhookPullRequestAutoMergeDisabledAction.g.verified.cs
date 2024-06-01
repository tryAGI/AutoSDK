//HintName: G.Models.WebhookPullRequestAutoMergeDisabledAction.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledAction
    {
        /// <summary>
        /// 
        /// </summary>
        AutoMergeDisabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledActionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledAction value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledAction.AutoMergeDisabled => "auto_merge_disabled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledAction ToEnum(string value)
        {
            return value switch
            {
                "auto_merge_disabled" => WebhookPullRequestAutoMergeDisabledAction.AutoMergeDisabled,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}