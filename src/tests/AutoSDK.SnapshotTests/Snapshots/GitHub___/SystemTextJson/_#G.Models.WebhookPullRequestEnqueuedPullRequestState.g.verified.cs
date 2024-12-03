//HintName: G.Models.WebhookPullRequestEnqueuedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhookPullRequestEnqueuedPullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestEnqueuedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestEnqueuedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestEnqueuedPullRequestState.Open => "open",
                WebhookPullRequestEnqueuedPullRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestEnqueuedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestEnqueuedPullRequestState.Open,
                "closed" => WebhookPullRequestEnqueuedPullRequestState.Closed,
                _ => null,
            };
        }
    }
}