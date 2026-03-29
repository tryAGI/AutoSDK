//HintName: G.Models.ScoreConfigDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreConfigDataType
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
        Numeric,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreConfigDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreConfigDataType value)
        {
            return value switch
            {
                ScoreConfigDataType.Boolean => "BOOLEAN",
                ScoreConfigDataType.Categorical => "CATEGORICAL",
                ScoreConfigDataType.Numeric => "NUMERIC",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreConfigDataType? ToEnum(string value)
        {
            return value switch
            {
                "BOOLEAN" => ScoreConfigDataType.Boolean,
                "CATEGORICAL" => ScoreConfigDataType.Categorical,
                "NUMERIC" => ScoreConfigDataType.Numeric,
                _ => null,
            };
        }
    }
}