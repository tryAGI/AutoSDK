//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobConclusion
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
        [global::System.Runtime.Serialization.EnumMember(Value="cancelled")]
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neutral")]
        Neutral,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobConclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobConclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobConclusion.Cancelled => "cancelled",
                WebhookWorkflowJobInProgressWorkflowJobConclusion.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobConclusion ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Success,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Failure,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Cancelled,
                "neutral" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Neutral,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}