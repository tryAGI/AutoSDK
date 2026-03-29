//HintName: G.Models.EventsTableBooleanConditionOperator.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Boolean comparison operator<br/>
    /// Example: =
    /// </summary>
    public enum EventsTableBooleanConditionOperator
    {
        /// <summary>
        /// 
        /// </summary>
        Eq,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EventsTableBooleanConditionOperatorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EventsTableBooleanConditionOperator value)
        {
            return value switch
            {
                EventsTableBooleanConditionOperator.Eq => "=",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EventsTableBooleanConditionOperator? ToEnum(string value)
        {
            return value switch
            {
                "=" => EventsTableBooleanConditionOperator.Eq,
                _ => null,
            };
        }
    }
}