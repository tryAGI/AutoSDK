//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobQueuedWorkflowJobStatus
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
    public static class WebhookWorkflowJobQueuedWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobQueuedWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobQueuedWorkflowJobStatus.Completed => "completed",
                WebhookWorkflowJobQueuedWorkflowJobStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobQueuedWorkflowJobStatus.Queued,
                "in_progress" => WebhookWorkflowJobQueuedWorkflowJobStatus.InProgress,
                "completed" => WebhookWorkflowJobQueuedWorkflowJobStatus.Completed,
                "waiting" => WebhookWorkflowJobQueuedWorkflowJobStatus.Waiting,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}