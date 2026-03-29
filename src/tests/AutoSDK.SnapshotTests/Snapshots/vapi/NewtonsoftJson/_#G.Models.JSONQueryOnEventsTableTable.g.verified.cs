//HintName: G.Models.JSONQueryOnEventsTableTable.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the table that will be queried.<br/>
    /// Must be "events" for event-based insights.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JSONQueryOnEventsTableTable
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="events")]
        Events,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JSONQueryOnEventsTableTableExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JSONQueryOnEventsTableTable value)
        {
            return value switch
            {
                JSONQueryOnEventsTableTable.Events => "events",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JSONQueryOnEventsTableTable? ToEnum(string value)
        {
            return value switch
            {
                "events" => JSONQueryOnEventsTableTable.Events,
                _ => null,
            };
        }
    }
}