//HintName: G.Models.ScoreVariant1DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreVariant1DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreVariant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreVariant1DataType value)
        {
            return value switch
            {
                ScoreVariant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreVariant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreVariant1DataType.Numeric,
                _ => null,
            };
        }
    }
}