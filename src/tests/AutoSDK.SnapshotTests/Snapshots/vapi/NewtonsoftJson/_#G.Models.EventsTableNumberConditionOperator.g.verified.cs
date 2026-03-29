//HintName: G.Models.EventsTableNumberConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Number comparison operator<br/>
    /// Example: &gt;=
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EventsTableNumberConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="eq")]
        Eq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gt")]
        Gt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gte")]
        Gte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lt")]
        Lt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lte")]
        Lte,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="neq")]
        Neq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsTableNumberConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsTableNumberConditionOperator value)
        {
            return value switch
            {
                EventsTableNumberConditionOperator.Eq => "eq",
                EventsTableNumberConditionOperator.Gt => "gt",
                EventsTableNumberConditionOperator.Gte => "gte",
                EventsTableNumberConditionOperator.Lt => "lt",
                EventsTableNumberConditionOperator.Lte => "lte",
                EventsTableNumberConditionOperator.Neq => "neq",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsTableNumberConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "eq" => EventsTableNumberConditionOperator.Eq,
                "gt" => EventsTableNumberConditionOperator.Gt,
                "gte" => EventsTableNumberConditionOperator.Gte,
                "lt" => EventsTableNumberConditionOperator.Lt,
                "lte" => EventsTableNumberConditionOperator.Lte,
                "neq" => EventsTableNumberConditionOperator.Neq,
                _ => null,
            };
        }
    }
}