//HintName: G.Models.WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the job. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1StatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status value)
        {
            return value switch
            {
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Queued => "queued",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.InProgress => "in_progress",
                WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status? ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Queued,
                "in_progress" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.InProgress,
                "completed" => WebhookWorkflowJobInProgressWorkflowJobWorkflowJob1Status.Completed,
                _ => null,
            };
        }
    }
}