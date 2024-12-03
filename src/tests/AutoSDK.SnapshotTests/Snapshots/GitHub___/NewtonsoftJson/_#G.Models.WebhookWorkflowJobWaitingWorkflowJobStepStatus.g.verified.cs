//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobWaitingWorkflowJobStepStatus
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Pending => "pending",
                WebhookWorkflowJobWaitingWorkflowJobStepStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Completed,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.InProgress,
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Queued,
                "pending" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Pending,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStepStatus.Waiting,
                _ => null,
            };
        }
    }
}