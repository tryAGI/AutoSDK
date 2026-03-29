//HintName: G.Models.ScoreVariant3DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreVariant3DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreVariant3DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreVariant3DataType value)
        {
            return value switch
            {
                ScoreVariant3DataType.Boolean => "BOOLEAN",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreVariant3DataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreVariant3DataType.Boolean,
                _ => null,
            };
        }
    }
}