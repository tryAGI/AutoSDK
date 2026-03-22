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
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
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
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
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