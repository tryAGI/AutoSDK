//HintName: G.Models.WebhookWorkflowRunRequestedWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunRequestedWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="requested")]
        Requested,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunRequestedWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunRequestedWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookWorkflowRunRequestedWorkflowRunStatus.Requested => "requested",
                WebhookWorkflowRunRequestedWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunRequestedWorkflowRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunRequestedWorkflowRunStatus ToEnum(string value)
        {
            return value switch
            {
                "requested" => WebhookWorkflowRunRequestedWorkflowRunStatus.Requested,
                "in_progress" => WebhookWorkflowRunRequestedWorkflowRunStatus.InProgress,
                "completed" => WebhookWorkflowRunRequestedWorkflowRunStatus.Completed,
                "queued" => WebhookWorkflowRunRequestedWorkflowRunStatus.Queued,
                "pending" => WebhookWorkflowRunRequestedWorkflowRunStatus.Pending,
                "waiting" => WebhookWorkflowRunRequestedWorkflowRunStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}