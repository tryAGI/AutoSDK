//HintName: G.Models.WebhookDeploymentStatusCreatedCheckRunStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The current status of the check run. Can be `queued`, `in_progress`, or `completed`.
    /// </summary>
    public enum WebhookDeploymentStatusCreatedCheckRunStatus
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
        Pending,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
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
                WebhookDeploymentStatusCreatedCheckRunStatus.Completed => "completed",
                WebhookDeploymentStatusCreatedCheckRunStatus.InProgress => "in_progress",
                WebhookDeploymentStatusCreatedCheckRunStatus.Pending => "pending",
                WebhookDeploymentStatusCreatedCheckRunStatus.Queued => "queued",
                WebhookDeploymentStatusCreatedCheckRunStatus.Waiting => "waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookDeploymentStatusCreatedCheckRunStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => WebhookDeploymentStatusCreatedCheckRunStatus.Completed,
                "in_progress" => WebhookDeploymentStatusCreatedCheckRunStatus.InProgress,
                "pending" => WebhookDeploymentStatusCreatedCheckRunStatus.Pending,
                "queued" => WebhookDeploymentStatusCreatedCheckRunStatus.Queued,
                "waiting" => WebhookDeploymentStatusCreatedCheckRunStatus.Waiting,
                _ => null,
            };
        }
    }
}