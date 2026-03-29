//HintName: G.Models.FloatIndexType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum FloatIndexType
    {
        /// <summary>
        /// 
        /// </summary>
        Float,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FloatIndexTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FloatIndexType value)
        {
            return value switch
            {
                FloatIndexType.Float => "float",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FloatIndexType? ToEnum(string value)
        {
            return value switch
            {
                "float" => FloatIndexType.Float,
                _ => null,
            };
        }
    }
}