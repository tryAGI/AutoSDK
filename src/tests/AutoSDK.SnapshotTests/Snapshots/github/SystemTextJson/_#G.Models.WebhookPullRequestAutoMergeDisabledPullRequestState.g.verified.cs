//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhookPullRequestAutoMergeDisabledPullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestAutoMergeDisabledPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeDisabledPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeDisabledPullRequestState.Closed => "closed",
                WebhookPullRequestAutoMergeDisabledPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeDisabledPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestAutoMergeDisabledPullRequestState.Closed,
                "open" => WebhookPullRequestAutoMergeDisabledPullRequestState.Open,
                _ => null,
            };
        }
    }
}