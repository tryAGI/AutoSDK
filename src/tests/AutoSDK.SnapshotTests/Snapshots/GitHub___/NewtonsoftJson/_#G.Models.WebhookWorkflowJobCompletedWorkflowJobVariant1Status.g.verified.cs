//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobVariant1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, `waiting`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobCompletedWorkflowJobVariant1Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
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
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobVariant1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobVariant1Status value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Queued => "queued",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Status.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobVariant1Status? ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Queued,
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobVariant1Status.InProgress,
                "completed" => WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Completed,
                "waiting" => WebhookWorkflowJobCompletedWorkflowJobVariant1Status.Waiting,
                _ => null,
            };
        }
    }
}