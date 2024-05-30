//HintName: G.Models.TrainingRequestWebhookEventsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TrainingRequestWebhookEventsFilter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="start")]
        Start,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="output")]
        Output,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="completed")]
        Completed,
    }

    public static class TrainingRequestWebhookEventsFilterExtensions
    {
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
        public static TrainingRequestWebhookEventsFilter ToEnum(string value)
        {
            return value switch
            {
                "start" => TrainingRequestWebhookEventsFilter.Start,
                "output" => TrainingRequestWebhookEventsFilter.Output,
                "logs" => TrainingRequestWebhookEventsFilter.Logs,
                "completed" => TrainingRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static TrainingRequestWebhookEventsFilter ToEnum(int value)
        {
            return value switch
            {
                0 => TrainingRequestWebhookEventsFilter.Start,
                1 => TrainingRequestWebhookEventsFilter.Output,
                2 => TrainingRequestWebhookEventsFilter.Logs,
                3 => TrainingRequestWebhookEventsFilter.Completed,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}