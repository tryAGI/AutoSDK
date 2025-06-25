﻿//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion
    {
        /// <summary>
        /// 
        /// </summary>
        Failure,
        /// <summary>
        /// 
        /// </summary>
        Skipped,
        /// <summary>
        /// 
        /// </summary>
        Success,
        /// <summary>
        /// 
        /// </summary>
        Cancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Failure => "failure",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Skipped => "skipped",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Success => "success",
                WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Cancelled => "cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion? ToEnum(string value)
        {
            return value switch
            {
                "failure" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Failure,
                "skipped" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Skipped,
                "success" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Success,
                "cancelled" => WebhookWorkflowJobCompletedWorkflowJobVariant1StepConclusion.Cancelled,
                _ => null,
            };
        }
    }
}