﻿//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of the issue; either 'open' or 'closed'
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1State
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
    public static class WebhookIssueCommentCreatedIssueVariant1StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1State value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1State.Open => "open",
                WebhookIssueCommentCreatedIssueVariant1State.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1State? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentCreatedIssueVariant1State.Open,
                "closed" => WebhookIssueCommentCreatedIssueVariant1State.Closed,
                _ => null,
            };
        }
    }
}