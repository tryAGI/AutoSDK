//HintName: G.Models.ScoreDataType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScoreDataType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BOOLEAN")]
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CATEGORICAL")]
        Categorical,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CORRECTION")]
        Correction,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NUMERIC")]
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