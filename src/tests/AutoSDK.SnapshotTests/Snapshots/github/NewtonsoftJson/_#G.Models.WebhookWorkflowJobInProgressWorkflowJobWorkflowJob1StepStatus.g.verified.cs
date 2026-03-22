//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Pending => "pending",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Queued => "queued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Completed,
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.InProgress,
                "pending" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Pending,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StepStatus.Queued,
                _ => null,
            };
        }
    }
}