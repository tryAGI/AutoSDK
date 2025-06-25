﻿//HintName: G.Models.WebhookPullRequestAutoMergeDisabledPullRequestState.g.cs

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
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
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
                WebhookPullRequestAutoMergeDisabledPullRequestState.Open => "open",
                WebhookPullRequestAutoMergeDisabledPullRequestState.Closed => "closed",
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
                "open" => WebhookPullRequestAutoMergeDisabledPullRequestState.Open,
                "closed" => WebhookPullRequestAutoMergeDisabledPullRequestState.Closed,
                _ => null,
            };
        }
    }
}