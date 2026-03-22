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
    public static class ActionsListWorkflowRunsForRepoStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionsListWorkflowRunsForRepoStatus value)
        {
            return value switch
            {
                ActionsListWorkflowRunsForRepoStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsForRepoStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsForRepoStatus.Completed => "completed",
                ActionsListWorkflowRunsForRepoStatus.Failure => "failure",
                ActionsListWorkflowRunsForRepoStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsForRepoStatus.Neutral => "neutral",
                ActionsListWorkflowRunsForRepoStatus.Pending => "pending",
                ActionsListWorkflowRunsForRepoStatus.Queued => "queued",
                ActionsListWorkflowRunsForRepoStatus.Requested => "requested",
                ActionsListWorkflowRunsForRepoStatus.Skipped => "skipped",
                ActionsListWorkflowRunsForRepoStatus.Stale => "stale",
                ActionsListWorkflowRunsForRepoStatus.Success => "success",
                ActionsListWorkflowRunsForRepoStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsForRepoStatus.Waiting => "waiting",
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
                "action_required" => ActionsListWorkflowRunsForRepoStatus.ActionRequired,
                "cancelled" => ActionsListWorkflowRunsForRepoStatus.Cancelled,
                "completed" => ActionsListWorkflowRunsForRepoStatus.Completed,
                "failure" => ActionsListWorkflowRunsForRepoStatus.Failure,
                "in_progress" => ActionsListWorkflowRunsForRepoStatus.InProgress,
                "neutral" => ActionsListWorkflowRunsForRepoStatus.Neutral,
                "pending" => ActionsListWorkflowRunsForRepoStatus.Pending,
                "queued" => ActionsListWorkflowRunsForRepoStatus.Queued,
                "requested" => ActionsListWorkflowRunsForRepoStatus.Requested,
                "skipped" => ActionsListWorkflowRunsForRepoStatus.Skipped,
                "stale" => ActionsListWorkflowRunsForRepoStatus.Stale,
                "success" => ActionsListWorkflowRunsForRepoStatus.Success,
                "timed_out" => ActionsListWorkflowRunsForRepoStatus.TimedOut,
                "waiting" => ActionsListWorkflowRunsForRepoStatus.Waiting,
                _ => null,
            };
        }
    }
}