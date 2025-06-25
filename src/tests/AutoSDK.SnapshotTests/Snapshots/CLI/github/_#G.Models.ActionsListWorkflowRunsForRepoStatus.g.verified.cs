//HintName: G.Models.ActionsListWorkflowRunsForRepoStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ActionsListWorkflowRunsForRepoStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
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
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Neutral,
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
        InProgress,
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
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionsListWorkflowRunsForRepoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListWorkflowRunsForRepoStatus value)
        {
            return value switch
            {
                ActionsListWorkflowRunsForRepoStatus.Completed => "completed",
                ActionsListWorkflowRunsForRepoStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsForRepoStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsForRepoStatus.Failure => "failure",
                ActionsListWorkflowRunsForRepoStatus.Neutral => "neutral",
                ActionsListWorkflowRunsForRepoStatus.Skipped => "skipped",
                ActionsListWorkflowRunsForRepoStatus.Stale => "stale",
                ActionsListWorkflowRunsForRepoStatus.Success => "success",
                ActionsListWorkflowRunsForRepoStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsForRepoStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsForRepoStatus.Queued => "queued",
                ActionsListWorkflowRunsForRepoStatus.Requested => "requested",
                ActionsListWorkflowRunsForRepoStatus.Waiting => "waiting",
                ActionsListWorkflowRunsForRepoStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListWorkflowRunsForRepoStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => ActionsListWorkflowRunsForRepoStatus.Completed,
                "action_required" => ActionsListWorkflowRunsForRepoStatus.ActionRequired,
                "cancelled" => ActionsListWorkflowRunsForRepoStatus.Cancelled,
                "failure" => ActionsListWorkflowRunsForRepoStatus.Failure,
                "neutral" => ActionsListWorkflowRunsForRepoStatus.Neutral,
                "skipped" => ActionsListWorkflowRunsForRepoStatus.Skipped,
                "stale" => ActionsListWorkflowRunsForRepoStatus.Stale,
                "success" => ActionsListWorkflowRunsForRepoStatus.Success,
                "timed_out" => ActionsListWorkflowRunsForRepoStatus.TimedOut,
                "in_progress" => ActionsListWorkflowRunsForRepoStatus.InProgress,
                "queued" => ActionsListWorkflowRunsForRepoStatus.Queued,
                "requested" => ActionsListWorkflowRunsForRepoStatus.Requested,
                "waiting" => ActionsListWorkflowRunsForRepoStatus.Waiting,
                "pending" => ActionsListWorkflowRunsForRepoStatus.Pending,
                _ => null,
            };
        }
    }
}