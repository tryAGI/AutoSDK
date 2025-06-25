//HintName: G.Models.TrainingRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingRequestWebhookEventsFilterItem
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
    public static class TrainingRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                TrainingRequestWebhookEventsFilterItem.Start => "start",
                TrainingRequestWebhookEventsFilterItem.Output => "output",
                TrainingRequestWebhookEventsFilterItem.Logs => "logs",
                TrainingRequestWebhookEventsFilterItem.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "start" => TrainingRequestWebhookEventsFilterItem.Start,
                "output" => TrainingRequestWebhookEventsFilterItem.Output,
                "logs" => TrainingRequestWebhookEventsFilterItem.Logs,
                "completed" => TrainingRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}