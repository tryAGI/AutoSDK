//HintName: G.Models.IntegerIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum IntegerIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        Integer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IntegerIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IntegerIndexType value)
        {
            return value switch
            {
                IntegerIndexType.Integer => "integer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IntegerIndexType? ToEnum(string value)
        {
            return value switch
            {
                "integer" => IntegerIndexType.Integer,
                _ => null,
            };
        }
    }
}