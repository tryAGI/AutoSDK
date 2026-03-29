//HintName: G.Models.ServerlessLogsStreamRequestItemConditionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Condition type for label filtering
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerlessLogsStreamRequestItemConditionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="equals")]
        Equals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="in")]
        In,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_equals")]
        NotEquals,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="not_in")]
        NotIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerlessLogsStreamRequestItemConditionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerlessLogsStreamRequestItemConditionType value)
        {
            return value switch
            {
                ServerlessLogsStreamRequestItemConditionType.Equals => "equals",
                ServerlessLogsStreamRequestItemConditionType.In => "in",
                ServerlessLogsStreamRequestItemConditionType.NotEquals => "not_equals",
                ServerlessLogsStreamRequestItemConditionType.NotIn => "not_in",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerlessLogsStreamRequestItemConditionType? ToEnum(string value)
        {
            return value switch
            {
                "equals" => ServerlessLogsStreamRequestItemConditionType.Equals,
                "in" => ServerlessLogsStreamRequestItemConditionType.In,
                "not_equals" => ServerlessLogsStreamRequestItemConditionType.NotEquals,
                "not_in" => ServerlessLogsStreamRequestItemConditionType.NotIn,
                _ => null,
            };
        }
    }
}