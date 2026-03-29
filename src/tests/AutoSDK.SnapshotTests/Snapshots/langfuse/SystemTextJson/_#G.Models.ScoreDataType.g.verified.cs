//HintName: G.Models.ScoreDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        Correction,
        /// <summary>
        /// 
        /// </summary>
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreDataType value)
        {
            return value switch
            {
                ScoreDataType.Boolean => "BOOLEAN",
                ScoreDataType.Categorical => "CATEGORICAL",
                ScoreDataType.Correction => "CORRECTION",
                ScoreDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreDataType.Boolean,
                "CATEGORICAL" => ScoreDataType.Categorical,
                "CORRECTION" => ScoreDataType.Correction,
                "NUMERIC" => ScoreDataType.Numeric,
                _ => null,
            };
        }
    }
}