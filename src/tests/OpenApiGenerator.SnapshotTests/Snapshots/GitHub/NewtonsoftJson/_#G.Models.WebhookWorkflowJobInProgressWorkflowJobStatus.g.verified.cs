//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobStatus.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobStatus.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobInProgressWorkflowJobStatus.Queued,
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobStatus.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobStatus.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}