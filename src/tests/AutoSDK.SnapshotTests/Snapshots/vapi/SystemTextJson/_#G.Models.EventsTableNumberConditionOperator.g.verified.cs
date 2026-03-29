//HintName: G.Models.EventsTableNumberConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Number comparison operator<br/>
    /// Example: &gt;=
    /// </summary>
    public enum EventsTableNumberConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
        /// <summary>
        /// 
        /// </summary>
        Gt,
        /// <summary>
        /// 
        /// </summary>
        Gte,
        /// <summary>
        /// 
        /// </summary>
        Lt,
        /// <summary>
        /// 
        /// </summary>
        Lte,
        /// <summary>
        /// 
        /// </summary>
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