//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
        /// <summary>
        /// 
        /// </summary>
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
        public static WebhookWorkflowJobInProgressWorkflowJobConclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Success,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Failure,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Cancelled,
                "neutral" => WebhookWorkflowJobInProgressWorkflowJobConclusion.Neutral,
                _ => null,
            };
        }
    }
}