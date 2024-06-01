//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhookDeploymentStatusCreatedCheckRunStatus
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
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pending")]
        Pending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookDeploymentStatusCreatedCheckRunStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookDeploymentStatusCreatedCheckRunStatus value)
        {
            return value switch
            {
                WebhookDeploymentStatusCreatedCheckRunStatus.Queued => "queued",
                WebhookDeploymentStatusCreatedCheckRunStatus.InProgress => "in_progress",
                WebhookDeploymentStatusCreatedCheckRunStatus.Completed => "completed",
                WebhookDeploymentStatusCreatedCheckRunStatus.Waiting => "waiting",
                WebhookDeploymentStatusCreatedCheckRunStatus.Pending => "pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedCheckRunStatus ToEnum(string value)
        {
            return value switch
            {
                "queued" => WebhookDeploymentStatusCreatedCheckRunStatus.Queued,
                "in_progress" => WebhookDeploymentStatusCreatedCheckRunStatus.InProgress,
                "completed" => WebhookDeploymentStatusCreatedCheckRunStatus.Completed,
                "waiting" => WebhookDeploymentStatusCreatedCheckRunStatus.Waiting,
                "pending" => WebhookDeploymentStatusCreatedCheckRunStatus.Pending,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}