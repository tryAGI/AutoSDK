//HintName: G.Models.RunObjectStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the run, which can be either `queued`, `in_progress`, `requires_action`, `cancelling`, `cancelled`, `failed`, `completed`, or `expired`.
    /// </summary>
    public enum RunObjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        RequiresAction,
        /// <summary>
        /// 
        /// </summary>
        Cancelling,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Expired,
    }

    public static class RunObjectStatusExtensions
    {
        public static string ToValueString(this RunObjectStatus value)
        {
            return value switch
            {
                RunObjectStatus.Queued => "queued",
                RunObjectStatus.InProgress => "in_progress",
                RunObjectStatus.RequiresAction => "requires_action",
                RunObjectStatus.Cancelling => "cancelling",
                RunObjectStatus.Cancelled => "cancelled",
                RunObjectStatus.Failed => "failed",
                RunObjectStatus.Completed => "completed",
                RunObjectStatus.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => RunObjectStatus.Queued,
                "in_progress" => RunObjectStatus.InProgress,
                "requires_action" => RunObjectStatus.RequiresAction,
                "cancelling" => RunObjectStatus.Cancelling,
                "cancelled" => RunObjectStatus.Cancelled,
                "failed" => RunObjectStatus.Failed,
                "completed" => RunObjectStatus.Completed,
                "expired" => RunObjectStatus.Expired,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunObjectStatus ToEnum(int value)
        {
            return value switch
            {
                0 => RunObjectStatus.Queued,
                1 => RunObjectStatus.InProgress,
                2 => RunObjectStatus.RequiresAction,
                3 => RunObjectStatus.Cancelling,
                4 => RunObjectStatus.Cancelled,
                5 => RunObjectStatus.Failed,
                6 => RunObjectStatus.Completed,
                7 => RunObjectStatus.Expired,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}