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

    public static class VersionPredictionRequestWebhookEventsFilterExtensions
    {
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
        public static VersionPredictionRequestWebhookEventsFilter ToEnum(int value)
        {
            return value switch
            {
                0 => VersionPredictionRequestWebhookEventsFilter.Start,
                1 => VersionPredictionRequestWebhookEventsFilter.Output,
                2 => VersionPredictionRequestWebhookEventsFilter.Logs,
                3 => VersionPredictionRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}