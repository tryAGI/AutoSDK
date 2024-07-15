//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobQueuedWorkflowJobStepsConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="failure")]
        Failure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="skipped")]
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStepsConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStepsConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Failure => "failure",
                WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Skipped => "skipped",
                WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Success => "success",
                WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStepsConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Failure,
                "skipped" => WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Skipped,
                "success" => WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Success,
                "cancelled" => WebhookWorkflowJobQueuedWorkflowJobStepsConclusion.Cancelled,
                _ => null,
            };
        }
    }
}