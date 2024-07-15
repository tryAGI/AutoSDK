//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobStepsStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobStepsStatus
    {
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
    public static class WebhookWorkflowJobInProgressWorkflowJobStepsStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobStepsStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobStepsStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobStepsStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobStepsStatus.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Completed,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Queued,
                "pending" => WebhookWorkflowJobInProgressWorkflowJobStepsStatus.Pending,
                _ => null,
            };
        }
    }
}