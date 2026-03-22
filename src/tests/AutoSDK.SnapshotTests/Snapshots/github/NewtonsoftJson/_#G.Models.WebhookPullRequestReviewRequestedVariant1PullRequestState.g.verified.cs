//HintName: G.Models.WebhookPullRequestReviewRequestedVariant1PullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestReviewRequestedVariant1PullRequestState
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookPullRequestReviewRequestedVariant1PullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestReviewRequestedVariant1PullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestReviewRequestedVariant1PullRequestState.Closed => "closed",
                WebhookPullRequestReviewRequestedVariant1PullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestReviewRequestedVariant1PullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestReviewRequestedVariant1PullRequestState.Closed,
                "open" => WebhookPullRequestReviewRequestedVariant1PullRequestState.Open,
                _ => null,
            };
        }
    }
}