//HintName: G.Models.PredictionRequestWebhookEventsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PredictionRequestWebhookEventsFilter
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
    public static class PredictionRequestWebhookEventsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionRequestWebhookEventsFilter value)
        {
            return value switch
            {
                PredictionRequestWebhookEventsFilter.Start => "start",
                PredictionRequestWebhookEventsFilter.Output => "output",
                PredictionRequestWebhookEventsFilter.Logs => "logs",
                PredictionRequestWebhookEventsFilter.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionRequestWebhookEventsFilter ToEnum(string value)
        {
            return value switch
            {
                "start" => PredictionRequestWebhookEventsFilter.Start,
                "output" => PredictionRequestWebhookEventsFilter.Output,
                "logs" => PredictionRequestWebhookEventsFilter.Logs,
                "completed" => PredictionRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}