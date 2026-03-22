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
    public static class VersionPredictionRequestWebhookEventsFilterItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VersionPredictionRequestWebhookEventsFilterItem value)
        {
            return value switch
            {
                VersionPredictionRequestWebhookEventsFilterItem.Completed => "completed",
                VersionPredictionRequestWebhookEventsFilterItem.Logs => "logs",
                VersionPredictionRequestWebhookEventsFilterItem.Output => "output",
                VersionPredictionRequestWebhookEventsFilterItem.Start => "start",
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
                "completed" => VersionPredictionRequestWebhookEventsFilterItem.Completed,
                "logs" => VersionPredictionRequestWebhookEventsFilterItem.Logs,
                "output" => VersionPredictionRequestWebhookEventsFilterItem.Output,
                "start" => VersionPredictionRequestWebhookEventsFilterItem.Start,
                _ => null,
            };
        }
    }
}