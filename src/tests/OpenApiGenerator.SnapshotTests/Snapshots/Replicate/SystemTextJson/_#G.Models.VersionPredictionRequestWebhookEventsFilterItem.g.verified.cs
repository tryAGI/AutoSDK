//HintName: G.Models.VersionPredictionRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum VersionPredictionRequestWebhookEventsFilterItem
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
    public static class VersionPredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionPredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                VersionPredictionRequestWebhookEventsFilterItem.Start => "start",
                VersionPredictionRequestWebhookEventsFilterItem.Output => "output",
                VersionPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                VersionPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VersionPredictionRequestWebhookEventsFilterItem? ToEnum(string value)
        {
            return value switch
            {
                "start" => VersionPredictionRequestWebhookEventsFilterItem.Start,
                "output" => VersionPredictionRequestWebhookEventsFilterItem.Output,
                "logs" => VersionPredictionRequestWebhookEventsFilterItem.Logs,
                "completed" => VersionPredictionRequestWebhookEventsFilterItem.Completed,
                _ => null,
            };
        }
    }
}