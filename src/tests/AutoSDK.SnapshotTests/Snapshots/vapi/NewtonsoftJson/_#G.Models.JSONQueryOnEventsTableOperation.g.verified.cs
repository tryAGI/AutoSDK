//HintName: G.Models.JSONQueryOnEventsTableOperation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the operation to perform on matching events.<br/>
    /// - "count": Returns the raw count of matching events<br/>
    /// - "percentage": Returns (count of matching events / total calls) * 100<br/>
    /// Example: count
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnEventsTableOperation
    {
        /// <summary>
        /// Returns the raw count of matching events
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="count")]
        Count,
        /// <summary>
        /// Returns (count of matching events / total calls) * 100
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="percentage")]
        Percentage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnEventsTableOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnEventsTableOperation value)
        {
            return value switch
            {
                JSONQueryOnEventsTableOperation.Count => "count",
                JSONQueryOnEventsTableOperation.Percentage => "percentage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnEventsTableOperation? ToEnum(string value)
        {
            return value switch
            {
                "count" => JSONQueryOnEventsTableOperation.Count,
                "percentage" => JSONQueryOnEventsTableOperation.Percentage,
                _ => null,
            };
        }
    }
}