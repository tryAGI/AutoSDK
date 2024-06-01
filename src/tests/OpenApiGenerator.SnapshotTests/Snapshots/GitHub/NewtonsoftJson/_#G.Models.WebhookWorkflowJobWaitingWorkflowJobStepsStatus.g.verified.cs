//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobWaitingWorkflowJobStepsStatus
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepsStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Pending => "pending",
                WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepsStatus ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Completed,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.InProgress,
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Queued,
                "pending" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Pending,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStepsStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}