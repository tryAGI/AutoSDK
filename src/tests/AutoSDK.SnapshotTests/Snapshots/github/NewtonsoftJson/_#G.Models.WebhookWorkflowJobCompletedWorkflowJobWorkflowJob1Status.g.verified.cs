//HintName: G.Models.WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, `waiting`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in_progress")]
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="queued")]
        Queued,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="waiting")]
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status value)
        {
            return value switch
            {
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Completed => "completed",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.InProgress => "in_progress",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Queued => "queued",
                WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Completed,
                "in_progress" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.InProgress,
                "queued" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Queued,
                "waiting" => WebhookWorkflowJobCompletedWorkflowJobWorkflowJob1Status.Waiting,
                _ => null,
            };
        }
    }
}