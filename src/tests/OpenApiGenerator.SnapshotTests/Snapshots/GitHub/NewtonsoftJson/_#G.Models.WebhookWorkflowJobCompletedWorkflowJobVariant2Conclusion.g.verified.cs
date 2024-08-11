//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="success")]
        Success,
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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="action_required")]
        ActionRequired,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="timed_out")]
        TimedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant2ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.ActionRequired => "action_required",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Neutral => "neutral",
                WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.TimedOut => "timed_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Success,
                "failure" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Failure,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Skipped,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Cancelled,
                "action_required" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.ActionRequired,
                "neutral" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.Neutral,
                "timed_out" => WebhookWorkflowJobCompletedWorkflowJobVariant2Conclusion.TimedOut,
                _ => null,
            };
        }
    }
}