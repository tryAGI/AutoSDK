//HintName: G.Models.TrainingRequestWebhookEventsFilterItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrainingRequestWebhookEventsFilterItem
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