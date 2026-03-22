//HintName: G.Models.PredictionRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PredictionRequestWebhookEventsFilterItem
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Logs,
        /// <summary>
        /// 
        /// </summary>
        Output,
        /// <summary>
        /// 
        /// </summary>
        Start,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                PredictionRequestWebhookEventsFilterItem.Completed => "completed",
                PredictionRequestWebhookEventsFilterItem.Logs => "logs",
                PredictionRequestWebhookEventsFilterItem.Output => "output",
                PredictionRequestWebhookEventsFilterItem.Start => "start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PredictionRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "completed" => PredictionRequestWebhookEventsFilterItem.Completed,
                "logs" => PredictionRequestWebhookEventsFilterItem.Logs,
                "output" => PredictionRequestWebhookEventsFilterItem.Output,
                "start" => PredictionRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}