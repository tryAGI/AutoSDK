//HintName: G.Models.WriteOrdering.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Defines write ordering guarantees for collection operations<br/>
    /// * `weak` - write operations may be reordered, works faster, default<br/>
    /// * `medium` - write operations go through dynamically selected leader, may be inconsistent for a short period of time in case of leader change<br/>
    /// * `strong` - Write operations go through the permanent leader, consistent, but may be unavailable if leader is down
    /// </summary>
    public enum WriteOrdering
    {
        /// <summary>
        /// 
        /// </summary>
        Medium,
        /// <summary>
        /// 
        /// </summary>
        Strong,
        /// <summary>
        /// 
        /// </summary>
        Weak,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WriteOrderingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WriteOrdering value)
        {
            return value switch
            {
                WriteOrdering.Medium => "medium",
                WriteOrdering.Strong => "strong",
                WriteOrdering.Weak => "weak",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WriteOrdering? ToEnum(string value)
        {
            return value switch
            {
                "medium" => WriteOrdering.Medium,
                "strong" => WriteOrdering.Strong,
                "weak" => WriteOrdering.Weak,
                _ => null,
            };
        }
    }
}