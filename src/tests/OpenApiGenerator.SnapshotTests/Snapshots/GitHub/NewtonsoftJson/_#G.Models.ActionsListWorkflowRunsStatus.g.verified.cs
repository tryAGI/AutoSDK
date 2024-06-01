//HintName: G.Models.ActionsListWorkflowRunsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ActionsListWorkflowRunsStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stale")]
        Stale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
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
                ActionsListWorkflowRunsStatus.Completed => "completed",
                ActionsListWorkflowRunsStatus.ActionRequired => "action_required",
                ActionsListWorkflowRunsStatus.Cancelled => "cancelled",
                ActionsListWorkflowRunsStatus.Failure => "failure",
                ActionsListWorkflowRunsStatus.Neutral => "neutral",
                ActionsListWorkflowRunsStatus.Skipped => "skipped",
                ActionsListWorkflowRunsStatus.Stale => "stale",
                ActionsListWorkflowRunsStatus.Success => "success",
                ActionsListWorkflowRunsStatus.TimedOut => "timed_out",
                ActionsListWorkflowRunsStatus.InProgress => "in_progress",
                ActionsListWorkflowRunsStatus.Queued => "queued",
                ActionsListWorkflowRunsStatus.Requested => "requested",
                ActionsListWorkflowRunsStatus.Waiting => "waiting",
                ActionsListWorkflowRunsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionsListWorkflowRunsStatus ToEnum(string value)
        {
            return value switch
            {
                "completed" => ActionsListWorkflowRunsStatus.Completed,
                "action_required" => ActionsListWorkflowRunsStatus.ActionRequired,
                "cancelled" => ActionsListWorkflowRunsStatus.Cancelled,
                "failure" => ActionsListWorkflowRunsStatus.Failure,
                "neutral" => ActionsListWorkflowRunsStatus.Neutral,
                "skipped" => ActionsListWorkflowRunsStatus.Skipped,
                "stale" => ActionsListWorkflowRunsStatus.Stale,
                "success" => ActionsListWorkflowRunsStatus.Success,
                "timed_out" => ActionsListWorkflowRunsStatus.TimedOut,
                "in_progress" => ActionsListWorkflowRunsStatus.InProgress,
                "queued" => ActionsListWorkflowRunsStatus.Queued,
                "requested" => ActionsListWorkflowRunsStatus.Requested,
                "waiting" => ActionsListWorkflowRunsStatus.Waiting,
                "pending" => ActionsListWorkflowRunsStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}