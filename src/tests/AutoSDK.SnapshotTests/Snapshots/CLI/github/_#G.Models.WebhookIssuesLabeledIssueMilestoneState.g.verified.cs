﻿//HintName: G.Models.WebhookIssuesLabeledIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesLabeledIssueMilestoneState
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
    public static class WebhookIssuesLabeledIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesLabeledIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesLabeledIssueMilestoneState.Open => "open",
                WebhookIssuesLabeledIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesLabeledIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesLabeledIssueMilestoneState.Open,
                "closed" => WebhookIssuesLabeledIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}