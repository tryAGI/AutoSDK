//HintName: G.Models.ServerlessLogsHistoryRequestItemConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Condition type for label filtering
    /// </summary>
    public enum ServerlessLogsHistoryRequestItemConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        Equals,
        /// <summary>
        /// 
        /// </summary>
        In,
        /// <summary>
        /// 
        /// </summary>
        NotEquals,
        /// <summary>
        /// 
        /// </summary>
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsHistoryRequestItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsHistoryRequestItemConditionType value)
        {
            return value switch
            {
                ServerlessLogsHistoryRequestItemConditionType.Equals => "equals",
                ServerlessLogsHistoryRequestItemConditionType.In => "in",
                ServerlessLogsHistoryRequestItemConditionType.NotEquals => "not_equals",
                ServerlessLogsHistoryRequestItemConditionType.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsHistoryRequestItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "equals" => ServerlessLogsHistoryRequestItemConditionType.Equals,
                "in" => ServerlessLogsHistoryRequestItemConditionType.In,
                "not_equals" => ServerlessLogsHistoryRequestItemConditionType.NotEquals,
                "not_in" => ServerlessLogsHistoryRequestItemConditionType.NotIn,
                _ => null,
            };
        }
    }
}