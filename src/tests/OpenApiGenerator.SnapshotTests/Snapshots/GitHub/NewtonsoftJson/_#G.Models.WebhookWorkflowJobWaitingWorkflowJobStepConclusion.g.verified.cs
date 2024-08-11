//HintName: G.Models.WebhookWorkflowJobWaitingWorkflowJobStepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobWaitingWorkflowJobStepConclusion
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
    public static class WebhookWorkflowJobWaitingWorkflowJobStepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobWaitingWorkflowJobStepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Failure => "failure",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Skipped => "skipped",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Success => "success",
                WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobWaitingWorkflowJobStepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Failure,
                "skipped" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Skipped,
                "success" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Success,
                "cancelled" => WebhookWorkflowJobWaitingWorkflowJobStepConclusion.Cancelled,
                _ => null,
            };
        }
    }
}