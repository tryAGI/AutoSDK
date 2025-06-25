﻿//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion
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
    public static class WebhookWorkflowJobInProgressWorkflowJobVariant1ConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Success => "success",
                WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Failure => "failure",
                WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Cancelled => "cancelled",
                WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Neutral => "neutral",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion? ToEnum(string value)
        {
            return value switch
            {
                "success" => WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Success,
                "failure" => WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Failure,
                "cancelled" => WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Cancelled,
                "neutral" => WebhookWorkflowJobInProgressWorkflowJobVariant1Conclusion.Neutral,
                _ => null,
            };
        }
    }
}