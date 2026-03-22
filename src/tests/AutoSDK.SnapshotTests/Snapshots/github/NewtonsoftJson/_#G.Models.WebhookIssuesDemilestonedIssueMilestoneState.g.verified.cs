//HintName: G.Models.WebhookIssuesDemilestonedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookIssuesDemilestonedIssueMilestoneState
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
    public static class WebhookIssuesDemilestonedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDemilestonedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesDemilestonedIssueMilestoneState.Closed => "closed",
                WebhookIssuesDemilestonedIssueMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDemilestonedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesDemilestonedIssueMilestoneState.Closed,
                "open" => WebhookIssuesDemilestonedIssueMilestoneState.Open,
                _ => null,
            };
        }
    }
}