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
        Open,
        /// <summary>
        /// 
        /// </summary>
        Closed,
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
                WebhookIssuesOpenedChangesOldIssueMilestoneState.Open => "open",
                WebhookIssuesOpenedChangesOldIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesOpenedChangesOldIssueMilestoneState ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesOpenedChangesOldIssueMilestoneState.Open,
                "closed" => WebhookIssuesOpenedChangesOldIssueMilestoneState.Closed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}