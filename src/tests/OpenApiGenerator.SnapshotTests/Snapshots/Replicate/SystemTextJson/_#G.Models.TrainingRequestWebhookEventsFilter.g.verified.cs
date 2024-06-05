//HintName: G.Models.TrainingRequestWebhookEventsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TrainingRequestWebhookEventsFilter
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
    public static class TrainingRequestWebhookEventsFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TrainingRequestWebhookEventsFilter value)
        {
            return value switch
            {
                TrainingRequestWebhookEventsFilter.Start => "start",
                TrainingRequestWebhookEventsFilter.Output => "output",
                TrainingRequestWebhookEventsFilter.Logs => "logs",
                TrainingRequestWebhookEventsFilter.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TrainingRequestWebhookEventsFilter? ToEnum(string value)
        {
            return value switch
            {
                "start" => TrainingRequestWebhookEventsFilter.Start,
                "output" => TrainingRequestWebhookEventsFilter.Output,
                "logs" => TrainingRequestWebhookEventsFilter.Logs,
                "completed" => TrainingRequestWebhookEventsFilter.Completed,
                _ => null,
            };
        }
    }
}