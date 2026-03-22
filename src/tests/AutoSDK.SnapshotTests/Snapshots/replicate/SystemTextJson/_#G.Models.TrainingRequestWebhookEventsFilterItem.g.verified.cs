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
    public static class TrainingRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                TrainingRequestWebhookEventsFilterItem.Completed => "completed",
                TrainingRequestWebhookEventsFilterItem.Logs => "logs",
                TrainingRequestWebhookEventsFilterItem.Output => "output",
                TrainingRequestWebhookEventsFilterItem.Start => "start",
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
                "completed" => TrainingRequestWebhookEventsFilterItem.Completed,
                "logs" => TrainingRequestWebhookEventsFilterItem.Logs,
                "output" => TrainingRequestWebhookEventsFilterItem.Output,
                "start" => TrainingRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}