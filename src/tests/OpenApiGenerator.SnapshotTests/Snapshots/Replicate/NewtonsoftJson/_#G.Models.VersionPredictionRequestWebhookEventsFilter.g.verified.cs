//HintName: G.Models.VersionPredictionRequestWebhookEventsFilter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VersionPredictionRequestWebhookEventsFilter
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