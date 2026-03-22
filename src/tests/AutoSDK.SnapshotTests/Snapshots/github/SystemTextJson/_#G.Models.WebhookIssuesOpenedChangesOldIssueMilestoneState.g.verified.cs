//HintName: G.Models.WebhookIssuesOpenedChangesOldIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesOpenedChangesOldIssueMilestoneState
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookIssuesOpenedChangesOldIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesOpenedChangesOldIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesOpenedChangesOldIssueMilestoneState.Closed => "closed",
                WebhookIssuesOpenedChangesOldIssueMilestoneState.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhookIssuesOpenedChangesOldIssueMilestoneState.Closed,
                "open" => WebhookIssuesOpenedChangesOldIssueMilestoneState.Open,
                _ => null,
            };
        }
    }
}