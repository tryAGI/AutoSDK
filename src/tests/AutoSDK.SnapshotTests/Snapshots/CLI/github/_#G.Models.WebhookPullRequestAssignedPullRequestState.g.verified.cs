﻿//HintName: G.Models.WebhookPullRequestAssignedPullRequestState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhookPullRequestAssignedPullRequestState
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
    public static class WebhookPullRequestAssignedPullRequestStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookPullRequestAssignedPullRequestState value)
        {
            return value switch
            {
                WebhookPullRequestAssignedPullRequestState.Open => "open",
                WebhookPullRequestAssignedPullRequestState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookPullRequestAssignedPullRequestState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookPullRequestAssignedPullRequestState.Open,
                "closed" => WebhookPullRequestAssignedPullRequestState.Closed,
                _ => null,
            };
        }
    }
}