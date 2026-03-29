//HintName: G.Models.EventsTableStringConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// String comparison operator<br/>
    /// Example: =
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventsTableStringConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="!=")]
        Neq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="=")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contains")]
        Contains,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="notContains")]
        NotContains,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsTableStringConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsTableStringConditionOperator value)
        {
            return value switch
            {
                EventsTableStringConditionOperator.Neq => "!=",
                EventsTableStringConditionOperator.Eq => "=",
                EventsTableStringConditionOperator.Contains => "contains",
                EventsTableStringConditionOperator.NotContains => "notContains",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsTableStringConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "!=" => EventsTableStringConditionOperator.Neq,
                "=" => EventsTableStringConditionOperator.Eq,
                "contains" => EventsTableStringConditionOperator.Contains,
                "notContains" => EventsTableStringConditionOperator.NotContains,
                _ => null,
            };
        }
    }
}