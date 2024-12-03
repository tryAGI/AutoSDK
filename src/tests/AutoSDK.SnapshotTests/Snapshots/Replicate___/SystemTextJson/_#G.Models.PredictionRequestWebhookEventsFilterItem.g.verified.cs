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
    public static class PredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                PredictionRequestWebhookEventsFilterItem.Start => "start",
                PredictionRequestWebhookEventsFilterItem.Output => "output",
                PredictionRequestWebhookEventsFilterItem.Logs => "logs",
                PredictionRequestWebhookEventsFilterItem.Completed => "completed",
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
                "start" => PredictionRequestWebhookEventsFilterItem.Start,
                "output" => PredictionRequestWebhookEventsFilterItem.Output,
                "logs" => PredictionRequestWebhookEventsFilterItem.Logs,
                "completed" => PredictionRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}