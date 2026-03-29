//HintName: G.Models.RunObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, `incomplete`, or `expired`.
    /// </summary>
    public enum RunObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RunObjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RunObjectStatus value)
        {
            return value switch
            {
                RunObjectStatus.Cancelled => "cancelled",
                RunObjectStatus.Cancelling => "cancelling",
                RunObjectStatus.Completed => "completed",
                RunObjectStatus.Expired => "expired",
                RunObjectStatus.Failed => "failed",
                RunObjectStatus.InProgress => "in_progress",
                RunObjectStatus.Incomplete => "incomplete",
                RunObjectStatus.Queued => "queued",
                RunObjectStatus.RequiresAction => "requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RunObjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "cancelled" => RunObjectStatus.Cancelled,
                "cancelling" => RunObjectStatus.Cancelling,
                "completed" => RunObjectStatus.Completed,
                "expired" => RunObjectStatus.Expired,
                "failed" => RunObjectStatus.Failed,
                "in_progress" => RunObjectStatus.InProgress,
                "incomplete" => RunObjectStatus.Incomplete,
                "queued" => RunObjectStatus.Queued,
                "requires_action" => RunObjectStatus.RequiresAction,
                _ => null,
            };
        }
    }
}