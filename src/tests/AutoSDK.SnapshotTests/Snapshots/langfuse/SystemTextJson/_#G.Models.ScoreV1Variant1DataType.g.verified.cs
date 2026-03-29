//HintName: G.Models.ScoreV1Variant1DataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreV1Variant1DataType
    {
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreV1Variant1DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreV1Variant1DataType value)
        {
            return value switch
            {
                ScoreV1Variant1DataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreV1Variant1DataType? ToEnum(string value)
        {
            return value switch
            {
                "NUMERIC" => ScoreV1Variant1DataType.Numeric,
                _ => null,
            };
        }
    }
}