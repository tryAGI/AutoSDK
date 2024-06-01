//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesTransferredChangesNewIssueMilestoneState
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
    public static class WebhookIssuesTransferredChangesNewIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueMilestoneState.Open => "open",
                WebhookIssuesTransferredChangesNewIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueMilestoneState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesTransferredChangesNewIssueMilestoneState.Open,
                "closed" => WebhookIssuesTransferredChangesNewIssueMilestoneState.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}