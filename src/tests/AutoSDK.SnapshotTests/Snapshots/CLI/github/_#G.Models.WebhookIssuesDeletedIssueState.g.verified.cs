﻿//HintName: G.Models.WebhookIssuesDeletedIssueState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssuesDeletedIssueState
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
    public static class WebhookIssuesDeletedIssueStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueState value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueState.Open => "open",
                WebhookIssuesDeletedIssueState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesDeletedIssueState.Open,
                "closed" => WebhookIssuesDeletedIssueState.Closed,
                _ => null,
            };
        }
    }
}