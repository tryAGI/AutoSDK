//HintName: G.Models.VersionPredictionRequestWebhookEventsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VersionPredictionRequestWebhookEventsFilter
    {
        /// <summary>
        /// 
        /// </summary>
        Start,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Completed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VersionPredictionRequestWebhookEventsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionPredictionRequestWebhookEventsFilter value)
        {
            return value switch
            {
                VersionPredictionRequestWebhookEventsFilter.Start => "start",
                VersionPredictionRequestWebhookEventsFilter.Output => "output",
                VersionPredictionRequestWebhookEventsFilter.Logs => "logs",
                VersionPredictionRequestWebhookEventsFilter.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionPredictionRequestWebhookEventsFilter ToEnum(string value)
        {
            return value switch
            {
                "start" => VersionPredictionRequestWebhookEventsFilter.Start,
                "output" => VersionPredictionRequestWebhookEventsFilter.Output,
                "logs" => VersionPredictionRequestWebhookEventsFilter.Logs,
                "completed" => VersionPredictionRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}