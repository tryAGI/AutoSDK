//HintName: G.Models.WebhookPullRequestAutoMergeEnabledPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookPullRequestAutoMergeEnabledPullRequestState
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
    public static class WebhookPullRequestAutoMergeEnabledPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAutoMergeEnabledPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestAutoMergeEnabledPullRequestState.Closed => "closed",
                WebhookPullRequestAutoMergeEnabledPullRequestState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAutoMergeEnabledPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookPullRequestAutoMergeEnabledPullRequestState.Closed,
                "open" => WebhookPullRequestAutoMergeEnabledPullRequestState.Open,
                _ => null,
            };
        }
    }
}