//HintName: G.Models.PredictionRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PredictionRequestWebhookEventsFilterItem
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