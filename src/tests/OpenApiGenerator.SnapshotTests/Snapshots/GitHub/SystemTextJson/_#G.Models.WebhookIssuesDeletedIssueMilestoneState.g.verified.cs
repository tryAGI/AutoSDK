//HintName: G.Models.WebhookIssuesDeletedIssueMilestoneState.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum WebhookIssuesDeletedIssueMilestoneState
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
    public static class WebhookIssuesDeletedIssueMilestoneStateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookIssuesDeletedIssueMilestoneState value)
        {
            return value switch
            {
                WebhookIssuesDeletedIssueMilestoneState.Open => "open",
                WebhookIssuesDeletedIssueMilestoneState.Closed => "closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookIssuesDeletedIssueMilestoneState? ToEnum(string value)
        {
            return value switch
            {
                "open" => WebhookIssuesDeletedIssueMilestoneState.Open,
                "closed" => WebhookIssuesDeletedIssueMilestoneState.Closed,
                _ => null,
            };
        }
    }
}