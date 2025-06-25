﻿//HintName: G.Models.WebhookWorkflowJobQueuedWorkflowJobStepStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebhookWorkflowJobQueuedWorkflowJobStepStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobQueuedWorkflowJobStepStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobQueuedWorkflowJobStepStatus value)
        {
            return value switch
            {
                WebhookWorkflowJobQueuedWorkflowJobStepStatus.Completed => "completed",
                WebhookWorkflowJobQueuedWorkflowJobStepStatus.InProgress => "in_progress",
                WebhookWorkflowJobQueuedWorkflowJobStepStatus.Queued => "queued",
                WebhookWorkflowJobQueuedWorkflowJobStepStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobQueuedWorkflowJobStepStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobQueuedWorkflowJobStepStatus.Completed,
                "in_progress" => WebhookWorkflowJobQueuedWorkflowJobStepStatus.InProgress,
                "queued" => WebhookWorkflowJobQueuedWorkflowJobStepStatus.Queued,
                "pending" => WebhookWorkflowJobQueuedWorkflowJobStepStatus.Pending,
                _ => null,
            };
        }
    }
}