﻿//HintName: G.Models.WebhookIssueCommentCreatedIssueVariant1MilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssueCommentCreatedIssueVariant1MilestoneState
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
    public static class WebhookIssueCommentCreatedIssueVariant1MilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssueCommentCreatedIssueVariant1MilestoneState value)
        {
            return value switch
            {
                WebhookIssueCommentCreatedIssueVariant1MilestoneState.Open => "open",
                WebhookIssueCommentCreatedIssueVariant1MilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssueCommentCreatedIssueVariant1MilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssueCommentCreatedIssueVariant1MilestoneState.Open,
                "closed" => WebhookIssueCommentCreatedIssueVariant1MilestoneState.Closed,
                _ => null,
            };
        }
    }
}