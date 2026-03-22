//HintName: G.Models.WebhookIssuesTransferredChangesNewIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesTransferredChangesNewIssueMilestoneState
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
    public static class WebhookIssuesTransferredChangesNewIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesTransferredChangesNewIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesTransferredChangesNewIssueMilestoneState.Closed => "closed",
                WebhookIssuesTransferredChangesNewIssueMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesTransferredChangesNewIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesTransferredChangesNewIssueMilestoneState.Closed,
                "open" => WebhookIssuesTransferredChangesNewIssueMilestoneState.Open,
                _ => null,
            };
        }
    }
}