//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobWaitingWorkflowJobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
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
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobWaitingWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobWaitingWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobWaitingWorkflowJobStatus.Completed => "completed",
                WebhookWorkflowJobWaitingWorkflowJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStatus? ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobWaitingWorkflowJobStatus.Queued,
                "in_progress" => WebhookWorkflowJobWaitingWorkflowJobStatus.InProgress,
                "completed" => WebhookWorkflowJobWaitingWorkflowJobStatus.Completed,
                "waiting" => WebhookWorkflowJobWaitingWorkflowJobStatus.Waiting,
                _ => null,
            };
        }
    }
}