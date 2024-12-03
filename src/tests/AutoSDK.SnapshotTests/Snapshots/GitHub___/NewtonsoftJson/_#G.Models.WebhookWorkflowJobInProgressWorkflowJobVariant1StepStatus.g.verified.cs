//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus
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
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Completed => "completed",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus? ToEnum(string value)
        {
            return value switch
            {
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Completed,
                "queued" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Queued,
                "pending" => WebhookWorkflowJobInProgressWorkflowJobVariant1StepStatus.Pending,
                _ => null,
            };
        }
    }
}