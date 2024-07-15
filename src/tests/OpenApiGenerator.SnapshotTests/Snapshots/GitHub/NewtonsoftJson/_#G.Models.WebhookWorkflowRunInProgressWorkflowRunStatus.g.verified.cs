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
                WebhookWorkflowRunInProgressWorkflowRunStatus.Requested => "requested",
                WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress => "in_progress",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Completed => "completed",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Queued => "queued",
                WebhookWorkflowRunInProgressWorkflowRunStatus.Pending => "pending",
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
                "requested" => WebhookWorkflowRunInProgressWorkflowRunStatus.Requested,
                "in_progress" => WebhookWorkflowRunInProgressWorkflowRunStatus.InProgress,
                "completed" => WebhookWorkflowRunInProgressWorkflowRunStatus.Completed,
                "queued" => WebhookWorkflowRunInProgressWorkflowRunStatus.Queued,
                "pending" => WebhookWorkflowRunInProgressWorkflowRunStatus.Pending,
                _ => null,
            };
        }
    }
}