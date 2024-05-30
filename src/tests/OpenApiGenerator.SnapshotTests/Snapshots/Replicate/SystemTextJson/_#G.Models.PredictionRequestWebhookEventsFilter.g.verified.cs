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

    public static class PredictionRequestWebhookEventsFilterExtensions
    {
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
        public static PredictionRequestWebhookEventsFilter ToEnum(int value)
        {
            return value switch
            {
                0 => PredictionRequestWebhookEventsFilter.Start,
                1 => PredictionRequestWebhookEventsFilter.Output,
                2 => PredictionRequestWebhookEventsFilter.Logs,
                3 => PredictionRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}