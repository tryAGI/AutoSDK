//HintName: G.Models.VersionPredictionRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VersionPredictionRequestWebhookEventsFilterItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start")]
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