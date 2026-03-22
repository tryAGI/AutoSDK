//HintName: G.Models.ActionsListWorkflowRunsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsListWorkflowRunsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Requested,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Stale,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsListWorkflowRunsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListWorkflowRunsStatus value)
        {
            return value switch
            {
                ActionsListWorkflowRunsStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsStatus.Completed => "completed",
                ActionsListWorkflowRunsStatus.Failure => "failure",
                ActionsListWorkflowRunsStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsStatus.Neutral => "neutral",
                ActionsListWorkflowRunsStatus.Pending => "pending",
                ActionsListWorkflowRunsStatus.Queued => "queued",
                ActionsListWorkflowRunsStatus.Requested => "requested",
                ActionsListWorkflowRunsStatus.Skipped => "skipped",
                ActionsListWorkflowRunsStatus.Stale => "stale",
                ActionsListWorkflowRunsStatus.Success => "success",
                ActionsListWorkflowRunsStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListWorkflowRunsStatus? ToEnum(string value)
        {
            return value switch
            {
                "action_required" => ActionsListWorkflowRunsStatus.ActionRequired,
                "cancelled" => ActionsListWorkflowRunsStatus.Cancelled,
                "completed" => ActionsListWorkflowRunsStatus.Completed,
                "failure" => ActionsListWorkflowRunsStatus.Failure,
                "in_progress" => ActionsListWorkflowRunsStatus.InProgress,
                "neutral" => ActionsListWorkflowRunsStatus.Neutral,
                "pending" => ActionsListWorkflowRunsStatus.Pending,
                "queued" => ActionsListWorkflowRunsStatus.Queued,
                "requested" => ActionsListWorkflowRunsStatus.Requested,
                "skipped" => ActionsListWorkflowRunsStatus.Skipped,
                "stale" => ActionsListWorkflowRunsStatus.Stale,
                "success" => ActionsListWorkflowRunsStatus.Success,
                "timed_out" => ActionsListWorkflowRunsStatus.TimedOut,
                "waiting" => ActionsListWorkflowRunsStatus.Waiting,
                _ => null,
            };
        }
    }
}