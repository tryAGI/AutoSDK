﻿//HintName: G.Models.WebhooksIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhooksIssueState
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
    public static class WebhooksIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksIssueState value)
        {
            return value switch
            {
                WebhooksIssueState.Open => "open",
                WebhooksIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhooksIssueState.Open,
                "closed" => WebhooksIssueState.Closed,
                _ => null,
            };
        }
    }
}