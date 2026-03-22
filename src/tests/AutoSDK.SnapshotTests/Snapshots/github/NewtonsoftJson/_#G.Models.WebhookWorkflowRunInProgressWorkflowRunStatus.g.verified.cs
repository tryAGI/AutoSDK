//HintName: G.Models.WebhookWorkflowRunInProgressWorkflowRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowRunInProgressWorkflowRunStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowRunInProgressWorkflowRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowRunInProgressWorkflowRunStatus value)
        {
            return value switch
            {
                WebhookWorkflowRunInProgressWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Pending => "pending",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Requested => "requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowRunInProgressWorkflowRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowRunInProgressWorkflowRunStatus.Completed,
                "in_progress" => WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress,
                "pending" => WebhookWorkflowRunInProgressWorkflowRunStatus.Pending,
                "queued" => WebhookWorkflowRunInProgressWorkflowRunStatus.Queued,
                "requested" => WebhookWorkflowRunInProgressWorkflowRunStatus.Requested,
                _ => null,
            };
        }
    }
}